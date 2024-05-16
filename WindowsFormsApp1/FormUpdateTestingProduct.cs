using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormUpdateTestingProduct : Form
    {
        DataBase database = new DataBase();

        public FormUpdateTestingProduct()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.Black;
        }
        /// <summary>
        /// Зміна данних в товарі
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idValue = (int)(idNumeric.Value);
            int idTypeProduct = (int)typeNumeric.Value;
            int idTester = (int)testerNumeric.Value;
            string equip = equipBox.Text;
            string name = nameBox.Text;
            string startDate = Convert.ToString(startCalendar);
            string endDate = Convert.ToString(endCalendar);
            string result = resultBox.Text;
            string[] columnsName = { "id", "id_productType", "id_tester", "testing_equipment", "name", "start_date", "end_date", "result" };
            string[] columnsValue = { Convert.ToString(idValue), Convert.ToString(idTypeProduct), Convert.ToString(idTester), equip, name, startDate, endDate, result };
            database.UpdateElement(idValue, "TestingProduct", columnsName, columnsValue);
            MessageBox.Show("Товар успішно змінено.");
            this.Close();
        }
    }
}
