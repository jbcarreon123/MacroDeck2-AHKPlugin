using System;
using System.Collections.Generic;
using System.Text;

namespace jbcarreon123.AHKPlugin.Languages
{
    public class PluginStrings
    {
        public string __Language__ = "English";
        public string __LanguageCode__ = "en";
        public string __Author__ = "jbcarreon123";

        public string DontUseEXE = "Don't put AHK2EXE compiled EXE files here! Use Windows Utils Run Application instead.";

        // Plugin Config
        public string AHKScriptPath = "AutoHotkey Script Path";
        public string AHKScriptPathv2 = "AutoHotkey v2 Script Path";
        public string AHKScriptPathv2Note = "Note: AHKv2 is in Alpha!";
        public string AHKScriptPathExpl = "Why this requires the AutoHotkey installation path?\r\n\r\nBecause, fortunately, I found a AHK dll.But, 1. it's only\r\nv2(on alpha) compatible and 2. it's only partial. So I\r\ndidn't use that AutoHotkey DLL.";
        public string DefaultAHKPath = "Default AHK Install path";
        public string Addv2 = "Add AutoHotkey version 2 in Actions";
        public string Remv2 = "Remove AutoHotkey version 2 in Actions";

        // Run Script
        public string RunScriptAction = "Run AHK Script";
        public string RunScriptActionDesc = "Run a AutoHotkey script";
        public string RunScriptPath = "AutoHotkey Script Path";
        public string RunScriptNote = "Don't add AHKv2 Scripts here! Go to Run AHK Script [v2].";

        // Run Script v2
        public string RunScriptv2Action = "Run AHKv2 Script";
        public string RunScriptv2ActionDesc = "Run a AutoHotkey version 2 script";
        public string RunScriptv2Path = "AutoHotkey v2 Script Path";
        public string RunScriptv2Note = "Don't add AHKv1 Scripts here! Go to Run AHK Script.";

        // Write Script
        public string WriteScriptAction = "Write and Run AHK Script";
        public string WriteScriptActionDesc = "Write and Run a AHK Script";
        public string WriteScriptNote = "Don't write AHKv2 Scripts here! Go to Write and Run AHKv2 Script.";

        // Write Script v2
        public string WriteScriptv2Action = "Write and Run AHKv2 Script";
        public string WriteScriptv2ActionDesc = "Write and Run a AHKv2 Script";
        public string WriteScriptv2Note = "Don't write AHKv1 Scripts here! Go to Write and Run AHK Script.";

        // Window Spy
        public string WindowSpyAction = "Window Spy";
        public string WindowSpyActionDesc = "Run Window Spy";

        // Msgbox
        public string PathEmpty = "Path is empty";
        public string PathEmptyDesc = "The path textbox is empty. Please make sure you added a path into the textbox and try again.";
        public string CantVerify = "Can't verify if it is a AHK file";
        public string CantVerifyDesc = "Please make sure you pointed to a .ahk file and try again.";
        public string CantFindPath = "Can't find path";
        public string CantFindPathDesc = "Please make sure that you use the correct path and try again.";

        // Logger
        public string RunScriptFin = "Saved RunScript action config with path:";
        public string RunScriptv2Fin = "Saved RunScriptv2 action config with path:";
        public string WriteScriptFin = "Saved WriteScript action config with lines:";
        public string WriteScriptv2Fin = "Saved WriteScriptv2 action config with lines:";
    }
}
