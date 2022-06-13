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

namespace jbcarreon123.AHKPlugin.Actions
{
    public class RunScriptv2Action : PluginAction
    {
        public override string Name => PluginLanguageManager.PluginStrings.RunScriptv2Action;

        public override string Description => PluginLanguageManager.PluginStrings.RunScriptv2ActionDesc;

        public override bool CanConfigure => true;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
        }

        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new RunScriptv2(this);
        }
    }
}