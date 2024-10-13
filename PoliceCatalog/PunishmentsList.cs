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
    public partial class PunishmentsList : Form
    {
        public PunishmentsList()
        {
            InitializeComponent();
        }

        private void punishmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.punishmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.policeDepartmentDataSet);

        }

        private void PunishmentsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "policeDepartmentDataSet.Punishments". При необходимости она может быть перемещена или удалена.
            this.punishmentsTableAdapter.Fill(this.policeDepartmentDataSet.Punishments);

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            punishmentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(policeDepartmentDataSet); // Обновление данных в БД
            TypeOfCrimes main = this.Owner as TypeOfCrimes;
            if (main != null) //Если открыта форма 2 (Сотрудники). То обновляем comboBox1
            {
                int selInd = main.cbPunishment.SelectedIndex; //запоминаем текущий индекс comboBox1
                main.typesOfCrimesTableAdapter.Fill(main.policeDepartmentDataSet.TypesOfCrimes); //обновляем данные
                main.cbPunishment.SelectedIndex = selInd; //восстанавливаем исходный список
                main.cbPunishment.Items.Clear();
                for (int j = 0; j < policeDepartmentDataSet.Punishments.Rows.Count; j++)
                {
                    main.cbPunishment.Items.Add(policeDepartmentDataSet.Punishments.Rows[j].ItemArray[1]);
                }
            }

            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
