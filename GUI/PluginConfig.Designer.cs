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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new RoundedTextBox();
            button2 = new ButtonPrimary();
            buttonPrimary1 = new ButtonPrimary();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            checkBox1 = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            roundedTextBox1 = new RoundedTextBox();
            buttonPrimary2 = new ButtonPrimary();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            label1.Location = new System.Drawing.Point(12, 238);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(400, 95);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(174, 19);
            label2.TabIndex = 2;
            label2.Text = "AutoHotkey install path";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
            textBox1.Enabled = false;
            textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Icon = null;
            textBox1.Location = new System.Drawing.Point(12, 163);
            textBox1.MaxCharacters = 32767;
            textBox1.Multiline = false;
            textBox1.Name = "textBox1";
            textBox1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            textBox1.PasswordChar = false;
            textBox1.PlaceHolderColor = System.Drawing.Color.Gray;
            textBox1.PlaceHolderText = "";
            textBox1.ReadOnly = false;
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox1.SelectionStart = 0;
            textBox1.Size = new System.Drawing.Size(435, 25);
            textBox1.TabIndex = 3;
            textBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            textBox1.Load += textBox1_Load;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BorderRadius = 8;
            button2.Enabled = false;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button2.HoverColor = System.Drawing.Color.Empty;
            button2.Icon = null;
            button2.Location = new System.Drawing.Point(453, 163);
            button2.Name = "button2";
            button2.Progress = 0;
            button2.ProgressColor = System.Drawing.Color.FromArgb(0, 103, 205);
            button2.Size = new System.Drawing.Size(83, 27);
            button2.TabIndex = 4;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.UseWindowsAccentColor = true;
            button2.WriteProgress = true;
            button2.Click += button2_Click;
            // 
            // buttonPrimary1
            // 
            buttonPrimary1.BorderRadius = 8;
            buttonPrimary1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPrimary1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPrimary1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            buttonPrimary1.HoverColor = System.Drawing.Color.Empty;
            buttonPrimary1.Icon = null;
            buttonPrimary1.Location = new System.Drawing.Point(453, 306);
            buttonPrimary1.Name = "buttonPrimary1";
            buttonPrimary1.Progress = 0;
            buttonPrimary1.ProgressColor = System.Drawing.Color.FromArgb(0, 103, 205);
            buttonPrimary1.Size = new System.Drawing.Size(83, 27);
            buttonPrimary1.TabIndex = 5;
            buttonPrimary1.Text = "OK";
            buttonPrimary1.UseVisualStyleBackColor = true;
            buttonPrimary1.UseWindowsAccentColor = true;
            buttonPrimary1.WriteProgress = true;
            buttonPrimary1.Click += buttonPrimary1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = System.Drawing.Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new System.Drawing.Point(268, 78);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(179, 19);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Default AHK Install path";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(12, 110);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(133, 23);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "AutoHotkey v1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            label3.Location = new System.Drawing.Point(151, 111);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(271, 19);
            label3.TabIndex = 8;
            label3.Text = "Add AutoHotkey version 2 in Actions";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            label4.Location = new System.Drawing.Point(148, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(313, 19);
            label4.TabIndex = 9;
            label4.Text = "Remove AutoHotkey version 1.1 in Actions";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label5.Location = new System.Drawing.Point(12, 141);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(198, 19);
            label5.TabIndex = 10;
            label5.Text = "AutoHotkey v1 Install Path";
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = System.Drawing.Color.FromArgb(65, 65, 65);
            roundedTextBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            roundedTextBox1.Icon = null;
            roundedTextBox1.Location = new System.Drawing.Point(12, 50);
            roundedTextBox1.MaxCharacters = 32767;
            roundedTextBox1.Multiline = false;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceHolderColor = System.Drawing.Color.Gray;
            roundedTextBox1.PlaceHolderText = "";
            roundedTextBox1.ReadOnly = false;
            roundedTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            roundedTextBox1.SelectionStart = 0;
            roundedTextBox1.Size = new System.Drawing.Size(435, 25);
            roundedTextBox1.TabIndex = 11;
            roundedTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            roundedTextBox1.Load += RoundedTextBox1_Load;
            roundedTextBox1.TextChanged += roundedTextBox1_TextChanged;
            // 
            // buttonPrimary2
            // 
            buttonPrimary2.BorderRadius = 8;
            buttonPrimary2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPrimary2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPrimary2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            buttonPrimary2.HoverColor = System.Drawing.Color.Empty;
            buttonPrimary2.Icon = null;
            buttonPrimary2.Location = new System.Drawing.Point(453, 50);
            buttonPrimary2.Name = "buttonPrimary2";
            buttonPrimary2.Progress = 0;
            buttonPrimary2.ProgressColor = System.Drawing.Color.FromArgb(0, 103, 205);
            buttonPrimary2.Size = new System.Drawing.Size(83, 27);
            buttonPrimary2.TabIndex = 12;
            buttonPrimary2.Text = "Browse";
            buttonPrimary2.UseVisualStyleBackColor = true;
            buttonPrimary2.UseWindowsAccentColor = true;
            buttonPrimary2.WriteProgress = true;
            buttonPrimary2.Click += buttonPrimary2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label6.Location = new System.Drawing.Point(12, 191);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(207, 19);
            label6.TabIndex = 13;
            label6.Text = "Note - AHKv1 is depectated!";
            // 
            // PluginConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(548, 344);
            Controls.Add(label6);
            Controls.Add(buttonPrimary2);
            Controls.Add(roundedTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(buttonPrimary1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Location = new System.Drawing.Point(0, 0);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PluginConfig";
            Text = "PluginConfiguration";
            Load += PluginConfig_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(buttonPrimary1, 0);
            Controls.SetChildIndex(linkLabel1, 0);
            Controls.SetChildIndex(checkBox1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(roundedTextBox1, 0);
            Controls.SetChildIndex(buttonPrimary2, 0);
            Controls.SetChildIndex(label6, 0);
            ResumeLayout(false);
            PerformLayout();
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