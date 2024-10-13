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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.policeDepartmentDataSet.Employees);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(); //this is the change, code for redirect  
            form1.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string table = "Employees";
            DataRow row = policeDepartmentDataSet.Tables[table].NewRow();
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
            row[7] = textBoxPhone.Text;
            row[8] = textBoxPosition.Text;
            row[9] = textBoxRank.Text;
            policeDepartmentDataSet.Tables[table].Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(policeDepartmentDataSet);
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveFirst();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveLast();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MovePrevious();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            employeesBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[0].Value = textBoxSurname.Text;
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[1].Value = textBoxPatronymic.Text;
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[2].Value = textBoxFirstname.Text;
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[3].Value = textBoxBirthday.Text;
                if (radioButton1.Checked)
                {
                    employeesDataGridView.Rows[employeesBindingSource.Position].Cells[4].Value = "Мужской";
                }
                else
                {
                    employeesDataGridView.Rows[employeesBindingSource.Position].Cells[4].Value = "Женский";
                }
               
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[5].Value = textBoxAddres.Text;
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[6].Value = textBoxPhone.Text;
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[7].Value = textBoxPosition.Text;
                employeesDataGridView.Rows[employeesBindingSource.Position].Cells[8].Value = textBoxRank.Text; ;
            }
        }
    }
}
