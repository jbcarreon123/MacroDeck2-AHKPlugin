using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Variables;
using SuchByte.MacroDeck;
using jbcarreon123.AHKPlugin.GUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using jbcarreon123.AHKPlugin.Languages;
using Newtonsoft.Json.Linq;
using System.IO;
using SuchByte.MacroDeck.Logging;

namespace jbcarreon123.AHKPlugin.Actions
{
    public class WriteScriptv2Action : PluginAction
    {
        public override string Name => PluginLanguageManager.PluginStrings.WriteScriptv2Action;

        public override string Description => PluginLanguageManager.PluginStrings.WriteScriptv2ActionDesc;

        public override bool CanConfigure => true;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            JObject configurationObject = JObject.Parse(this.Configuration);
            var script = configurationObject["script"].ToString();
            Random Rnd = new Random();
            int rnd = Rnd.Next(10000);
            var pth = PluginConfigHelper.GetPath("v2");

            try
            {
                File.WriteAllText(MacroDeck.TempDirectoryPath + "\\" + rnd + ".ahk", script);
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = pth + "\\AutoHotkey.exe";
                proc.StartInfo.Arguments = "\"" + MacroDeck.TempDirectoryPath + "\\" + rnd + ".ahk" + "\"";
                proc.EnableRaisingEvents = true;

                proc.Exited += (sender, e) => {
                    var dpth = MacroDeck.TempDirectoryPath + "\\" + rnd + ".ahk";
                    File.Delete(dpth);
                };
                proc.Start();
            }
            catch (Exception e)
            {
                MacroDeckLogger.Error(PluginInstance.Main, $"{e}");
            }
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new WriteScript(this);
        }
    }
}

