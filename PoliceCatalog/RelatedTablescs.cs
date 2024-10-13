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
    public partial class RelatedTablescs : Form
    {
        public RelatedTablescs()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(); //this is the change, code for redirect  
            form1.ShowDialog();
        }

        private void RelatedTablescs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.policeDepartmentDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Affected". При необходимости она может быть перемещена или удалена.
            this.affectedTableAdapter.Fill(this.policeDepartmentDataSet.Affected);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Accidents". При необходимости она может быть перемещена или удалена.
            this.accidentsTableAdapter.Fill(this.policeDepartmentDataSet.Accidents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Criminals". При необходимости она может быть перемещена или удалена.
            this.criminalsTableAdapter.Fill(this.policeDepartmentDataSet.Criminals);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
