﻿namespace NetOffice.DeveloperToolbox
{
    partial class EnvironmentControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvironmentControl));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioButtonVB = new System.Windows.Forms.RadioButton();
            this.labelProgrammingLanguage = new System.Windows.Forms.Label();
            this.radioButtonCSharp = new System.Windows.Forms.RadioButton();
            this.labelRuntimeHeader = new System.Windows.Forms.Label();
            this.comboBoxNetRuntime = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelNetRuntime = new System.Windows.Forms.Label();
            this.labelNet4Hint = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonVS2010 = new System.Windows.Forms.RadioButton();
            this.labelEnvironment = new System.Windows.Forms.Label();
            this.radioButtonVS2008 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 17);
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // radioButtonVB
            // 
            this.radioButtonVB.AutoSize = true;
            this.radioButtonVB.Checked = true;
            this.radioButtonVB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVB.Location = new System.Drawing.Point(48, 41);
            this.radioButtonVB.Name = "radioButtonVB";
            this.radioButtonVB.Size = new System.Drawing.Size(75, 20);
            this.radioButtonVB.TabIndex = 97;
            this.radioButtonVB.TabStop = true;
            this.radioButtonVB.Text = "VB.NET";
            this.radioButtonVB.UseVisualStyleBackColor = true;
            this.radioButtonVB.CheckedChanged += new System.EventHandler(this.radioButtonLanguage_CheckedChanged);
            // 
            // labelProgrammingLanguage
            // 
            this.labelProgrammingLanguage.AutoSize = true;
            this.labelProgrammingLanguage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelProgrammingLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgrammingLanguage.Location = new System.Drawing.Point(42, 11);
            this.labelProgrammingLanguage.Name = "labelProgrammingLanguage";
            this.labelProgrammingLanguage.Size = new System.Drawing.Size(135, 16);
            this.labelProgrammingLanguage.TabIndex = 96;
            this.labelProgrammingLanguage.Text = "Programmiersprache";
            // 
            // radioButtonCSharp
            // 
            this.radioButtonCSharp.AutoSize = true;
            this.radioButtonCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCSharp.Location = new System.Drawing.Point(134, 41);
            this.radioButtonCSharp.Name = "radioButtonCSharp";
            this.radioButtonCSharp.Size = new System.Drawing.Size(42, 20);
            this.radioButtonCSharp.TabIndex = 95;
            this.radioButtonCSharp.Text = "C#";
            this.radioButtonCSharp.UseVisualStyleBackColor = true;
            this.radioButtonCSharp.CheckedChanged += new System.EventHandler(this.radioButtonLanguage_CheckedChanged);
            // 
            // labelRuntimeHeader
            // 
            this.labelRuntimeHeader.AutoSize = true;
            this.labelRuntimeHeader.BackColor = System.Drawing.SystemColors.Control;
            this.labelRuntimeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuntimeHeader.Location = new System.Drawing.Point(75, 215);
            this.labelRuntimeHeader.Name = "labelRuntimeHeader";
            this.labelRuntimeHeader.Size = new System.Drawing.Size(54, 16);
            this.labelRuntimeHeader.TabIndex = 102;
            this.labelRuntimeHeader.Text = "Version";
            // 
            // comboBoxNetRuntime
            // 
            this.comboBoxNetRuntime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNetRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNetRuntime.FormattingEnabled = true;
            this.comboBoxNetRuntime.Items.AddRange(new object[] {
            "2.0",
            "3.0",
            "3.5",
            "4.0 (Client Profile)",
            "4.0"});
            this.comboBoxNetRuntime.Location = new System.Drawing.Point(135, 209);
            this.comboBoxNetRuntime.Name = "comboBoxNetRuntime";
            this.comboBoxNetRuntime.Size = new System.Drawing.Size(104, 24);
            this.comboBoxNetRuntime.TabIndex = 101;
            this.comboBoxNetRuntime.SelectedIndexChanged += new System.EventHandler(this.comboBoxNetRuntime_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 17);
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // labelNetRuntime
            // 
            this.labelNetRuntime.AutoSize = true;
            this.labelNetRuntime.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelNetRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetRuntime.Location = new System.Drawing.Point(65, 181);
            this.labelNetRuntime.Name = "labelNetRuntime";
            this.labelNetRuntime.Size = new System.Drawing.Size(151, 16);
            this.labelNetRuntime.TabIndex = 99;
            this.labelNetRuntime.Text = ".NET Laufzeitumgebung";
            // 
            // labelNet4Hint
            // 
            this.labelNet4Hint.AutoSize = true;
            this.labelNet4Hint.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelNet4Hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNet4Hint.Location = new System.Drawing.Point(466, 35);
            this.labelNet4Hint.Name = "labelNet4Hint";
            this.labelNet4Hint.Size = new System.Drawing.Size(222, 16);
            this.labelNet4Hint.TabIndex = 103;
            this.labelNet4Hint.Text = ".NET 4.0 benötigt Visual Studio 2010";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 17);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonVS2010
            // 
            this.radioButtonVS2010.AutoSize = true;
            this.radioButtonVS2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVS2010.Location = new System.Drawing.Point(249, 33);
            this.radioButtonVS2010.Name = "radioButtonVS2010";
            this.radioButtonVS2010.Size = new System.Drawing.Size(195, 20);
            this.radioButtonVS2010.TabIndex = 106;
            this.radioButtonVS2010.Text = "Visual Studio 2010 (Express)";
            this.radioButtonVS2010.UseVisualStyleBackColor = true;
            this.radioButtonVS2010.CheckedChanged += new System.EventHandler(this.radioButtonIDE_CheckedChanged);
            // 
            // labelEnvironment
            // 
            this.labelEnvironment.AutoSize = true;
            this.labelEnvironment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvironment.Location = new System.Drawing.Point(45, 7);
            this.labelEnvironment.Name = "labelEnvironment";
            this.labelEnvironment.Size = new System.Drawing.Size(152, 16);
            this.labelEnvironment.TabIndex = 105;
            this.labelEnvironment.Text = "Entwicklungsumgebung:";
            // 
            // radioButtonVS2008
            // 
            this.radioButtonVS2008.AutoSize = true;
            this.radioButtonVS2008.Checked = true;
            this.radioButtonVS2008.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVS2008.Location = new System.Drawing.Point(48, 33);
            this.radioButtonVS2008.Name = "radioButtonVS2008";
            this.radioButtonVS2008.Size = new System.Drawing.Size(195, 20);
            this.radioButtonVS2008.TabIndex = 104;
            this.radioButtonVS2008.TabStop = true;
            this.radioButtonVS2008.Text = "Visual Studio 2008 (Express)";
            this.radioButtonVS2008.UseVisualStyleBackColor = true;
            this.radioButtonVS2008.CheckedChanged += new System.EventHandler(this.radioButtonIDE_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.radioButtonVB);
            this.panel1.Controls.Add(this.labelProgrammingLanguage);
            this.panel1.Controls.Add(this.radioButtonCSharp);
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 71);
            this.panel1.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.radioButtonVS2010);
            this.panel2.Controls.Add(this.labelEnvironment);
            this.panel2.Controls.Add(this.radioButtonVS2008);
            this.panel2.Controls.Add(this.labelNet4Hint);
            this.panel2.Location = new System.Drawing.Point(20, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 58);
            this.panel2.TabIndex = 109;
            // 
            // EnvironmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRuntimeHeader);
            this.Controls.Add(this.comboBoxNetRuntime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelNetRuntime);
            this.Name = "EnvironmentControl";
            this.Size = new System.Drawing.Size(744, 279);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButtonVB;
        private System.Windows.Forms.Label labelProgrammingLanguage;
        private System.Windows.Forms.RadioButton radioButtonCSharp;
        private System.Windows.Forms.Label labelRuntimeHeader;
        private System.Windows.Forms.ComboBox comboBoxNetRuntime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelNetRuntime;
        private System.Windows.Forms.Label labelNet4Hint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonVS2010;
        private System.Windows.Forms.Label labelEnvironment;
        private System.Windows.Forms.RadioButton radioButtonVS2008;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
