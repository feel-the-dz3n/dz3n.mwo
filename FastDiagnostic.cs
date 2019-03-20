using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Dz3n.MWO
{
    public class FastDiagnostic
    {
        public bool Finished = false;

        FileInfo DiagModule = new FileInfo("MWO-Diagnostic.exe");
        Assembly diag;
        Form1 Parent;

        public FastDiagnostic(string gamefolder, Form1 parent)
        {
            Parent = parent;
            new Thread(() =>
            {
                if (DiagModule.Exists && File.Exists("speed.exe"))
                {
                    diag = Assembly.LoadFile(DiagModule.FullName);
                    var toolType = diag.GetType("MostWantedOnlineHelper.DiagnosticTool");
                    var tool = Activator.CreateInstance(toolType);

                    AddEvent(tool, "StatusChanged", m("Tool_StatusChanged"));
                    AddEvent(tool, "SubStatusChanged", m("Tool_SubStatusChanged"));
                    AddEvent(tool, "OnErrorMessage", m("Tool_OnErrorMessage"));
                    AddEvent(tool, "OnFixMessage", m("Tool_OnFixMessage"));
                    AddEvent(tool, "ProgressChanged", m("Tool_ProgressChanged"));
                    AddEvent(tool, "FinishedText", m("Tool_FinishedText"));

                    var start = toolType.GetMethod("StartDiagnostic");
                    start.Invoke(tool, new object[] { new DirectoryInfo(gamefolder).FullName, parent });
                }
                else
                    Finished = true;
            }).Start();
        }

        private void AddEvent(object eventSource, string eventName, MethodInfo handlermethod)
        {
            EventInfo evt = eventSource.GetType().GetEvent(eventName);
            var del = Delegate.CreateDelegate(evt.EventHandlerType, this, handlermethod);
            evt.AddEventHandler(eventSource, del);
        }

        private MethodInfo m(string name)
        {
            var methods = this.GetType().GetMethods();

            foreach (var method in methods)
                if (method.Name == name)
                    return method;

            return null;
        }

        public void Tool_StatusChanged(string text = "")
        {
        }

        public void Tool_SubStatusChanged(string text = "")
        {
        }

        public void Tool_OnErrorMessage(string text, string title)
        {

        }

        public bool Tool_OnFixMessage(string details, string text = "")
            => false;

        public void Tool_ProgressChanged(int value, int maxvalue)
        {
        }

        public void Tool_FinishedText(string FormattedResults, string FormattedOnlyProblems, int OnlyProblemsCount, int OnlyFixedCount, int TotalCount)
        {
            if (OnlyProblemsCount > 0)
            {
                Parent.Invoke(new Action(() => 
                {
                    var d = MessageBox.Show(Parent.t("FoundProblems") + "\r\n\r\n" + FormattedOnlyProblems, "Most Wanted Online", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (d == DialogResult.Yes)
                        Process.Start(DiagModule.FullName);
                }));
            }

            Finished = true;
        }
    }
}
