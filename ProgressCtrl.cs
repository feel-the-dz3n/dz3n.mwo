using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dz3n.MWO
{
    public partial class ProgressCtrl : UserControl
    {
        Form1 p;
        public ProgressCtrl(Form1 parent)
        {
            p = parent;

            InitializeComponent();
        }
    }
}
