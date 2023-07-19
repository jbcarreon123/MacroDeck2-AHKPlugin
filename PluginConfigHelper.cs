// got from PiHole Plugin by SuchByte and modified it.

using SuchByte.MacroDeck.Plugins;
using System;

namespace jbcarreon123.AHKPlugin
{
    public class PluginConfigHelper
    {

        public static void UpdatePath(string ver, string path)
        {
            if (ver == "v1")
            {
                PluginConfiguration.SetValue(Main.Instance, "path", path);
            }
            else if (ver == "v2ch")
            {
                PluginConfiguration.SetValue(Main.Instance, "v1ch", path);
            }
            else if (ver == "temp")
            {
                PluginConfiguration.SetValue(Main.Instance, "temp", path);
            }
            else
            {
                PluginConfiguration.SetValue(Main.Instance, "v2path", path);
            }
        }

        public static string GetPath(string ver)
        {
            if (ver == "v1")
            {
                var path = PluginConfiguration.GetValue(Main.Instance, "path");
                if (string.IsNullOrWhiteSpace(path))
                {
                    path = "C:\\Program Files\\AutoHotkey\\";
                }
                return path;
            }
            else if (ver == "v1ch")
            {
                var path = PluginConfiguration.GetValue(Main.Instance, "v1ch");
                if (string.IsNullOrWhiteSpace(path))
                {
                    path = "false";
                }
                return path;
            }
            else if (ver == "v2")
            {
                var path = PluginConfiguration.GetValue(Main.Instance, "v2path");
                if (string.IsNullOrWhiteSpace(path))
                {
                    path = "C:\\Program Files\\AutoHotkey\\v2\\";
                }
                return path;
            }
            else
            {
                var path = PluginConfiguration.GetValue(Main.Instance, "temp");
                if (string.IsNullOrWhiteSpace(path))
                {
                    path = Environment.GetEnvironmentVariable("temp");
                }
                return path;
            }
        }

    }
}