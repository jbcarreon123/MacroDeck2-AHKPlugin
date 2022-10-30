using SuchByte.MacroDeck.Plugins;
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
            LoadWSServer();
            this.Actions = new List<PluginAction>
            {
                new RunScriptAction(),
                new RunScriptv2Action(),
                new WriteScriptAction(),
                new WriteScriptv2Action(),
                new WindowSpyAction(),
            };
            MacroDeckLogger.Info(this, $"Finished loading AHK Plugin ({stp.ElapsedMilliseconds}ms)");
            stp.Reset();
        }

        public override void OpenConfigurator()
        {
            // Open your configuration form here
            using var pluginConfig = new PluginConfig();
            pluginConfig.ShowDialog();
        }

        public void CheckVersions() {
            // checks if AHK_L field is actually AHK_L, not AHKv2
            var pth = PluginConfigHelper.GetPath("v2");
            if (File.Exists(pth + "\\AutoHotkeyU64.exe")) 
                NotificationManager.Notify(PluginInstance.Main, "Not recommended", "Putting AHKv1 in AHKv2's field is not recommended.");
            pth = PluginConfigHelper.GetPath("v1");
            if (File.Exists(pth + "\\AutoHotkey64.exe")) 
                NotificationManager.Notify(PluginInstance.Main, "Not recommended", "Putting AHKv2 in AHKv1's field is not recommended.");
        }

        public void LoadWSServer() {
            MacroDeckLogger.Info(this, "Starting a WebSocket Server for AHKPLib on 0.0.0.0:8192....");
            var server = new WebSocketServer($"ws://0.0.0.0:8192");
            server.Start(socket =>
                {
                    socket.OnMessage = message => {
                        AHKPLib_WSS_JSON obj = JsonConvert.DeserializeObject<AHKPLib_WSS_JSON>(message);
                        if (obj.command == "getvar") {
                            foreach (var variable in VariableManager.Variables) {
                                if (variable.Name == obj.value) {
                                    socket.Send($"{variable.Value}");
                                    break;
                                }
                            }
                        }
                        else if (obj.command == "setvar") {
                            VariableType variableType = new();
                            if (string.Equals(obj.vartype, "string", StringComparison.CurrentCultureIgnoreCase)||string.Equals(obj.vartype, "str", StringComparison.CurrentCultureIgnoreCase)) {
                                variableType = VariableType.String;
                            }
                            else if (string.Equals(obj.vartype, "integer", StringComparison.CurrentCultureIgnoreCase)||string.Equals(obj.vartype, "int", StringComparison.CurrentCultureIgnoreCase)) {
                                variableType = VariableType.Integer;
                            }
                            else if (string.Equals(obj.vartype, "float", StringComparison.CurrentCultureIgnoreCase)||string.Equals(obj.vartype, "fl", StringComparison.CurrentCultureIgnoreCase)) {
                                variableType = VariableType.Float;
                            }
                            else if (string.Equals(obj.vartype, "boolean", StringComparison.CurrentCultureIgnoreCase)||string.Equals(obj.vartype, "bool", StringComparison.CurrentCultureIgnoreCase)) {
                                variableType = VariableType.Bool;
                            }
                            else {
                                socket.Send($"ERROR: No such thing as {obj.vartype}");
                                return;
                            }
                            VariableManager.SetValue(obj.value, obj.varvalue, variableType, this);
                        }
                        else if (obj.command == "notify") {
                            NotificationManager.Notify(this, obj.title, obj.value, obj.boolean);
                        }
                        else if (obj.command == "log") {
                            if (string.Equals(obj.vartype, "trace", StringComparison.CurrentCultureIgnoreCase)) {
                                MacroDeckLogger.Trace(this, obj.value);
                            }
                            else if (string.Equals(obj.vartype, "info", StringComparison.CurrentCultureIgnoreCase)) {
                                MacroDeckLogger.Info(this, obj.value);
                            }
                            else if (string.Equals(obj.vartype, "warning", StringComparison.CurrentCultureIgnoreCase)) {
                                MacroDeckLogger.Warning(this, obj.value);
                            }
                            else if (string.Equals(obj.vartype, "error", StringComparison.CurrentCultureIgnoreCase)) {
                                MacroDeckLogger.Error(this, obj.value);
                            }
                            else {
                                socket.Send($"ERROR: No such thing as {obj.vartype}");
                            }
                        }
                        else if (obj.command == "mdver") {
                            socket.Send($"{MacroDeck.Version.VersionString}");
                        }
                        else {
                            socket.Send($"ERROR: Command {obj.command} does not exist.");
                        }
                    };
                    socket.OnOpen = () => MacroDeckLogger.Info(this, "WebSocket Connected.");
                });
        }
    }

    public class AHKPLib_WSS_JSON
    {
        public string version { get; set; }
        public string command { get; set; }
        public string title { get; set; }
        public bool boolean { get; set; }
        public string value { get; set; }
        public string vartype { get; set; }
        public string varvalue { get; set; }
    }
}
