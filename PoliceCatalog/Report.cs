using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace lab6
{
    public partial class Report : Form
    {

        public Report()
        {
            InitializeComponent();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet1.Crimes". При необходимости она может быть перемещена или удалена.
            this.crimesTableAdapter.Fill(this.policeDepartmentDataSet.Crimes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet11.AccidentsView". При необходимости она может быть перемещена или удалена.
            this.accidentsViewTableAdapter.Fill(this.policeDepartmentDataSet.AccidentsView);
            this.reportViewer1.RefreshReport();
            this.crimesTableAdapter.Fill(this.policeDepartmentDataSet.Crimes);
            for (int j = 0; j < policeDepartmentDataSet.Crimes.Rows.Count; j++)
            {
                this.comboBox1.Items.Add(policeDepartmentDataSet.Crimes.Rows[j].ItemArray[1]);

            }
            comboBox1.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accidents accidents = new Accidents(); //this is the change, code for redirect  
            accidents.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            accidentsViewBindingSource.Filter = $"DateOfCrime>= '{dateTimePicker1.Value}' and DateOfCrime<= '{dateTimePicker2.Value}' and NameOfCrime='{comboBox1.Text}'";
            //SetDate();
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accidentsViewBindingSource.Filter = $"DateOfCrime>= '{dateTimePicker1.Value}' and DateOfCrime<= '{dateTimePicker2.Value}'";
            //SetDate();
            reportViewer1.RefreshReport();
        }
    }
}
