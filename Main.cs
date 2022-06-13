using SuchByte.MacroDeck.Plugins;
using jbcarreon123.AHKPlugin.GUI;
using jbcarreon123.AHKPlugin.Actions;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System;

namespace jbcarreon123.AHKPlugin
{
    public static class PluginInstance
    {
        public static Main Main { get; set; }
    }

    public class Main : MacroDeckPlugin
    {

        public override bool CanConfigure => true;
        public static Main Instance;

        public Main()
        {
            Instance = this;
            PluginInstance.Main = this;
        }

        public override void Enable()
        {
            Instance ??= this;
            this.Actions = new List<PluginAction>
            {
                new RunScriptAction(),
                new RunScriptv2Action(),
                new WriteScriptAction(),
                new WriteScriptv2Action(),
            };
        }

        public override void OpenConfigurator()
        {
            // Open your configuration form here
            using var pluginConfig = new PluginConfig();
            pluginConfig.ShowDialog();
        }
    }
}
