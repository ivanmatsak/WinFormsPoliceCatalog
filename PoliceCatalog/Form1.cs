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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Report report;
        private void accidentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accidents accidents = new Accidents(); //this is the change, code for redirect  
            accidents.ShowDialog();
        }

        private void affectedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Affected affected = new Affected(); //this is the change, code for redirect  
            affected.ShowDialog();
        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employees employees = new Employees(); //this is the change, code for redirect  
            employees.ShowDialog();
        }

        private void criminalsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cryminals cryminals = new Cryminals(); //this is the change, code for redirect  
            cryminals.ShowDialog();
        }

        private void typesOfCrimesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeOfCrimes typeOfCrimes = new TypeOfCrimes(); //this is the change, code for redirect  
            typeOfCrimes.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            RelatedTablescs relatedTablescs = new RelatedTablescs(); //this is the change, code for redirect  
            relatedTablescs.ShowDialog();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (report == null || report.IsDisposed) //Если Форма отсутствует или не определена,
                report = new Report();  //то создать форму
            report.ShowDialog(this);

        }

       
        private void buttonPunishments_Click(object sender, EventArgs e)
        {
            PunishmentsList punishmentsList = new PunishmentsList();
            punishmentsList.Owner = this;
            punishmentsList.ShowDialog();
        }

        private void buttonCrimes_Click(object sender, EventArgs e)
        {
            CrimesList crimesList = new CrimesList();
            crimesList.Owner = this;
            crimesList.ShowDialog();
        }
    }
}
