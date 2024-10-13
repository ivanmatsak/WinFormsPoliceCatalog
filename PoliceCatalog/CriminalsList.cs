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
    public partial class CriminalsList : Form
    {
        public CriminalsList()
        {
            InitializeComponent();
        }

        private void criminalNamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criminalNamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void CriminalsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.CriminalNames". При необходимости она может быть перемещена или удалена.
            this.criminalNamesTableAdapter.Fill(this.policeDepartmentDataSet.CriminalNames);

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            criminalNamesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(policeDepartmentDataSet); // Обновление данных в БД
            Accidents main = this.Owner as Accidents;
            if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
            {
                int selInd = main.comboBoxCriminals.SelectedIndex; //запоминаем текущий индекс comboBox1
                main.accidentsTableAdapter.Fill(main.policeDepartmentDataSet.Accidents); //обновляем данные
                main.comboBoxCriminals.SelectedIndex = selInd; //восстанавливаем исходный список
                main.comboBoxCriminals.Items.Clear();
                for (int j = 0; j < policeDepartmentDataSet.Crimes.Rows.Count; j++)
                {
                    main.comboBoxCriminals.Items.Add(policeDepartmentDataSet.Crimes.Rows[j].ItemArray[1]);
                }
            }

            this.Close();
        }
    }
}
