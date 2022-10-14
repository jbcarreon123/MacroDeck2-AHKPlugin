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
using System.Text.RegularExpressions;
using jbcarreon123.AHKPlugin.Languages;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck;
using System.IO;
using Newtonsoft.Json.Linq;

namespace jbcarreon123.AHKPlugin.Actions
{
    public class WriteScriptAction : PluginAction
    {
        public override string Name => PluginLanguageManager.PluginStrings.WriteScriptAction;

        public override string Description => PluginLanguageManager.PluginStrings.WriteScriptActionDesc;

        public override bool CanConfigure => true;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            JObject configurationObject = JObject.Parse(this.Configuration);
            var script = configurationObject["script"].ToString();
            Random Rnd = new Random();
            int rnd = Rnd.Next(10000);
            var pth = PluginConfigHelper.GetPath("v1");

            try
            {
                string pattern = @"{{\s?\w+\s?}}";
                foreach (Match match in Regex.Matches(script, pattern))
                {
                    string var_name = match.Value.Replace("{{", "").Replace("}}", "").Trim();
                    try
                    {
                        string var_value = VariableManager.ListVariables.FirstOrDefault(v => v.Name.Equals(var_name)).Value;
                        script = script.Replace(match.Value, var_value);
                    }
                    catch (Exception e)
                    {
                        MacroDeckLogger.Error(PluginInstance.Main, $"Could not load variable with name \"{var_name}\": {e}");
                    }
                }

                File.WriteAllText(MacroDeck.TempDirectoryPath + "\\" + rnd + ".ahk", script);
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = pth + "\\AutoHotkeyU64.exe";
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