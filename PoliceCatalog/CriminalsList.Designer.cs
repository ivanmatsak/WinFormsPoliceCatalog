
namespace lab6
{
    partial class CriminalsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriminalsList));
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.policeDepartmentDataSet = new lab6.PoliceDepartmentDataSet();
            this.criminalNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criminalNamesTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.CriminalNamesTableAdapter();
            this.tableAdapterManager = new lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager();
            this.criminalNamesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.criminalNamesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.criminalNamesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalNamesBindingNavigator)).BeginInit();
            this.criminalNamesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalNamesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(667, 123);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(111, 50);
            this.noButton.TabIndex = 14;
            this.noButton.Text = "Нет";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(509, 123);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(111, 50);
            this.yesButton.TabIndex = 13;
            this.yesButton.Text = "Да";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(591, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Обновить";
            // 
            // policeDepartmentDataSet
            // 
            this.policeDepartmentDataSet.DataSetName = "PoliceDepartmentDataSet";
            this.policeDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // criminalNamesBindingSource
            // 
            this.criminalNamesBindingSource.DataMember = "CriminalNames";
            this.criminalNamesBindingSource.DataSource = this.policeDepartmentDataSet;
            // 
            // criminalNamesTableAdapter
            // 
            this.criminalNamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccidentsTableAdapter = null;
            this.tableAdapterManager.AffectedTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrimesTableAdapter = null;
            this.tableAdapterManager.CriminalNamesTableAdapter = this.criminalNamesTableAdapter;
            this.tableAdapterManager.CriminalsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PunishmentsTableAdapter = null;
            this.tableAdapterManager.TypesOfCrimesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // criminalNamesBindingNavigator
            // 
            this.criminalNamesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.criminalNamesBindingNavigator.BindingSource = this.criminalNamesBindingSource;
            this.criminalNamesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.criminalNamesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.criminalNamesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.criminalNamesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.criminalNamesBindingNavigatorSaveItem});
            this.criminalNamesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.criminalNamesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.criminalNamesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.criminalNamesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.criminalNamesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.criminalNamesBindingNavigator.Name = "criminalNamesBindingNavigator";
            this.criminalNamesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.criminalNamesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.criminalNamesBindingNavigator.TabIndex = 15;
            this.criminalNamesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // criminalNamesBindingNavigatorSaveItem
            // 
            this.criminalNamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.criminalNamesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("criminalNamesBindingNavigatorSaveItem.Image")));
            this.criminalNamesBindingNavigatorSaveItem.Name = "criminalNamesBindingNavigatorSaveItem";
            this.criminalNamesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.criminalNamesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.criminalNamesBindingNavigatorSaveItem.Click += new System.EventHandler(this.criminalNamesBindingNavigatorSaveItem_Click);
            // 
            // criminalNamesDataGridView
            // 
            this.criminalNamesDataGridView.AutoGenerateColumns = false;
            this.criminalNamesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminalNamesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.criminalNamesDataGridView.DataSource = this.criminalNamesBindingSource;
            this.criminalNamesDataGridView.Location = new System.Drawing.Point(12, 32);
            this.criminalNamesDataGridView.Name = "criminalNamesDataGridView";
            this.criminalNamesDataGridView.RowHeadersWidth = 51;
            this.criminalNamesDataGridView.RowTemplate.Height = 24;
            this.criminalNamesDataGridView.Size = new System.Drawing.Size(480, 220);
            this.criminalNamesDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CriminalNamesId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CriminalNamesId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // CriminalsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.criminalNamesDataGridView);
            this.Controls.Add(this.criminalNamesBindingNavigator);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.Name = "CriminalsList";
            this.Text = "CriminalsList";
            this.Load += new System.EventHandler(this.CriminalsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalNamesBindingNavigator)).EndInit();
            this.criminalNamesBindingNavigator.ResumeLayout(false);
            this.criminalNamesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.criminalNamesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label label1;
        private PoliceDepartmentDataSet policeDepartmentDataSet;
        private System.Windows.Forms.BindingSource criminalNamesBindingSource;
        private PoliceDepartmentDataSetTableAdapters.CriminalNamesTableAdapter criminalNamesTableAdapter;
        private PoliceDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator criminalNamesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton criminalNamesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView criminalNamesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}