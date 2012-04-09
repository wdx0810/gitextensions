﻿namespace FindLargeFiles
{
    partial class FindLargeFilesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindLargeFilesForm));
            this.BranchesGrid = new System.Windows.Forms.DataGridView();
            this.sHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompressedSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCommitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gitObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.pbRevisions = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.branchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BranchesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitObjectBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BranchesGrid
            // 
            this.BranchesGrid.AllowUserToAddRows = false;
            this.BranchesGrid.AllowUserToDeleteRows = false;
            this.BranchesGrid.AutoGenerateColumns = false;
            this.BranchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sHADataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.CompressedSize,
            this.commitCountDataGridViewTextBoxColumn,
            this.lastCommitDateDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1});
            this.BranchesGrid.DataSource = this.gitObjectBindingSource;
            this.BranchesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BranchesGrid.Location = new System.Drawing.Point(4, 35);
            this.BranchesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.BranchesGrid.Name = "BranchesGrid";
            this.BranchesGrid.ReadOnly = true;
            this.BranchesGrid.RowHeadersVisible = false;
            this.BranchesGrid.Size = new System.Drawing.Size(1005, 434);
            this.BranchesGrid.TabIndex = 0;
            // 
            // sHADataGridViewTextBoxColumn
            // 
            this.sHADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sHADataGridViewTextBoxColumn.DataPropertyName = "SHA";
            this.sHADataGridViewTextBoxColumn.HeaderText = "SHA";
            this.sHADataGridViewTextBoxColumn.Name = "sHADataGridViewTextBoxColumn";
            this.sHADataGridViewTextBoxColumn.ReadOnly = true;
            this.sHADataGridViewTextBoxColumn.Width = 61;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 60;
            // 
            // CompressedSize
            // 
            this.CompressedSize.DataPropertyName = "CompressedSize";
            this.CompressedSize.HeaderText = "Compressed size";
            this.CompressedSize.Name = "CompressedSize";
            this.CompressedSize.ReadOnly = true;
            // 
            // commitCountDataGridViewTextBoxColumn
            // 
            this.commitCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.commitCountDataGridViewTextBoxColumn.DataPropertyName = "CommitCount";
            this.commitCountDataGridViewTextBoxColumn.HeaderText = "Commit count";
            this.commitCountDataGridViewTextBoxColumn.Name = "commitCountDataGridViewTextBoxColumn";
            this.commitCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.commitCountDataGridViewTextBoxColumn.Width = 108;
            // 
            // lastCommitDateDataGridViewTextBoxColumn
            // 
            this.lastCommitDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastCommitDateDataGridViewTextBoxColumn.DataPropertyName = "LastCommitDate";
            this.lastCommitDateDataGridViewTextBoxColumn.HeaderText = "Last commit date";
            this.lastCommitDateDataGridViewTextBoxColumn.Name = "lastCommitDateDataGridViewTextBoxColumn";
            this.lastCommitDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastCommitDateDataGridViewTextBoxColumn.Width = 103;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Delete";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Delete";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // gitObjectBindingSource
            // 
            this.gitObjectBindingSource.DataSource = typeof(FindLargeFiles.GitObject);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BranchesGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1013, 518);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.Cancel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Delete, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbRevisions, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 477);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1005, 37);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Cancel.Location = new System.Drawing.Point(809, 4);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 29);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Close";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Delete.Location = new System.Drawing.Point(701, 4);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 29);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pbRevisions
            // 
            this.pbRevisions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRevisions.Location = new System.Drawing.Point(3, 3);
            this.pbRevisions.Name = "pbRevisions";
            this.pbRevisions.Size = new System.Drawing.Size(599, 31);
            this.pbRevisions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reset local changes before deleting files. Choose files delete. Force push for re" +
    "placing data on remote repository.";
            // 
            // branchBindingSource
            // 
            this.branchBindingSource.DataSource = typeof(FindLargeFiles.GitObject);
            // 
            // FindLargeFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(1013, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindLargeFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find large files";
            ((System.ComponentModel.ISupportInitialize)(this.BranchesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gitObjectBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.branchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BranchesGrid;
        private System.Windows.Forms.BindingSource branchBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ProgressBar pbRevisions;
        private System.Windows.Forms.DataGridViewTextBoxColumn commitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gitObjectBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompressedSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn commitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCommitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}