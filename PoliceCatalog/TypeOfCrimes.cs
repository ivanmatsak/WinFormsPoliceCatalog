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
    public partial class TypeOfCrimes : Form
    {
        public TypeOfCrimes()
        {
            InitializeComponent();
            
        }
        public object getAdapter()
        {
            return this.typesOfCrimesTableAdapter;
        }
        private void typesOfCrimesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typesOfCrimesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void TypeOfCrimes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Crimes". При необходимости она может быть перемещена или удалена.
            this.crimesTableAdapter.Fill(this.policeDepartmentDataSet.Crimes);
            this.punishmentsTableAdapter.Fill(this.policeDepartmentDataSet.Punishments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.TypesOfCrimes". При необходимости она может быть перемещена или удалена.
            this.typesOfCrimesTableAdapter.Fill(this.policeDepartmentDataSet.TypesOfCrimes);
            for (int j = 0; j < policeDepartmentDataSet.Crimes.Rows.Count; j++)
            {
                this.cbCrime.Items.Add(policeDepartmentDataSet.Crimes.Rows[j].ItemArray[1]);

            }
            for (int j = 0; j < policeDepartmentDataSet.Punishments.Rows.Count; j++)
            {
                this.cbPunishment.Items.Add(policeDepartmentDataSet.Punishments.Rows[j].ItemArray[1]);
            }
            cbCrime.SelectedIndex = 0;
            cbPunishment.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(); //this is the change, code for redirect  
            form1.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string table = "TypesOfCrimes";
            DataRow row = policeDepartmentDataSet.Tables[table].NewRow();
            row[1] = cbCrime.Text;
            row[2] = textBoxArticle.Text;
            row[3] = cbPunishment.Text;
            row[4] = textBoxTerm.Text;
            policeDepartmentDataSet.Tables[table].Rows.Add(row);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            typesOfCrimesBindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            typesOfCrimesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(policeDepartmentDataSet);
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            typesOfCrimesBindingSource.MoveFirst();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            typesOfCrimesBindingSource.MoveLast();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            typesOfCrimesBindingSource.MovePrevious();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            typesOfCrimesBindingSource.MoveNext();
        }

        private void crimesListButton_Click(object sender, EventArgs e)
        {
            CrimesList crimesList = new CrimesList();
            crimesList.Owner = this;
            crimesList.ShowDialog();
        }

        private void punishmentsListButton_Click(object sender, EventArgs e)
        {
            PunishmentsList f2 = new PunishmentsList();
            f2.Owner = this;
            f2.ShowDialog();
        }
        public PoliceDepartmentDataSet getDataSet()
        {
            return policeDepartmentDataSet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
           
                typesOfCrimesDataGridView.Rows[typesOfCrimesBindingSource.Position].Cells[0].Value = cbCrime.Text;
                typesOfCrimesDataGridView.Rows[typesOfCrimesBindingSource.Position].Cells[1].Value = textBoxArticle.Text;
                typesOfCrimesDataGridView.Rows[typesOfCrimesBindingSource.Position].Cells[2].Value = cbPunishment.Text;
                typesOfCrimesDataGridView.Rows[typesOfCrimesBindingSource.Position].Cells[3].Value = textBoxTerm.Text;

            }
        }
    }
}
