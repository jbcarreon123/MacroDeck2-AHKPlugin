using System;
using SuchByte.MacroDeck;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Language;
using System.Runtime.InteropServices;
using System.Drawing;
using jbcarreon123.AHKPlugin;
using SuchByte.MacroDeck.GUI.CustomControls;
using jbcarreon123.AHKPlugin.Languages;
using Microsoft.VisualBasic;

namespace jbcarreon123.AHKPlugin.GUI
{
    public partial class PluginConfig : DialogForm
    {
        public PluginConfig()
        {
            InitializeComponent();
            checkBox1.Checked = bool.Parse(PluginConfigHelper.GetPath("v1ch"));
            label1.Text = PluginLanguageManager.PluginStrings.AHKScriptPathExpl;
            label2.Text = PluginLanguageManager.PluginStrings.AHKScriptPath;
            label3.Text = PluginLanguageManager.PluginStrings.Addv1;
            label4.Text = PluginLanguageManager.PluginStrings.Remv1;
            label5.Text = PluginLanguageManager.PluginStrings.AHKScriptPathv1;
            label6.Text = PluginLanguageManager.PluginStrings.AHKScriptPathv1Note;
            linkLabel1.Text = PluginLanguageManager.PluginStrings.DefaultAHKPath;

        }

        private void buttonPrimary1_Click(object sender, EventArgs e)
        {
            bool excp = false;
            string path = textBox1.Text;
            string v2path = roundedTextBox1.Text;
            if (excp == false)
            {
                if (File.Exists(v2path + "\\AutoHotkey64.exe"))
                {
                    excp = false;
                    if (v2path.EndsWith("\\"))
                    {
                        PluginConfigHelper.UpdatePath("v2", v2path);
                    }
                    else
                    {
                        v2path += "\\";
                        PluginConfigHelper.UpdatePath("v2", v2path);
                    }
                }
                else
                {
                    using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                    messageBox.ShowDialog("Can't find AutoHotkey.exe", "It seems like AutoHotkey.exe is not on the folder. Please make sure that you use the correct path and try again.", MessageBoxButtons.OK);
                    roundedTextBox1.BackColor = Color.FromArgb(253, 26, 18);
                    excp = true;
                    return;
                }

                if (checkBox1.Checked == true)
                {
                    if (File.Exists(path + "\\AutoHotkey.exe") || File.Exists(path + "\\AutoHotkeyU64.exe"))
                    {
                        using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                        if (path.EndsWith("\\"))
                        {
                            PluginConfigHelper.UpdatePath("v1", path);
                        }
                        else
                        {
                            path += "\\";
                            PluginConfigHelper.UpdatePath("v1", path);
                        }
                    }
                    else
                    {
                        using var messageBox = new SuchByte.MacroDeck.GUI.CustomControls.MessageBox();
                        messageBox.ShowDialog("Can't find AutoHotkey.exe", "It seems like AutoHotkey.exe is not on the folder. Please make sure that you use the correct path and try again.", MessageBoxButtons.OK);
                        textBox1.BackColor = Color.FromArgb(253, 26, 18);
                        excp = true;
                        return;
                    }
                }

                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetDefault();
        }

        private void SetDefault()
        {
            string defpath = "C:\\Program Files\\AutoHotkey\\v2\\";
            PluginConfigHelper.UpdatePath("v2", defpath);
            roundedTextBox1.Text = defpath;
        }

        private void textBox1_Load(object sender, EventArgs e)
        {
            var path = PluginConfigHelper.GetPath("v1");
            textBox1.Text = path;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var path = textBox1.Text;
            if (File.Exists(path + "\\AutoHotkey.exe") || File.Exists(path + "\\AutoHotkeyU64.exe"))
            {
                textBox1.BackColor = Color.FromArgb(65, 65, 65);
            }
            else
            {
                textBox1.BackColor = Color.FromArgb(253, 26, 18);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        // Not really implemented, not used

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PluginConfigHelper.UpdatePath("v1ch", Convert.ToString(checkBox1.Checked));
                label4.Visible = true;
                label3.Visible = false;
                textBox1.Enabled = true;
                button2.Enabled = true;
                label5.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            }
            else
            {
                PluginConfigHelper.UpdatePath("v1ch", Convert.ToString(checkBox1.Checked));
                label3.Visible = true;
                label4.Visible = false;
                textBox1.Enabled = false;
                button2.Enabled = false;
                label5.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            }
        }

        private void buttonPrimary2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                roundedTextBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void RoundedTextBox1_Load(object sender, EventArgs e)
        {
            var path = PluginConfigHelper.GetPath("v2");
            roundedTextBox1.Text = path;
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            var path = roundedTextBox1.Text;
            if (File.Exists(path + "\\AutoHotkey64.exe"))
            {
                roundedTextBox1.BackColor = Color.FromArgb(65, 65, 65);
            }
            else
            {
                roundedTextBox1.BackColor = Color.FromArgb(253, 26, 18);
            }
        }

        private void PluginConfig_Load(object sender, EventArgs e)
        {

        }

    }
}
