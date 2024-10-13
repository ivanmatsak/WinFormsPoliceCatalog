
namespace lab6
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.accidentsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeDepartmentDataSet = new lab6.PoliceDepartmentDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.accidentsViewTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.AccidentsViewTableAdapter();
            this.tableAdapterManager = new lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager();
            this.crimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crimesTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.CrimesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accidentsViewBindingSource
            // 
            this.accidentsViewBindingSource.DataMember = "AccidentsView";
            this.accidentsViewBindingSource.DataSource = this.policeDepartmentDataSet;
            // 
            // policeDepartmentDataSet
            // 
            this.policeDepartmentDataSet.DataSetName = "PoliceDepartmentDataSet";
            this.policeDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AccidentsView";
            reportDataSource1.Value = this.accidentsViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab6.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(379, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(597, 426);
            this.reportViewer1.TabIndex = 2;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(5, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(189, 67);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 172);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Интервал:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Location = new System.Drawing.Point(88, 73);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // accidentsViewTableAdapter
            // 
            this.accidentsViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccidentsTableAdapter = null;
            this.tableAdapterManager.AffectedTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CrimesTableAdapter = null;
            this.tableAdapterManager.CriminalNamesTableAdapter = null;
            this.tableAdapterManager.CriminalsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PunishmentsTableAdapter = null;
            this.tableAdapterManager.TypesOfCrimesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crimesBindingSource
            // 
            this.crimesBindingSource.DataMember = "Crimes";
            this.crimesBindingSource.DataSource = this.policeDepartmentDataSet;
            // 
            // crimesTableAdapter
            // 
            this.crimesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Тип преступления:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 223);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Показать все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accidentsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PoliceDepartmentDataSet policeDepartmentDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource accidentsViewBindingSource;
        private PoliceDepartmentDataSetTableAdapters.AccidentsViewTableAdapter accidentsViewTableAdapter;
        private PoliceDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource crimesBindingSource;
        private PoliceDepartmentDataSetTableAdapters.CrimesTableAdapter crimesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}