namespace LocationManagementSystem
{
    partial class UpdateSectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSections = new System.Windows.Forms.DataGridView();
            this.sectionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman MT Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sections";
            // 
            // dgvSections
            // 
            this.dgvSections.AutoGenerateColumns = false;
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectionIdDataGridViewTextBoxColumn,
            this.sectionNameDataGridViewTextBoxColumn});
            this.dgvSections.DataSource = this.sectionInfoBindingSource;
            this.dgvSections.Location = new System.Drawing.Point(16, 57);
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.Size = new System.Drawing.Size(334, 319);
            this.dgvSections.TabIndex = 4;
            this.dgvSections.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dgvSections.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDepartments_DataBindingComplete);
            this.dgvSections.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // sectionInfoBindingSource
            // 
            this.sectionInfoBindingSource.DataSource = typeof(LocationManagementSystem.SectionInfo);
            // 
            // sectionIdDataGridViewTextBoxColumn
            // 
            this.sectionIdDataGridViewTextBoxColumn.DataPropertyName = "SectionId";
            this.sectionIdDataGridViewTextBoxColumn.HeaderText = "SectionId";
            this.sectionIdDataGridViewTextBoxColumn.Name = "sectionIdDataGridViewTextBoxColumn";
            this.sectionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionNameDataGridViewTextBoxColumn
            // 
            this.sectionNameDataGridViewTextBoxColumn.DataPropertyName = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.HeaderText = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.Name = "sectionNameDataGridViewTextBoxColumn";
            this.sectionNameDataGridViewTextBoxColumn.Width = 290;
            // 
            // UpdateSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 388);
            this.Controls.Add(this.dgvSections);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSectionForm";
            this.Text = "UpdateDepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSections;
        private System.Windows.Forms.BindingSource sectionInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameDataGridViewTextBoxColumn;
    }
}