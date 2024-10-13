using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab6
{
    public partial class Accidents : Form
    {
        private string TableName = "Accidents";
        public Accidents()
        {
            InitializeComponent();
        }

        private void accidentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accidentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void Accidents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.AccidentsView". При необходимости она может быть перемещена или удалена.
            this.accidentsViewTableAdapter.Fill(this.policeDepartmentDataSet.AccidentsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.policeDepartmentDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Affected". При необходимости она может быть перемещена или удалена.
            this.affectedTableAdapter.Fill(this.policeDepartmentDataSet.Affected);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Criminals". При необходимости она может быть перемещена или удалена.
            this.criminalsTableAdapter.Fill(this.policeDepartmentDataSet.Criminals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Crimes". При необходимости она может быть перемещена или удалена.
            this.crimesTableAdapter.Fill(this.policeDepartmentDataSet.Crimes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Accidents". При необходимости она может быть перемещена или удалена.
            this.accidentsTableAdapter.Fill(this.policeDepartmentDataSet.Accidents);
            this.crimesTableAdapter.Fill(this.policeDepartmentDataSet.Crimes);
            for (int j = 0; j < policeDepartmentDataSet.Crimes.Rows.Count; j++)
            {
                this.comboBoxCrimes.Items.Add(policeDepartmentDataSet.Crimes.Rows[j].ItemArray[1]);

            }
            comboBoxCrimes.SelectedIndex = 0;
            comboBoxCriminals.SelectedIndex = 0;
            comboBoxAffected.SelectedIndex = 0;
            comboBoxEmployee.SelectedIndex = 0;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(); //this is the change, code for redirect  
            form1.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WIN-B9PG27IQF4T;Initial Catalog=PoliceDepartment;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            // Создать команду
            SqlCommand command = new SqlCommand($"SELECT CrimeId FROM TypesOfCrimes where NameOfCrime='{comboBoxCrimes.Text}'", con);
            SqlCommand command2 = new SqlCommand($"SELECT CriminalId FROM Criminals where Surname='{comboBoxCriminals.Text}'", con);
            SqlCommand command3 = new SqlCommand($"SELECT AffectedId FROM Affected where Surname='{comboBoxAffected.Text}'", con);
            SqlCommand command4 = new SqlCommand($"SELECT EmployeeId FROM Employees where Surname='{comboBoxEmployee.Text}'", con);
            con.Open();
            // Получить значение COUNT
            int typeOfCrimeId = (int)command.ExecuteScalar();
            int criminalId = (int)command2.ExecuteScalar();
            int affectedId = (int)command3.ExecuteScalar();
            int employeeId = (int)command4.ExecuteScalar();
            DataRow row = policeDepartmentDataSet.Tables[TableName].NewRow();
            row[1] = typeOfCrimeId;
            row[2] = criminalId;
            row[3] = affectedId;
            row[4] = employeeId;
            row[5] = textBoxDateOfCrime.Text;
            row[6] = textBoxTimeOfCrime.Text;
            policeDepartmentDataSet.Tables[TableName].Rows.Add(row);

            DataRow row2 = policeDepartmentDataSet.Tables["AccidentsView"].NewRow();
            row2[0] = comboBoxCrimes.Text;
            row2[1] = comboBoxCriminals.Text;
            row2[2] = comboBoxAffected.Text;
            row2[3] = comboBoxEmployee.Text;
            row2[4] = textBoxDateOfCrime.Text;
            row2[5] = textBoxTimeOfCrime.Text;
            policeDepartmentDataSet.Tables["AccidentsView"].Rows.Add(row2);
            //affectedBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            accidentsBindingSource.RemoveCurrent();
            accidentsViewBindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            accidentsBindingSource.EndEdit();
            accidentsViewBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(policeDepartmentDataSet);
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            accidentsBindingSource.MoveFirst();
            accidentsViewBindingSource.MoveFirst();
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            accidentsBindingSource.MoveLast();
            accidentsViewBindingSource.MoveLast();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            accidentsBindingSource.MovePrevious();
            accidentsViewBindingSource.MovePrevious();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            accidentsBindingSource.MoveNext();
            accidentsViewBindingSource.MoveNext();
        }
        Report report;
        private void reportButton_Click(object sender, EventArgs e)
        {
            if (report == null || report.IsDisposed) //Если Форма отсутствует или не определена,
                report = new Report();  //то создать форму
            report.ShowDialog(this);
        }

        private void crimesListButton_Click(object sender, EventArgs e)
        {
            CrimesList crimesList = new CrimesList();
            crimesList.Owner = this;
            crimesList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=WIN-B9PG27IQF4T;Initial Catalog=PoliceDepartment;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            // Создать команду
            SqlCommand command = new SqlCommand($"SELECT CrimeId FROM TypesOfCrimes where NameOfCrime='{comboBoxCrimes.Text}'", con);
            SqlCommand command2 = new SqlCommand($"SELECT CriminalId FROM Criminals where Surname='{comboBoxCriminals.Text}'", con);
            SqlCommand command3 = new SqlCommand($"SELECT AffectedId FROM Affected where Surname='{comboBoxAffected.Text}'", con);
            SqlCommand command4 = new SqlCommand($"SELECT EmployeeId FROM Employees where Surname='{comboBoxEmployee.Text}'", con);
            con.Open();
            // Получить значение COUNT
            int typeOfCrimeId = (int)command.ExecuteScalar();
            int criminalId = (int)command2.ExecuteScalar();
            int affectedId = (int)command3.ExecuteScalar();
            int employeeId = (int)command4.ExecuteScalar();
            DataRow row = policeDepartmentDataSet.Tables[TableName].NewRow();
            row[1] = typeOfCrimeId;
            row[2] = criminalId;
            row[3] = affectedId;
            row[4] = employeeId;
            row[5] = textBoxDateOfCrime.Text;
            row[6] = textBoxTimeOfCrime.Text;

            if (MessageBox.Show("Вы действительно хотите изменить запись?", "Изменить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ((DataRowView)accidentsBindingSource.Current).Row.ItemArray[1] = typeOfCrimeId;
                ((DataRowView)accidentsBindingSource.Current).Row.ItemArray[2] = criminalId;
                ((DataRowView)accidentsBindingSource.Current).Row.ItemArray[3] = affectedId;
                ((DataRowView)accidentsBindingSource.Current).Row.ItemArray[4] = employeeId;
                ((DataRowView)accidentsBindingSource.Current).Row.ItemArray[5] = textBoxDateOfCrime.Text;
                ((DataRowView)accidentsBindingSource.Current).Row.ItemArray[6] = textBoxTimeOfCrime.Text;

                accidentsDataGridView.Rows[accidentsViewBindingSource.Position].Cells[1].Value = typeOfCrimeId;
                accidentsDataGridView.Rows[accidentsViewBindingSource.Position].Cells[2].Value = criminalId;
                accidentsDataGridView.Rows[accidentsViewBindingSource.Position].Cells[3].Value = affectedId;
                accidentsDataGridView.Rows[accidentsViewBindingSource.Position].Cells[4].Value = employeeId;
                accidentsDataGridView.Rows[accidentsViewBindingSource.Position].Cells[5].Value = textBoxDateOfCrime.Text;
                accidentsDataGridView.Rows[accidentsViewBindingSource.Position].Cells[6].Value = textBoxTimeOfCrime.Text;

                accidentsViewDataGridView.Rows[accidentsViewBindingSource.Position].Cells[0].Value = comboBoxCrimes.Text;
                accidentsViewDataGridView.Rows[accidentsViewBindingSource.Position].Cells[1].Value = comboBoxCriminals.Text;
                accidentsViewDataGridView.Rows[accidentsViewBindingSource.Position].Cells[2].Value = comboBoxAffected.Text;
                accidentsViewDataGridView.Rows[accidentsViewBindingSource.Position].Cells[3].Value = comboBoxEmployee.Text;
                accidentsViewDataGridView.Rows[accidentsViewBindingSource.Position].Cells[4].Value = textBoxDateOfCrime.Text;
                accidentsViewDataGridView.Rows[accidentsViewBindingSource.Position].Cells[5].Value = textBoxTimeOfCrime.Text;
                if (checkBox1.Enabled)
                {
                    saveButton_Click(sender, e);
                }
            }
        }
    }
    
}
