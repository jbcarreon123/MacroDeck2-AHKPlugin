using SuchByte.MacroDeck.GUI.CustomControls;
using System.Runtime.InteropServices;
using System;

namespace jbcarreon123.AHKPlugin.GUI
{
    partial class PluginConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.button2 = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.buttonPrimary1 = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundedTextBox1 = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.buttonPrimary2 = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "AutoHotkey install path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Icon = null;
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.MaxCharacters = 32767;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBox1.PasswordChar = false;
            this.textBox1.PlaceHolderColor = System.Drawing.Color.Gray;
            this.textBox1.PlaceHolderText = "";
            this.textBox1.ReadOnly = false;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(435, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.Load += new System.EventHandler(this.textBox1_Load);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BorderRadius = 8;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.HoverColor = System.Drawing.Color.Empty;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(453, 50);
            this.button2.Name = "button2";
            this.button2.Progress = 0;
            this.button2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.button2.Size = new System.Drawing.Size(83, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWindowsAccentColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPrimary1
            // 
            this.buttonPrimary1.BorderRadius = 8;
            this.buttonPrimary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimary1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrimary1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPrimary1.HoverColor = System.Drawing.Color.Empty;
            this.buttonPrimary1.Icon = null;
            this.buttonPrimary1.Location = new System.Drawing.Point(453, 306);
            this.buttonPrimary1.Name = "buttonPrimary1";
            this.buttonPrimary1.Progress = 0;
            this.buttonPrimary1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonPrimary1.Size = new System.Drawing.Size(83, 27);
            this.buttonPrimary1.TabIndex = 5;
            this.buttonPrimary1.Text = "OK";
            this.buttonPrimary1.UseVisualStyleBackColor = true;
            this.buttonPrimary1.UseWindowsAccentColor = true;
            this.buttonPrimary1.Click += new System.EventHandler(this.buttonPrimary1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(268, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Default AHK Install path";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 23);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "AutoHotkey v2";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(151, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add AutoHotkey version 2 in Actions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(148, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remove AutoHotkey version 2 in Actions";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "AutoHotkey v2 Install Path";
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.roundedTextBox1.Enabled = false;
            this.roundedTextBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundedTextBox1.Icon = null;
            this.roundedTextBox1.Location = new System.Drawing.Point(12, 163);
            this.roundedTextBox1.MaxCharacters = 32767;
            this.roundedTextBox1.Multiline = false;
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.roundedTextBox1.PasswordChar = false;
            this.roundedTextBox1.PlaceHolderColor = System.Drawing.Color.Gray;
            this.roundedTextBox1.PlaceHolderText = "";
            this.roundedTextBox1.ReadOnly = false;
            this.roundedTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roundedTextBox1.SelectionStart = 0;
            this.roundedTextBox1.Size = new System.Drawing.Size(435, 25);
            this.roundedTextBox1.TabIndex = 11;
            this.roundedTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.roundedTextBox1.Load += new System.EventHandler(this.RoundedTextBox1_Load);
            this.roundedTextBox1.TextChanged += new System.EventHandler(this.roundedTextBox1_TextChanged);
            // 
            // buttonPrimary2
            // 
            this.buttonPrimary2.BorderRadius = 8;
            this.buttonPrimary2.Enabled = false;
            this.buttonPrimary2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimary2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrimary2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPrimary2.HoverColor = System.Drawing.Color.Empty;
            this.buttonPrimary2.Icon = null;
            this.buttonPrimary2.Location = new System.Drawing.Point(453, 163);
            this.buttonPrimary2.Name = "buttonPrimary2";
            this.buttonPrimary2.Progress = 0;
            this.buttonPrimary2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(205)))));
            this.buttonPrimary2.Size = new System.Drawing.Size(83, 27);
            this.buttonPrimary2.TabIndex = 12;
            this.buttonPrimary2.Text = "Browse";
            this.buttonPrimary2.UseVisualStyleBackColor = true;
            this.buttonPrimary2.UseWindowsAccentColor = true;
            this.buttonPrimary2.Click += new System.EventHandler(this.buttonPrimary2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Note - AHKv2 is in Alpha stage!";
            // 
            // PluginConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPrimary2);
            this.Controls.Add(this.roundedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonPrimary1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginConfig";
            this.Text = "PluginConfiguration";
            this.Load += new System.EventHandler(this.PluginConfig_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.buttonPrimary1, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.roundedTextBox1, 0);
            this.Controls.SetChildIndex(this.buttonPrimary2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RoundedTextBox textBox1;
        private ButtonPrimary button2;
        private ButtonPrimary buttonPrimary1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RoundedTextBox roundedTextBox1;
        private ButtonPrimary buttonPrimary2;
        private System.Windows.Forms.Label label6;
    }
}