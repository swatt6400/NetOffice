﻿namespace NetOffice.DeveloperUtils.RegistryWatcher
{
    partial class RegistryAlarmControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistryAlarmControl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewRegistry = new System.Windows.Forms.TreeView();
            this.dataGridViewRegistry = new System.Windows.Forms.DataGridView();
            this.regName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistry)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewRegistry);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewRegistry);
            this.splitContainer1.Size = new System.Drawing.Size(476, 269);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeViewRegistry
            // 
            this.treeViewRegistry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewRegistry.CheckBoxes = true;
            this.treeViewRegistry.ContextMenuStrip = this.contextMenu;
            this.treeViewRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewRegistry.Location = new System.Drawing.Point(0, 0);
            this.treeViewRegistry.Name = "treeViewRegistry";
            this.treeViewRegistry.Size = new System.Drawing.Size(155, 269);
            this.treeViewRegistry.TabIndex = 0;
            // 
            // dataGridViewRegistry
            // 
            this.dataGridViewRegistry.AllowUserToAddRows = false;
            this.dataGridViewRegistry.AllowUserToDeleteRows = false;
            this.dataGridViewRegistry.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regName,
            this.regType,
            this.regValue});
            this.dataGridViewRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRegistry.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRegistry.Name = "dataGridViewRegistry";
            this.dataGridViewRegistry.RowHeadersVisible = false;
            this.dataGridViewRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewRegistry.Size = new System.Drawing.Size(317, 269);
            this.dataGridViewRegistry.TabIndex = 0;
            // 
            // regName
            // 
            this.regName.HeaderText = "Name";
            this.regName.Name = "regName";
            this.regName.ReadOnly = true;
            // 
            // regType
            // 
            this.regType.HeaderText = "Type";
            this.regType.Name = "regType";
            this.regType.ReadOnly = true;
            // 
            // regValue
            // 
            this.regValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.regValue.HeaderText = "Value";
            this.regValue.Name = "regValue";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo.Image")));
            this.buttonInfo.Location = new System.Drawing.Point(440, 5);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(28, 28);
            this.buttonInfo.TabIndex = 27;
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Manage office registry keys to observe. use context menu to add or remove.";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdd,
            this.toolStripRemove});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(152, 22);
            this.toolStripAdd.Text = "Add";
            this.toolStripAdd.Click += new System.EventHandler(this.toolStripAdd_Click);
            // 
            // toolStripRemove
            // 
            this.toolStripRemove.Name = "toolStripRemove";
            this.toolStripRemove.Size = new System.Drawing.Size(152, 22);
            this.toolStripRemove.Text = "Remove";
            this.toolStripRemove.Click += new System.EventHandler(this.toolStripRemove_Click);
            // 
            // RegistryAlarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RegistryAlarmControl";
            this.Size = new System.Drawing.Size(476, 311);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistry)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewRegistry;
        private System.Windows.Forms.DataGridView dataGridViewRegistry;
        private System.Windows.Forms.DataGridViewTextBoxColumn regName;
        private System.Windows.Forms.DataGridViewTextBoxColumn regType;
        private System.Windows.Forms.DataGridViewTextBoxColumn regValue;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripRemove;

    }
}
