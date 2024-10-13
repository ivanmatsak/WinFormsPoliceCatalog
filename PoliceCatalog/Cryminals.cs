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
    public partial class Cryminals : Form
    {
        public Cryminals()
        {
            InitializeComponent();
        }

        private void criminalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criminalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void Cryminals_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Criminals". При необходимости она может быть перемещена или удалена.
            this.criminalsTableAdapter.Fill(this.policeDepartmentDataSet.Criminals);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(); //this is the change, code for redirect  
            form1.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string table = "Criminals";
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
            row[7] = textBoxCondition.Text;
            policeDepartmentDataSet.Tables[table].Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            criminalsBindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            criminalsBindingSource.EndEdit();
            criminalsTableAdapter.Adapter.Update(policeDepartmentDataSet);
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            criminalsBindingSource.MoveFirst();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            criminalsBindingSource.MoveLast();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            criminalsBindingSource.MovePrevious();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            criminalsBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[0].Value = textBoxSurname.Text;
                criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[1].Value = textBoxPatronymic.Text;
                criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[2].Value = textBoxFirstname.Text;
                criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[3].Value = textBoxBirthday.Text;
                if (radioButton1.Checked)
                {
                    criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[4].Value = "Мужской";
                }
                else
                {
                    criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[4].Value = "Женский";
                }
                
                criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[5].Value = textBoxAddres.Text;
                criminalsDataGridView.Rows[criminalsBindingSource.Position].Cells[6].Value = textBoxCondition.Text;
            
            }
        }
    }
}
