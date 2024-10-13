
namespace lab6
{
    partial class CrimesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrimesList));
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.policeDepartmentDataSet = new lab6.PoliceDepartmentDataSet();
            this.crimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crimesTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.CrimesTableAdapter();
            this.tableAdapterManager = new lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager();
            this.crimesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.crimesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.crimesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingNavigator)).BeginInit();
            this.crimesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crimesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(649, 175);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(111, 50);
            this.noButton.TabIndex = 11;
            this.noButton.Text = "Нет";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(491, 175);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(111, 50);
            this.yesButton.TabIndex = 10;
            this.yesButton.Text = "Да";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(573, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Обновить";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // policeDepartmentDataSet
            // 
            this.policeDepartmentDataSet.DataSetName = "PoliceDepartmentDataSet";
            this.policeDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccidentsTableAdapter = null;
            this.tableAdapterManager.AffectedTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrimesTableAdapter = this.crimesTableAdapter;
            this.tableAdapterManager.CriminalNamesTableAdapter = null;
            this.tableAdapterManager.CriminalsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PunishmentsTableAdapter = null;
            this.tableAdapterManager.TypesOfCrimesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crimesBindingNavigator
            // 
            this.crimesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.crimesBindingNavigator.BindingSource = this.crimesBindingSource;
            this.crimesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.crimesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.crimesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.crimesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.crimesBindingNavigatorSaveItem});
            this.crimesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.crimesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.crimesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.crimesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.crimesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.crimesBindingNavigator.Name = "crimesBindingNavigator";
            this.crimesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.crimesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.crimesBindingNavigator.TabIndex = 12;
            this.crimesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // crimesBindingNavigatorSaveItem
            // 
            this.crimesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crimesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("crimesBindingNavigatorSaveItem.Image")));
            this.crimesBindingNavigatorSaveItem.Name = "crimesBindingNavigatorSaveItem";
            this.crimesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.crimesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.crimesBindingNavigatorSaveItem.Click += new System.EventHandler(this.crimesBindingNavigatorSaveItem_Click);
            // 
            // crimesDataGridView
            // 
            this.crimesDataGridView.AutoGenerateColumns = false;
            this.crimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.crimesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.crimesDataGridView.DataSource = this.crimesBindingSource;
            this.crimesDataGridView.Location = new System.Drawing.Point(12, 32);
            this.crimesDataGridView.Name = "crimesDataGridView";
            this.crimesDataGridView.RowHeadersWidth = 51;
            this.crimesDataGridView.RowTemplate.Height = 24;
            this.crimesDataGridView.Size = new System.Drawing.Size(454, 220);
            this.crimesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "crimeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "crimeId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nameOfCrime";
            this.dataGridViewTextBoxColumn2.HeaderText = "nameOfCrime";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "punishmentId";
            this.dataGridViewTextBoxColumn3.HeaderText = "punishmentId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // CrimesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crimesDataGridView);
            this.Controls.Add(this.crimesBindingNavigator);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.Name = "CrimesList";
            this.Text = "CrimesList";
            this.Load += new System.EventHandler(this.CrimesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingNavigator)).EndInit();
            this.crimesBindingNavigator.ResumeLayout(false);
            this.crimesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crimesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label label1;
        private PoliceDepartmentDataSet policeDepartmentDataSet;
        private System.Windows.Forms.BindingSource crimesBindingSource;
        private PoliceDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator crimesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton crimesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView crimesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public PoliceDepartmentDataSetTableAdapters.CrimesTableAdapter crimesTableAdapter;
    }
}