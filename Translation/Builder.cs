/* 
   PROJECT:     Most Wanted Online -> Launcher
   LICENSE:     (See it on GitHub page)
   FILE:        Builder.cs
   DESCRIPTION: Language resources & tools
   PROGRAMMERS: Yaroslav Kibysh (2018 - 2019)
   GITHUB:      https://github.com/feel-the-dz3n/dz3n.mwo
*/
using DotNetTranslator;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Dz3n.MWO.Translation
{
    class Builder
    {
        static Dictionary<string, string> English = new Dictionary<string, string>()
        {
            { "labelServer", "Server:" },
            { "linkProblems", "Problems?" },
            { "linkDiscord", "Discord" },
            { "linkMore", "More" },
            { "Players Online", "{0} players" },
            { "Monitoring unavailable", "Monitoring unavailable" },
            { "ConnectionProblems", "Connection interupted" },
            { "ServerOffline", "Server is offline" },
            { "Welcome", "Welcome back to MWO, {0}!" },
            { "UpdateText", "MWO {0} is available. You can't play until you update MWO." },
            { "UpdateButton", "Update" },
            { "ServerOfflineError", "The server is down! Please choose the another one." },
            { "FoundProblems", "We found some problems. Click 'Yes' if you want to run Diagnostic Tool and try to fix them." },
        };

        static Dictionary<string, string> Polish = new Dictionary<string, string>()
        {
            { "labelServer", "Server:" },
            { "linkProblems", "Problems?" },
            { "linkDiscord", "Discord" },
            { "linkMore", "More" },
            { "Players Online", "{0} gracz(y/ów)" },
            { "Monitoring unavailable", "Monitoring nie dostępny" },
            { "ConnectionProblems", "Połączenie przerwane" },
            { "ServerOffline", "Serwer jest nie dostępny" },
            { "Welcome", "Witaj z powrotem w MWO, {0}!" },
            { "UpdateText", "MWO {0} is available. You can't play until you update MWO." },
            { "UpdateButton", "Update" },
            { "ServerOfflineError", "Serwer upadł! Proszę wybrać inny." },
        };

        static Dictionary<string, string> Russian = new Dictionary<string, string>()
        {
            { "labelServer", "Сервер:" },
            { "linkProblems", "Проблемы?" },
            { "linkDiscord", "Discord" },
            { "linkMore", "Ещё" },
            { "Players Online", "{0} игроков" },
            { "Monitoring unavailable", "Мониторинг не доступен" },
            { "ConnectionProblems", "Соединение прервано" },
            { "ServerOffline", "Сервер выключен" },
            { "Welcome", "С возвращением в MWO, {0}!" },
            { "UpdateText", "Доступен MWO {0}. Вы не можете играть, пока не обновите MWO." },
            { "UpdateButton", "Обновить" },
            { "ServerOfflineError", "Сервер выключен! Пожалуйста, выберите другой." },
            { "FoundProblems", "Мы нашли некоторые проблемы. Нажмите 'Да' если Вы хотите запустить программу диагностики и попробовать починить проблемы." },
        };

        static Dictionary<string, string> Ukrainian = new Dictionary<string, string>()
        {
            { "labelServer", "Сервер:" },
            { "linkProblems", "Проблеми?" },
            { "linkDiscord", "Discord" },
            { "linkMore", "Ще" },
            { "Players Online", "{0} гравців" },
            { "Monitoring unavailable", "Моніторинг не доступний" },
            { "ConnectionProblems", "З'єднання перервано" },
            { "ServerOffline", "Сервер вимкнено" },
            { "Welcome", "З поверненням в MWO, {0}!" },
            { "UpdateText", "Доступний MWO {0}. Ви не можете грати, доки не оновите MWO." },
            { "UpdateButton", "Оновити" },
            { "ServerOfflineError", "Сервер вимкнено! Будь-ласка, виберіть інший." },
            { "FoundProblems", "Ми знайшли деякі проблеми. Натисніть 'Так' якщо Ви хочете запустити програму діагностики і спробувати налагодити проблеми." },
        };

        public static AvailableTranslations Initialize()
        {
            AvailableTranslations Translation = new AvailableTranslations();

            Translation.Translations.Add(new DotNetTranslator.Translation("English", "en-US", English, "English"));
            Translation.Translations.Add(new DotNetTranslator.Translation("Polish", "pl-PL", Polish, "Polski"));
            Translation.Translations.Add(new DotNetTranslator.Translation("Russian", "ru-RU", Russian, "Русский"));
            Translation.Translations.Add(new DotNetTranslator.Translation("Ukrainian", "uk-UA", Ukrainian, "Українська"));

            if (Properties.Settings.Default.Language.Length > 0)
            {
                Translation.SelectedTranslation = Translation.GetTranslation(Properties.Settings.Default.Language);
            }
            else
            {
                var system = Translation.GetTranslation(CultureInfo.InstalledUICulture.DisplayName);
                if (system != null) Translation.SelectedTranslation = system;
            }

            return Translation;
        }
    }
}
