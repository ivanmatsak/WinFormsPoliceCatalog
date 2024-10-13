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
    public partial class CrimesList : Form
    {
        public CrimesList()
        {
            InitializeComponent();
        }

        private void crimesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.crimesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void CrimesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Crimes". При необходимости она может быть перемещена или удалена.
            this.crimesTableAdapter.Fill(this.policeDepartmentDataSet.Crimes);

        }

        private void yesButton_Click(object sender, EventArgs e)
        {

            
            crimesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(policeDepartmentDataSet); // Обновление данных в БД
            TypeOfCrimes main = this.Owner as TypeOfCrimes;
            Accidents main2 = this.Owner as Accidents;
            if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
            {
                int selInd = main.cbCrime.SelectedIndex; //запоминаем текущий индекс comboBox1
                main.typesOfCrimesTableAdapter.Fill(main.policeDepartmentDataSet.TypesOfCrimes); //обновляем данные
                main.cbCrime.SelectedIndex = selInd; //восстанавливаем исходный список
                main.cbCrime.Items.Clear();
                for (int j = 0; j < policeDepartmentDataSet.Crimes.Rows.Count; j++)
                {
                    main.cbCrime.Items.Add(policeDepartmentDataSet.Crimes.Rows[j].ItemArray[1]);
                }
            }
            if (main2 != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
            {
                int selInd = main2.comboBoxCrimes.SelectedIndex; //запоминаем текущий индекс comboBox1
                main2.accidentsTableAdapter.Fill(main2.policeDepartmentDataSet.Accidents); //обновляем данные
                main2.comboBoxCrimes.SelectedIndex = selInd; //восстанавливаем исходный список
                main2.comboBoxCrimes.Items.Clear();
                for (int j = 0; j < policeDepartmentDataSet.Crimes.Rows.Count; j++)
                {
                    main2.comboBoxCrimes.Items.Add(policeDepartmentDataSet.Crimes.Rows[j].ItemArray[1]);
                }
            }
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
