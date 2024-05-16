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
    public partial class FormUpdateWorkcycle : Form
    {
        DataBase database = new DataBase();

        public FormUpdateWorkcycle()
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
            int idArea = (int)areaNumeric.Value;
            int idBrigade = (int)brigadeNumeric.Value;
            string startDate = Convert.ToString(startCalendar);
            string endDate = Convert.ToString(endCalendar);
            string status = statusBox.Text;
            string[] columnsName = { "id", "id_productType", "id_area", "id_brigade", "start_date", "end_date", "status" };
            string[] columnsValue = { Convert.ToString(idValue), Convert.ToString(idTypeProduct), Convert.ToString(idArea), Convert.ToString(idBrigade), startDate, endDate, status };
            database.UpdateElement(idValue, "workcycle", columnsName, columnsValue);
            MessageBox.Show("Товар успішно змінено.");
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
