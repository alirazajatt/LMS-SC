namespace LocationManagementSystem
{
    partial class UpdateDesignationForm
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
            this.dgvDesignation = new System.Windows.Forms.DataGridView();
            this.designationInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman MT Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Designations";
            // 
            // dgvDesignation
            // 
            this.dgvDesignation.AutoGenerateColumns = false;
            this.dgvDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesignation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.designationIdDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgvDesignation.DataSource = this.designationInfoBindingSource;
            this.dgvDesignation.Location = new System.Drawing.Point(16, 57);
            this.dgvDesignation.Name = "dgvDesignation";
            this.dgvDesignation.Size = new System.Drawing.Size(334, 319);
            this.dgvDesignation.TabIndex = 4;
            this.dgvDesignation.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dgvDesignation.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDepartments_DataBindingComplete);
            this.dgvDesignation.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // designationInfoBindingSource
            // 
            this.designationInfoBindingSource.DataSource = typeof(LocationManagementSystem.DesignationInfo);
            // 
            // designationIdDataGridViewTextBoxColumn
            // 
            this.designationIdDataGridViewTextBoxColumn.DataPropertyName = "DesignationId";
            this.designationIdDataGridViewTextBoxColumn.HeaderText = "DesignationId";
            this.designationIdDataGridViewTextBoxColumn.Name = "designationIdDataGridViewTextBoxColumn";
            this.designationIdDataGridViewTextBoxColumn.Visible = false;
            this.designationIdDataGridViewTextBoxColumn.Width = 290;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.Width = 290;
            // 
            // UpdateDesignationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 388);
            this.Controls.Add(this.dgvDesignation);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDesignationForm";
            this.Text = "UpdateDepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource designationInfoBindingSource;
    }
}