
namespace Knaifl.MsFsRemote.Windows
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UIHdgSetButton = new System.Windows.Forms.Button();
            this.UIHeadingValue = new System.Windows.Forms.TextBox();
            this.UICourse1Value = new System.Windows.Forms.TextBox();
            this.UICourse1SetButton = new System.Windows.Forms.Button();
            this.UICourse2SetButton = new System.Windows.Forms.Button();
            this.UICourse2Value = new System.Windows.Forms.TextBox();
            this.UIAutopilotEnabledButton = new System.Windows.Forms.CheckBox();
            this.UINavEnabledButton = new System.Windows.Forms.CheckBox();
            this.UIHdgEnabledButton = new System.Windows.Forms.CheckBox();
            this.UIFlcEnabledButton = new System.Windows.Forms.CheckBox();
            this.UIAltEnabledButton = new System.Windows.Forms.CheckBox();
            this.UIYdEnabledButton = new System.Windows.Forms.CheckBox();
            this.UIAltValue = new System.Windows.Forms.TextBox();
            this.UIAltSetButton = new System.Windows.Forms.Button();
            this.UISpeedSetButton = new System.Windows.Forms.Button();
            this.UISpeedValue = new System.Windows.Forms.TextBox();
            this.UINav1SetButton = new System.Windows.Forms.Button();
            this.UINav1Value = new System.Windows.Forms.TextBox();
            this.UINav2Value = new System.Windows.Forms.TextBox();
            this.UINav2SetButton = new System.Windows.Forms.Button();
            this.UINdb1Value = new System.Windows.Forms.TextBox();
            this.UINdb1SetButton = new System.Windows.Forms.Button();
            this.UIAppEnabledMode = new System.Windows.Forms.CheckBox();
            this.UINdb2Value = new System.Windows.Forms.TextBox();
            this.UINdb2SetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UIHdgSetButton
            // 
            this.UIHdgSetButton.Location = new System.Drawing.Point(315, 72);
            this.UIHdgSetButton.Name = "UIHdgSetButton";
            this.UIHdgSetButton.Size = new System.Drawing.Size(47, 23);
            this.UIHdgSetButton.TabIndex = 1;
            this.UIHdgSetButton.Text = "HDG";
            this.UIHdgSetButton.UseVisualStyleBackColor = true;
            this.UIHdgSetButton.Click += new System.EventHandler(this.UIHdgSetButton_Click);
            // 
            // UIHeadingValue
            // 
            this.UIHeadingValue.Location = new System.Drawing.Point(270, 72);
            this.UIHeadingValue.Name = "UIHeadingValue";
            this.UIHeadingValue.Size = new System.Drawing.Size(39, 23);
            this.UIHeadingValue.TabIndex = 2;
            // 
            // UICourse1Value
            // 
            this.UICourse1Value.Location = new System.Drawing.Point(172, 71);
            this.UICourse1Value.Name = "UICourse1Value";
            this.UICourse1Value.Size = new System.Drawing.Size(39, 23);
            this.UICourse1Value.TabIndex = 3;
            // 
            // UICourse1SetButton
            // 
            this.UICourse1SetButton.Location = new System.Drawing.Point(217, 71);
            this.UICourse1SetButton.Name = "UICourse1SetButton";
            this.UICourse1SetButton.Size = new System.Drawing.Size(47, 23);
            this.UICourse1SetButton.TabIndex = 4;
            this.UICourse1SetButton.Text = "CRS 1";
            this.UICourse1SetButton.UseVisualStyleBackColor = true;
            this.UICourse1SetButton.Click += new System.EventHandler(this.UICourse1SetButton_Click);
            // 
            // UICourse2SetButton
            // 
            this.UICourse2SetButton.Location = new System.Drawing.Point(217, 100);
            this.UICourse2SetButton.Name = "UICourse2SetButton";
            this.UICourse2SetButton.Size = new System.Drawing.Size(47, 23);
            this.UICourse2SetButton.TabIndex = 6;
            this.UICourse2SetButton.Text = "CRS 2";
            this.UICourse2SetButton.UseVisualStyleBackColor = true;
            this.UICourse2SetButton.Click += new System.EventHandler(this.UICourse2SetButton_Click);
            // 
            // UICourse2Value
            // 
            this.UICourse2Value.Location = new System.Drawing.Point(172, 100);
            this.UICourse2Value.Name = "UICourse2Value";
            this.UICourse2Value.Size = new System.Drawing.Size(39, 23);
            this.UICourse2Value.TabIndex = 5;
            // 
            // UIAutopilotEnabledButton
            // 
            this.UIAutopilotEnabledButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.UIAutopilotEnabledButton.Location = new System.Drawing.Point(12, 41);
            this.UIAutopilotEnabledButton.Name = "UIAutopilotEnabledButton";
            this.UIAutopilotEnabledButton.Size = new System.Drawing.Size(54, 25);
            this.UIAutopilotEnabledButton.TabIndex = 7;
            this.UIAutopilotEnabledButton.Text = "AP";
            this.UIAutopilotEnabledButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UIAutopilotEnabledButton.UseVisualStyleBackColor = true;
            this.UIAutopilotEnabledButton.CheckedChanged += new System.EventHandler(this.UIAutopilotEnabledButton_CheckedChanged);
            // 
            // UINavEnabledButton
            // 
            this.UINavEnabledButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.UINavEnabledButton.Location = new System.Drawing.Point(172, 41);
            this.UINavEnabledButton.Name = "UINavEnabledButton";
            this.UINavEnabledButton.Size = new System.Drawing.Size(92, 25);
            this.UINavEnabledButton.TabIndex = 11;
            this.UINavEnabledButton.Text = "NAV";
            this.UINavEnabledButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UINavEnabledButton.UseVisualStyleBackColor = true;
            this.UINavEnabledButton.CheckedChanged += new System.EventHandler(this.UINavEnabledButton_CheckedChanged);
            // 
            // UIHdgEnabledButton
            // 
            this.UIHdgEnabledButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.UIHdgEnabledButton.Location = new System.Drawing.Point(270, 41);
            this.UIHdgEnabledButton.Name = "UIHdgEnabledButton";
            this.UIHdgEnabledButton.Size = new System.Drawing.Size(92, 25);
            this.UIHdgEnabledButton.TabIndex = 12;
            this.UIHdgEnabledButton.Text = "HDG";
            this.UIHdgEnabledButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UIHdgEnabledButton.UseVisualStyleBackColor = true;
            this.UIHdgEnabledButton.CheckedChanged += new System.EventHandler(this.UIHdgEnabledButton_CheckedChanged);
            // 
            // UIFlcEnabledButton
            // 
            this.UIFlcEnabledButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.UIFlcEnabledButton.Location = new System.Drawing.Point(466, 41);
            this.UIFlcEnabledButton.Name = "UIFlcEnabledButton";
            this.UIFlcEnabledButton.Size = new System.Drawing.Size(92, 25);
            this.UIFlcEnabledButton.TabIndex = 13;
            this.UIFlcEnabledButton.Text = "FLC";
            this.UIFlcEnabledButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UIFlcEnabledButton.UseVisualStyleBackColor = true;
            this.UIFlcEnabledButton.CheckedChanged += new System.EventHandler(this.UIFlcEnabledButton_CheckedChanged);
            // 
            // UIAltEnabledButton
            // 
            this.UIAltEnabledButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.UIAltEnabledButton.Location = new System.Drawing.Point(564, 41);
            this.UIAltEnabledButton.Name = "UIAltEnabledButton";
            this.UIAltEnabledButton.Size = new System.Drawing.Size(92, 25);
            this.UIAltEnabledButton.TabIndex = 14;
            this.UIAltEnabledButton.Text = "ALT";
            this.UIAltEnabledButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UIAltEnabledButton.UseVisualStyleBackColor = true;
            this.UIAltEnabledButton.CheckedChanged += new System.EventHandler(this.UIAltEnabledButton_CheckedChanged);
            // 
            // UIYdEnabledButton
            // 
            this.UIYdEnabledButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.UIYdEnabledButton.Location = new System.Drawing.Point(662, 41);
            this.UIYdEnabledButton.Name = "UIYdEnabledButton";
            this.UIYdEnabledButton.Size = new System.Drawing.Size(92, 25);
            this.UIYdEnabledButton.TabIndex = 15;
            this.UIYdEnabledButton.Text = "YD";
            this.UIYdEnabledButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UIYdEnabledButton.UseVisualStyleBackColor = true;
            this.UIYdEnabledButton.CheckedChanged += new System.EventHandler(this.UIYdEnabledButton_CheckedChanged);
            // 
            // UIAltValue
            // 
            this.UIAltValue.Location = new System.Drawing.Point(529, 72);
            this.UIAltValue.Name = "UIAltValue";
            this.UIAltValue.Size = new System.Drawing.Size(74, 23);
            this.UIAltValue.TabIndex = 17;
            // 
            // UIAltSetButton
            // 
            this.UIAltSetButton.Location = new System.Drawing.Point(609, 72);
            this.UIAltSetButton.Name = "UIAltSetButton";
            this.UIAltSetButton.Size = new System.Drawing.Size(47, 23);
            this.UIAltSetButton.TabIndex = 16;
            this.UIAltSetButton.Text = "ALT";
            this.UIAltSetButton.UseVisualStyleBackColor = true;
            this.UIAltSetButton.Click += new System.EventHandler(this.UIAltSetButton_Click);
            // 
            // UISpeedSetButton
            // 
            this.UISpeedSetButton.Location = new System.Drawing.Point(116, 71);
            this.UISpeedSetButton.Name = "UISpeedSetButton";
            this.UISpeedSetButton.Size = new System.Drawing.Size(47, 23);
            this.UISpeedSetButton.TabIndex = 21;
            this.UISpeedSetButton.Text = "SPD";
            this.UISpeedSetButton.UseVisualStyleBackColor = true;
            this.UISpeedSetButton.Click += new System.EventHandler(this.UISpeedSetButton_Click);
            // 
            // UISpeedValue
            // 
            this.UISpeedValue.Location = new System.Drawing.Point(71, 71);
            this.UISpeedValue.Name = "UISpeedValue";
            this.UISpeedValue.Size = new System.Drawing.Size(39, 23);
            this.UISpeedValue.TabIndex = 20;
            // 
            // UINav1SetButton
            // 
            this.UINav1SetButton.Location = new System.Drawing.Point(700, 106);
            this.UINav1SetButton.Name = "UINav1SetButton";
            this.UINav1SetButton.Size = new System.Drawing.Size(54, 23);
            this.UINav1SetButton.TabIndex = 23;
            this.UINav1SetButton.Text = "NAV1";
            this.UINav1SetButton.UseVisualStyleBackColor = true;
            this.UINav1SetButton.Click += new System.EventHandler(this.UINav1SetButton_Click);
            // 
            // UINav1Value
            // 
            this.UINav1Value.Location = new System.Drawing.Point(627, 107);
            this.UINav1Value.Name = "UINav1Value";
            this.UINav1Value.Size = new System.Drawing.Size(67, 23);
            this.UINav1Value.TabIndex = 24;
            // 
            // UINav2Value
            // 
            this.UINav2Value.Location = new System.Drawing.Point(627, 136);
            this.UINav2Value.Name = "UINav2Value";
            this.UINav2Value.Size = new System.Drawing.Size(67, 23);
            this.UINav2Value.TabIndex = 28;
            // 
            // UINav2SetButton
            // 
            this.UINav2SetButton.Location = new System.Drawing.Point(700, 136);
            this.UINav2SetButton.Name = "UINav2SetButton";
            this.UINav2SetButton.Size = new System.Drawing.Size(54, 23);
            this.UINav2SetButton.TabIndex = 27;
            this.UINav2SetButton.Text = "NAV2";
            this.UINav2SetButton.UseVisualStyleBackColor = true;
            this.UINav2SetButton.Click += new System.EventHandler(this.UINav2SetButton_Click);
            // 
            // UINdb1Value
            // 
            this.UINdb1Value.Location = new System.Drawing.Point(627, 166);
            this.UINdb1Value.Name = "UINdb1Value";
            this.UINdb1Value.Size = new System.Drawing.Size(67, 23);
            this.UINdb1Value.TabIndex = 39;
            // 
            // UINdb1SetButton
            // 
            this.UINdb1SetButton.Location = new System.Drawing.Point(700, 165);
            this.UINdb1SetButton.Name = "UINdb1SetButton";
            this.UINdb1SetButton.Size = new System.Drawing.Size(54, 23);
            this.UINdb1SetButton.TabIndex = 38;
            this.UINdb1SetButton.Text = "NDB 1";
            this.UINdb1SetButton.UseVisualStyleBackColor = true;
            this.UINdb1SetButton.Click += new System.EventHandler(this.UINdb1SetButton_Click);
            // 
            // UIAppEnabledMode
            // 
            this.UIAppEnabledMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.UIAppEnabledMode.Location = new System.Drawing.Point(368, 41);
            this.UIAppEnabledMode.Name = "UIAppEnabledMode";
            this.UIAppEnabledMode.Size = new System.Drawing.Size(92, 25);
            this.UIAppEnabledMode.TabIndex = 40;
            this.UIAppEnabledMode.Text = "APP";
            this.UIAppEnabledMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UIAppEnabledMode.UseVisualStyleBackColor = true;
            this.UIAppEnabledMode.CheckedChanged += new System.EventHandler(this.UIAppEnabledMode_CheckedChanged);
            // 
            // UINdb2Value
            // 
            this.UINdb2Value.Location = new System.Drawing.Point(627, 195);
            this.UINdb2Value.Name = "UINdb2Value";
            this.UINdb2Value.Size = new System.Drawing.Size(67, 23);
            this.UINdb2Value.TabIndex = 42;
            // 
            // UINdb2SetButton
            // 
            this.UINdb2SetButton.Location = new System.Drawing.Point(700, 194);
            this.UINdb2SetButton.Name = "UINdb2SetButton";
            this.UINdb2SetButton.Size = new System.Drawing.Size(54, 23);
            this.UINdb2SetButton.TabIndex = 41;
            this.UINdb2SetButton.Text = "NDB 2";
            this.UINdb2SetButton.UseVisualStyleBackColor = true;
            this.UINdb2SetButton.Click += new System.EventHandler(this.UINdb2SetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 270);
            this.Controls.Add(this.UINdb2Value);
            this.Controls.Add(this.UINdb2SetButton);
            this.Controls.Add(this.UIAppEnabledMode);
            this.Controls.Add(this.UINdb1Value);
            this.Controls.Add(this.UINdb1SetButton);
            this.Controls.Add(this.UINav2Value);
            this.Controls.Add(this.UINav2SetButton);
            this.Controls.Add(this.UINav1Value);
            this.Controls.Add(this.UINav1SetButton);
            this.Controls.Add(this.UISpeedSetButton);
            this.Controls.Add(this.UISpeedValue);
            this.Controls.Add(this.UIAltValue);
            this.Controls.Add(this.UIAltSetButton);
            this.Controls.Add(this.UIYdEnabledButton);
            this.Controls.Add(this.UIAltEnabledButton);
            this.Controls.Add(this.UIFlcEnabledButton);
            this.Controls.Add(this.UIHdgEnabledButton);
            this.Controls.Add(this.UINavEnabledButton);
            this.Controls.Add(this.UIAutopilotEnabledButton);
            this.Controls.Add(this.UICourse2SetButton);
            this.Controls.Add(this.UICourse2Value);
            this.Controls.Add(this.UICourse1SetButton);
            this.Controls.Add(this.UICourse1Value);
            this.Controls.Add(this.UIHeadingValue);
            this.Controls.Add(this.UIHdgSetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MSFS Remote";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UIHdgSetButton;
        private System.Windows.Forms.TextBox UIHeadingValue;
        private System.Windows.Forms.TextBox UICourse1Value;
        private System.Windows.Forms.Button UICourse1SetButton;
        private System.Windows.Forms.Button UICourse2SetButton;
        private System.Windows.Forms.TextBox UICourse2Value;
        private System.Windows.Forms.CheckBox UIAutopilotEnabledButton;
        private System.Windows.Forms.CheckBox UINavEnabledButton;
        private System.Windows.Forms.CheckBox UIHdgEnabledButton;
        private System.Windows.Forms.CheckBox UIFlcEnabledButton;
        private System.Windows.Forms.CheckBox UIAltEnabledButton;
        private System.Windows.Forms.CheckBox UIYdEnabledButton;
        private System.Windows.Forms.TextBox UIAltValue;
        private System.Windows.Forms.Button UIAltSetButton;
        private System.Windows.Forms.Button UISpeedSetButton;
        private System.Windows.Forms.TextBox UISpeedValue;
        private System.Windows.Forms.Button UINav1SetButton;
        private System.Windows.Forms.TextBox UINav1Value;
        private System.Windows.Forms.TextBox UINav2Value;
        private System.Windows.Forms.Button UINav2SetButton;
        private System.Windows.Forms.TextBox UINdb1Value;
        private System.Windows.Forms.Button UINdb1SetButton;
        private System.Windows.Forms.CheckBox UIAppEnabledMode;
        private System.Windows.Forms.TextBox UINdb2Value;
        private System.Windows.Forms.Button UINdb2SetButton;
    }
}

