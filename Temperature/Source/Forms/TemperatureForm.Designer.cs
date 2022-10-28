using AltUI.Forms;
using AltUI.Win32;
using AltUI.Controls;

namespace Temperature
{
    partial class TemperatureForm
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
            this.components = new System.ComponentModel.Container();
            this.fromText = new AltUI.Controls.DarkTextBox();
            this.fromUnit = new AltUI.Controls.DarkComboBox();
            this.toUnit = new AltUI.Controls.DarkComboBox();
            this.result = new AltUI.Controls.DarkTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromText
            // 
            this.fromText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.fromText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.fromText.Location = new System.Drawing.Point(12, 20);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(135, 25);
            this.fromText.TabIndex = 0;
            this.fromText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromText_KeyPress);
            // 
            // fromUnit
            // 
            this.fromUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.fromUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromUnit.FormattingEnabled = true;
            this.fromUnit.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
            this.fromUnit.Location = new System.Drawing.Point(12, 49);
            this.fromUnit.Name = "fromUnit";
            this.fromUnit.Size = new System.Drawing.Size(135, 26);
            this.fromUnit.TabIndex = 1;
            // 
            // toUnit
            // 
            this.toUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.toUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toUnit.FormattingEnabled = true;
            this.toUnit.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin",
            "Rankine"});
            this.toUnit.Location = new System.Drawing.Point(193, 49);
            this.toUnit.Name = "toUnit";
            this.toUnit.Size = new System.Drawing.Size(135, 26);
            this.toUnit.TabIndex = 4;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.result.Location = new System.Drawing.Point(193, 20);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(135, 25);
            this.result.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 66);
            this.label2.TabIndex = 7;
            this.label2.Text = "TO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TemperatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 86);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.toUnit);
            this.Controls.Add(this.fromUnit);
            this.Controls.Add(this.fromText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemperatureForm";
            this.ShowIcon = false;
            this.Text = "Temperature Conversion";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.Load += new System.EventHandler(this.TemperatureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DarkTextBox fromText;
        private DarkComboBox fromUnit;
        private DarkComboBox toUnit;
        private DarkTextBox result;
        private Label label2;
    }
}