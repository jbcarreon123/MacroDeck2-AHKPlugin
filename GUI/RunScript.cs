using jbcarreon123.AHKPlugin.Languages;
using Newtonsoft.Json.Linq;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Form = System.Windows.Forms.Form;

namespace jbcarreon123.AHKPlugin.GUI
{
    public partial class RunScript : ActionConfigControl
    {
        PluginAction pluginAction;

        public RunScript(PluginAction pluginAction)
        {
            this.pluginAction = pluginAction;
            InitializeComponent();
            label1.Text = PluginLanguageManager.PluginStrings.RunScriptPath;
            label2.Text = PluginLanguageManager.PluginStrings.RunScriptNote;
            label3.Text = PluginLanguageManager.PluginStrings.DontUseEXE;

            this.LoadConfig();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            if (txt.EndsWith("\\"))
            {
                txt = txt.Substring(0, txt.Length - 1);
            }
            if (File.Exists(txt))
            {
                if (txt.EndsWith(".ahk"))
                {
                    textBox1.BackColor = Color.FromArgb(65, 65, 65);
                }
                else
                {
                    textBox1.BackColor = Color.FromArgb(253, 26, 18);
                }

            }
            else
            {
                textBox1.BackColor = Color.FromArgb(253, 26, 18);
            }
        }

        private void textBox1_DragDrop(object sender, EventArgs e)
        {
            //Can't implement.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void LoadConfig()
        {
            if (!String.IsNullOrWhiteSpace(this.pluginAction.Configuration))
            {
                try
                {
                    JObject configurationObject = JObject.Parse(this.pluginAction.Configuration);
                    this.textBox1.Text = configurationObject["ahkScriptPath"].ToString();
                }
                catch { }
            }
        }

        public override bool OnActionSave()
        {
            if ((textBox1.Text).EndsWith("\\"))
            {
                textBox1.Text = (textBox1.Text).Substring(0, (textBox1.Text).Length - 1);
            }
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                messageBox.ShowDialog("Path is empty", "The path textbox is empty. Please make sure you added a path into the textbox and try again.", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                if (File.Exists(textBox1.Text))
                {
                    if ((textBox1.Text).EndsWith(".ahk"))
                    {
                        MacroDeckLogger.Info(PluginInstance.Main, $"Saved RunScript action config with path: {textBox1.Text}");
                        JObject configurationObject = JObject.FromObject(new
                        {
                            ahkScriptPath = this.textBox1.Text,
                        });
                        this.pluginAction.Configuration = configurationObject.ToString();
                        this.pluginAction.ConfigurationSummary = this.textBox1.Text;
                        return true;
                    }
                    else
                    {
                        using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                        messageBox.ShowDialog("Can't verify if it is a AHK file", "Please make sure you pointed to a .ahk file and try again.", MessageBoxButtons.OK);
                        return false;
                    }
                }
                else
                {
                    using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                    messageBox.ShowDialog("Can't find path", "Please make sure that you use the correct path and try again.", MessageBoxButtons.OK);
                    return false;
                }
            }
        }

        private void RunScript_Load(object sender, EventArgs e)
        {

        }
    }
}
