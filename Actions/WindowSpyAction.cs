using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Variables;
using jbcarreon123.AHKPlugin.GUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using jbcarreon123.AHKPlugin.Languages;
using SuchByte.MacroDeck.Logging;
using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck;

namespace jbcarreon123.AHKPlugin.Actions
{
    public class WindowSpyAction : PluginAction
    {
        public override string Name => PluginLanguageManager.PluginStrings.WindowSpyAction;

        public override string Description => PluginLanguageManager.PluginStrings.WindowSpyActionDesc;

        public override bool CanConfigure => false;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var pth = PluginConfigHelper.GetPath("v1");
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = pth + "\\AutoHotkeyU64.exe";
            proc.StartInfo.Arguments = "\"" + pth + "\\WindowSpy.ahk" + "\"";

            proc.Start();
        }
    }

}