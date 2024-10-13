
namespace lab6
{
    partial class RelatedTablescs
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
            this.backButton = new System.Windows.Forms.Button();
            this.cbCriminalId = new System.Windows.Forms.ComboBox();
            this.criminalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeDepartmentDataSet = new lab6.PoliceDepartmentDataSet();
            this.policeDepartmentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criminalsTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.CriminalsTableAdapter();
            this.accidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accidentsTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.AccidentsTableAdapter();
            this.tableAdapterManager = new lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager();
            this.accidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affectedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.affectedTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.AffectedTableAdapter();
            this.affectedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(189, 67);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cbCriminalId
            // 
            this.cbCriminalId.DataSource = this.criminalsBindingSource;
            this.cbCriminalId.DisplayMember = "Surname";
            this.cbCriminalId.FormattingEnabled = true;
            this.cbCriminalId.Location = new System.Drawing.Point(12, 12);
            this.cbCriminalId.Name = "cbCriminalId";
            this.cbCriminalId.Size = new System.Drawing.Size(189, 24);
            this.cbCriminalId.TabIndex = 5;
            this.cbCriminalId.ValueMember = "CriminalId";
            // 
            // criminalsBindingSource
            // 
            this.criminalsBindingSource.DataMember = "Criminals";
            this.criminalsBindingSource.DataSource = this.policeDepartmentDataSet;
            // 
            // policeDepartmentDataSet
            // 
            this.policeDepartmentDataSet.DataSetName = "PoliceDepartmentDataSet";
            this.policeDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policeDepartmentDataSetBindingSource
            // 
            this.policeDepartmentDataSetBindingSource.DataSource = this.policeDepartmentDataSet;
            this.policeDepartmentDataSetBindingSource.Position = 0;
            // 
            // criminalsTableAdapter
            // 
            this.criminalsTableAdapter.ClearBeforeFill = true;
            // 
            // accidentsBindingSource
            // 
            this.accidentsBindingSource.DataMember = "FK__Accidents__Crimi__3E52440B";
            this.accidentsBindingSource.DataSource = this.criminalsBindingSource;
            // 
            // accidentsTableAdapter
            // 
            this.accidentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccidentsTableAdapter = this.accidentsTableAdapter;
            this.tableAdapterManager.AffectedTableAdapter = this.affectedTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CriminalsTableAdapter = this.criminalsTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.TypesOfCrimesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accidentsDataGridView
            // 
            this.accidentsDataGridView.AutoGenerateColumns = false;
            this.accidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accidentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.accidentsDataGridView.DataSource = this.accidentsBindingSource;
            this.accidentsDataGridView.Location = new System.Drawing.Point(12, 62);
            this.accidentsDataGridView.Name = "accidentsDataGridView";
            this.accidentsDataGridView.RowHeadersWidth = 51;
            this.accidentsDataGridView.RowTemplate.Height = 24;
            this.accidentsDataGridView.Size = new System.Drawing.Size(776, 288);
            this.accidentsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccidentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AccidentId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TypeOfCrimeId";
            this.dataGridViewTextBoxColumn2.HeaderText = "TypeOfCrimeId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CriminalId";
            this.dataGridViewTextBoxColumn3.HeaderText = "CriminalId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AffectedId";
            this.dataGridViewTextBoxColumn4.HeaderText = "AffectedId";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn5.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateOfCrime";
            this.dataGridViewTextBoxColumn6.HeaderText = "DateOfCrime";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TimeOfCrime";
            this.dataGridViewTextBoxColumn7.HeaderText = "TimeOfCrime";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // affectedBindingSource
            // 
            this.affectedBindingSource.DataMember = "Affected";
            this.affectedBindingSource.DataSource = this.policeDepartmentDataSetBindingSource;
            // 
            // affectedTableAdapter
            // 
            this.affectedTableAdapter.ClearBeforeFill = true;
            // 
            // affectedBindingSource1
            // 
            this.affectedBindingSource1.DataMember = "Affected";
            this.affectedBindingSource1.DataSource = this.policeDepartmentDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Связь с преступниками";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.policeDepartmentDataSetBindingSource;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // RelatedTablescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accidentsDataGridView);
            this.Controls.Add(this.cbCriminalId);
            this.Controls.Add(this.backButton);
            this.Name = "RelatedTablescs";
            this.Text = "RelatedTablescs";
            this.Load += new System.EventHandler(this.RelatedTablescs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.criminalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox cbCriminalId;
        private System.Windows.Forms.BindingSource policeDepartmentDataSetBindingSource;
        private PoliceDepartmentDataSet policeDepartmentDataSet;
        private System.Windows.Forms.BindingSource criminalsBindingSource;
        private PoliceDepartmentDataSetTableAdapters.CriminalsTableAdapter criminalsTableAdapter;
        private System.Windows.Forms.BindingSource accidentsBindingSource;
        private PoliceDepartmentDataSetTableAdapters.AccidentsTableAdapter accidentsTableAdapter;
        private PoliceDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView accidentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private PoliceDepartmentDataSetTableAdapters.AffectedTableAdapter affectedTableAdapter;
        private System.Windows.Forms.BindingSource affectedBindingSource;
        private PoliceDepartmentDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource affectedBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
    }
}