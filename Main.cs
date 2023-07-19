using SuchByte.MacroDeck.Plugins;
using System.Net;
using SuchByte.MacroDeck.Variables;
using jbcarreon123.AHKPlugin.GUI;
using jbcarreon123.AHKPlugin.Actions;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Notifications;
using System.Collections.Generic;
using System.Web;
using SuchByte.MacroDeck;
using System.Drawing;
using Newtonsoft.Json;
using System.Reflection;
using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.Versioning;
using Fleck;

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
            Stopwatch stp = new Stopwatch();
            stp.Start();
            Instance ??= this;
            CheckVersions();
            if (bool.Parse(PluginConfigHelper.GetPath("v1ch")))
            {
                this.Actions = new List<PluginAction>
                {
                    new RunScriptv2Action(),
                    new WriteScriptv2Action(),
                    new RunScriptAction(),
                    new WriteScriptAction(),
                    new WindowSpyAction(),
                };
            }
            else
            {
                this.Actions = new List<PluginAction>
                {
                    new RunScriptv2Action(),
                    new WriteScriptv2Action(),
                    new WindowSpyAction(),
                };
            }

            MacroDeckLogger.Info(this, $"Finished loading AHK Plugin ({stp.ElapsedMilliseconds}ms)");
            stp.Reset();
        }

        public override void OpenConfigurator()
        {
            // Open your configuration form here
            using var pluginConfig = new PluginConfig();
            pluginConfig.ShowDialog();
        }

        public void CheckVersions()
        {
            // checks if AHK_L field is actually AHK_L, not AHKv2
            var pth = PluginConfigHelper.GetPath("v2");
            if (File.Exists(pth + "\\AutoHotkeyU64.exe"))
                NotificationManager.Notify(PluginInstance.Main, "Not recommended",
                    "Putting AHKv1 in AHKv2\"s field is not recommended.");
            pth = PluginConfigHelper.GetPath("v1");
            if (File.Exists(pth + "\\AutoHotkey64.exe"))
                NotificationManager.Notify(PluginInstance.Main, "Not recommended",
                    "Putting AHKv2 in AHKv1\"s field is not recommended.");
        }
    }
}
