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
using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.Logging;

namespace jbcarreon123.AHKPlugin.Actions
{
    public class RunScriptAction : PluginAction
    {
        public override string Name => PluginLanguageManager.PluginStrings.RunScriptAction;

        public override string Description => PluginLanguageManager.PluginStrings.RunScriptActionDesc;

        public override bool CanConfigure => true;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            JObject configurationObject = JObject.Parse(this.Configuration);
            var script = configurationObject["ahkScriptPath"].ToString();
            var pth = PluginConfigHelper.GetPath("v2");

            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = pth + "\\AutoHotkey.exe";
                proc.StartInfo.Arguments = "\"" + script + "\"";
                proc.Start();
            }
            catch (Exception e)
            {
                MacroDeckLogger.Error(PluginInstance.Main, $"{e}");
            }
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new RunScript(this);
        }
    }
}