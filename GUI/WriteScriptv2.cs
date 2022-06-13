using System;
using System.Collections.Generic;
using System.ComponentModel;
using SuchByte.MacroDeck.GUI.CustomControls;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuchByte.MacroDeck.Plugins;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;

namespace jbcarreon123.AHKPlugin.GUI
{
    public partial class WriteScriptv2 : ActionConfigControl
    {
        PluginAction pluginAction;
        string lineColumn = "";

        public WriteScriptv2(PluginAction pluginAction)
        {
            this.pluginAction = pluginAction;
            InitializeComponent();
            this.LoadConfig();
        }

        private void WriteScript_Load(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            int li = richTextBox1.GetLineFromCharIndex(index);
            int firstChar = richTextBox1.GetFirstCharIndexFromLine(li);
            int col = index - firstChar;
            int ecol = richTextBox1.Lines.Length;

            label3.Text = $"Line {li}, Col {col} | Total: Line {ecol}";
            lineColumn = "Lines: " + ecol;
        }

        private void LoadConfig()
        {
            if (!String.IsNullOrWhiteSpace(this.pluginAction.Configuration))
            {
                try
                {
                    JObject configurationObject = JObject.Parse(this.pluginAction.Configuration);
                    this.richTextBox1.Text = configurationObject["script"].ToString();
                }
                catch { }
            }
        }

        public override bool OnActionSave()
        {
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                return false;
            }
            else
            {
                JObject configurationObject = JObject.FromObject(new
                {
                    script = this.richTextBox1.Text,
                });
                this.pluginAction.Configuration = configurationObject.ToString();
                this.pluginAction.ConfigurationSummary = lineColumn;
                return true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            int li = richTextBox1.GetLineFromCharIndex(index);
            int firstChar = richTextBox1.GetFirstCharIndexFromLine(li);
            int col = index - firstChar;
            int ecol = richTextBox1.Lines.Length;

            label3.Text = $"Line {li}, Col {col} | Total: Line {ecol}";
            lineColumn = "Lines: " + ecol;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                richTextBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage())
            {
                richTextBox1.Focus();
                richTextBox1.Paste();
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
            else
            {
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                pasteToolStripMenuItem.Enabled = true;
            }
            else
            {
                pasteToolStripMenuItem.Enabled = false;
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
