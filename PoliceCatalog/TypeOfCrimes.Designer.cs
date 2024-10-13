
namespace lab6
{
    partial class TypeOfCrimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeOfCrimes));
            this.typesOfCrimesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.typesOfCrimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeDepartmentDataSet = new lab6.PoliceDepartmentDataSet();
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
            this.typesOfCrimesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.typesOfCrimesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.punishmentsListButton = new System.Windows.Forms.Button();
            this.crimesListButton = new System.Windows.Forms.Button();
            this.cbCrime = new System.Windows.Forms.ComboBox();
            this.cbPunishment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.crimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesOfCrimesTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.TypesOfCrimesTableAdapter();
            this.tableAdapterManager = new lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager();
            this.crimesTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.CrimesTableAdapter();
            this.punishmentsTableAdapter = new lab6.PoliceDepartmentDataSetTableAdapters.PunishmentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfCrimesBindingNavigator)).BeginInit();
            this.typesOfCrimesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfCrimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfCrimesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typesOfCrimesBindingNavigator
            // 
            this.typesOfCrimesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.typesOfCrimesBindingNavigator.BindingSource = this.typesOfCrimesBindingSource;
            this.typesOfCrimesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.typesOfCrimesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.typesOfCrimesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.typesOfCrimesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.typesOfCrimesBindingNavigatorSaveItem});
            this.typesOfCrimesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.typesOfCrimesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.typesOfCrimesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.typesOfCrimesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.typesOfCrimesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.typesOfCrimesBindingNavigator.Name = "typesOfCrimesBindingNavigator";
            this.typesOfCrimesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.typesOfCrimesBindingNavigator.Size = new System.Drawing.Size(1076, 27);
            this.typesOfCrimesBindingNavigator.TabIndex = 0;
            this.typesOfCrimesBindingNavigator.Text = "bindingNavigator1";
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
            // typesOfCrimesBindingSource
            // 
            this.typesOfCrimesBindingSource.DataMember = "TypesOfCrimes";
            this.typesOfCrimesBindingSource.DataSource = this.policeDepartmentDataSet;
            // 
            // policeDepartmentDataSet
            // 
            this.policeDepartmentDataSet.DataSetName = "PoliceDepartmentDataSet";
            this.policeDepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // typesOfCrimesBindingNavigatorSaveItem
            // 
            this.typesOfCrimesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.typesOfCrimesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("typesOfCrimesBindingNavigatorSaveItem.Image")));
            this.typesOfCrimesBindingNavigatorSaveItem.Name = "typesOfCrimesBindingNavigatorSaveItem";
            this.typesOfCrimesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.typesOfCrimesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.typesOfCrimesBindingNavigatorSaveItem.Click += new System.EventHandler(this.typesOfCrimesBindingNavigatorSaveItem_Click);
            // 
            // typesOfCrimesDataGridView
            // 
            this.typesOfCrimesDataGridView.AutoGenerateColumns = false;
            this.typesOfCrimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesOfCrimesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.typesOfCrimesDataGridView.DataSource = this.typesOfCrimesBindingSource;
            this.typesOfCrimesDataGridView.Location = new System.Drawing.Point(12, 32);
            this.typesOfCrimesDataGridView.Name = "typesOfCrimesDataGridView";
            this.typesOfCrimesDataGridView.RowHeadersWidth = 51;
            this.typesOfCrimesDataGridView.RowTemplate.Height = 24;
            this.typesOfCrimesDataGridView.Size = new System.Drawing.Size(647, 334);
            this.typesOfCrimesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameOfCrime";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameOfCrime";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Article";
            this.dataGridViewTextBoxColumn3.HeaderText = "Article";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Punishment";
            this.dataGridViewTextBoxColumn4.HeaderText = "Punishment";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Term";
            this.dataGridViewTextBoxColumn5.HeaderText = "Term";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 372);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(189, 67);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(496, 372);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 23);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(360, 372);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 23);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(222, 372);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(119, 23);
            this.addButton.TabIndex = 28;
            this.addButton.Text = "добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(630, 416);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(119, 23);
            this.nextButton.TabIndex = 27;
            this.nextButton.Text = "следующая";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(496, 416);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(119, 23);
            this.previousButton.TabIndex = 26;
            this.previousButton.Text = "предыдущая";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(360, 415);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(119, 23);
            this.lastButton.TabIndex = 25;
            this.lastButton.Text = "последняя";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(222, 415);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(119, 23);
            this.firstButton.TabIndex = 24;
            this.firstButton.Text = "первая";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // punishmentsListButton
            // 
            this.punishmentsListButton.Location = new System.Drawing.Point(860, 179);
            this.punishmentsListButton.Name = "punishmentsListButton";
            this.punishmentsListButton.Size = new System.Drawing.Size(207, 23);
            this.punishmentsListButton.TabIndex = 68;
            this.punishmentsListButton.Text = "список наказаний";
            this.punishmentsListButton.UseVisualStyleBackColor = true;
            this.punishmentsListButton.Click += new System.EventHandler(this.punishmentsListButton_Click);
            // 
            // crimesListButton
            // 
            this.crimesListButton.Location = new System.Drawing.Point(860, 62);
            this.crimesListButton.Name = "crimesListButton";
            this.crimesListButton.Size = new System.Drawing.Size(207, 23);
            this.crimesListButton.TabIndex = 67;
            this.crimesListButton.Text = "список перступлений";
            this.crimesListButton.UseVisualStyleBackColor = true;
            this.crimesListButton.Click += new System.EventHandler(this.crimesListButton_Click);
            // 
            // cbCrime
            // 
            this.cbCrime.FormattingEnabled = true;
            this.cbCrime.Location = new System.Drawing.Point(667, 62);
            this.cbCrime.Name = "cbCrime";
            this.cbCrime.Size = new System.Drawing.Size(163, 24);
            this.cbCrime.TabIndex = 66;
            // 
            // cbPunishment
            // 
            this.cbPunishment.FormattingEnabled = true;
            this.cbPunishment.Location = new System.Drawing.Point(670, 178);
            this.cbPunishment.Name = "cbPunishment";
            this.cbPunishment.Size = new System.Drawing.Size(163, 24);
            this.cbPunishment.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Срок";
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(667, 229);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(166, 22);
            this.textBoxTerm.TabIndex = 63;
            this.textBoxTerm.Text = "2 года";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Наказание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Статья";
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(667, 112);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(166, 22);
            this.textBoxArticle.TabIndex = 60;
            this.textBoxArticle.Text = "9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Преступление";
            // 
            // crimesBindingSource
            // 
            this.crimesBindingSource.DataMember = "Crimes";
            this.crimesBindingSource.DataSource = this.policeDepartmentDataSet;
            // 
            // typesOfCrimesTableAdapter
            // 
            this.typesOfCrimesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccidentsTableAdapter = null;
            this.tableAdapterManager.AffectedTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CrimesTableAdapter = null;
            this.tableAdapterManager.CriminalNamesTableAdapter = null;
            this.tableAdapterManager.CriminalsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PunishmentsTableAdapter = null;
            this.tableAdapterManager.TypesOfCrimesTableAdapter = this.typesOfCrimesTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab6.PoliceDepartmentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crimesTableAdapter
            // 
            this.crimesTableAdapter.ClearBeforeFill = true;
            // 
            // punishmentsTableAdapter
            // 
            this.punishmentsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TypeOfCrimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.punishmentsListButton);
            this.Controls.Add(this.crimesListButton);
            this.Controls.Add(this.cbCrime);
            this.Controls.Add(this.cbPunishment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.typesOfCrimesDataGridView);
            this.Controls.Add(this.typesOfCrimesBindingNavigator);
            this.Name = "TypeOfCrimes";
            this.Text = "TypeOfCrimes";
            this.Load += new System.EventHandler(this.TypeOfCrimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typesOfCrimesBindingNavigator)).EndInit();
            this.typesOfCrimesBindingNavigator.ResumeLayout(false);
            this.typesOfCrimesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfCrimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDepartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesOfCrimesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource typesOfCrimesBindingSource;
        private PoliceDepartmentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator typesOfCrimesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton typesOfCrimesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView typesOfCrimesDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button firstButton;
        public System.Windows.Forms.Button punishmentsListButton;
        public System.Windows.Forms.Button crimesListButton;
        public System.Windows.Forms.ComboBox cbCrime;
        public System.Windows.Forms.ComboBox cbPunishment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource crimesBindingSource;
        private PoliceDepartmentDataSetTableAdapters.CrimesTableAdapter crimesTableAdapter;
        public PoliceDepartmentDataSetTableAdapters.TypesOfCrimesTableAdapter typesOfCrimesTableAdapter;
        public PoliceDepartmentDataSet policeDepartmentDataSet;
        public PoliceDepartmentDataSetTableAdapters.PunishmentsTableAdapter punishmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}