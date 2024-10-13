using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Affected : Form
    {
        public Affected()
        {
            InitializeComponent();
        }

        private void affectedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.affectedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void Affected_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Affected". При необходимости она может быть перемещена или удалена.
            this.affectedTableAdapter.Fill(this.policeDepartmentDataSet.Affected);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(); //this is the change, code for redirect  
            form1.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataRow row = policeDepartmentDataSet.Tables["Affected"].NewRow();
            row[1] = textBoxSurname.Text;
            row[2] = textBoxPatronymic.Text;
            row[3] = textBoxFirstname.Text;
            row[4] = textBoxBirthday.Text;
            if (radioButton1.Checked)
            {
                row[5] = "Мужской";
            }
            else
            {
                row[5] = "Женский";
            }
            
            row[6] = textBoxAddres.Text;
            policeDepartmentDataSet.Tables["Affected"].Rows.Add(row);
            //affectedBindingSource.AddNew();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            affectedBindingSource.MoveFirst();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            affectedBindingSource.MoveLast();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            affectedBindingSource.MovePrevious();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            affectedBindingSource.MoveNext();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            affectedBindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            affectedBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(policeDepartmentDataSet);

        }
        Report report;
        private void reportButton_Click(object sender, EventArgs e)
        {
            if (report == null || report.IsDisposed) //Если Форма отсутствует или не определена,
                report = new Report();  //то создать форму
            report.ShowDialog(this);
        }
        public string getSurname() {
            return textBoxSurname.Text;
        }
        public string getPatronymic()
        {
            return textBoxPatronymic.Text;
        }
        public string getFirstName() {
            return textBoxFirstname.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                affectedDataGridView.Rows[affectedBindingSource.Position].Cells[0].Value = textBoxSurname.Text;
                affectedDataGridView.Rows[affectedBindingSource.Position].Cells[1].Value = textBoxPatronymic.Text;
                affectedDataGridView.Rows[affectedBindingSource.Position].Cells[2].Value = textBoxFirstname.Text;
                affectedDataGridView.Rows[affectedBindingSource.Position].Cells[3].Value = textBoxBirthday.Text;
                if (radioButton1.Checked)
                {
                    affectedDataGridView.Rows[affectedBindingSource.Position].Cells[4].Value = "Мужской";
                }
                else {
                    affectedDataGridView.Rows[affectedBindingSource.Position].Cells[4].Value = "Женский";
                }
                
                affectedDataGridView.Rows[affectedBindingSource.Position].Cells[5].Value = textBoxAddres.Text;
            }
        }
    }
}
