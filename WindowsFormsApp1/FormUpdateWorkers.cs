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
    public partial class FormUpdateWorkers : Form
    {
        DataBase database = new DataBase();

        public FormUpdateWorkers()
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
            string full_name = nameBox.Text;
            string position = positionBox.Text;
            int idBrigade = (int)brigadeNumeric.Value;
            string birthday = Convert.ToString(birthdayBox);
            string gender = sexBox.Text;
            string startDate = Convert.ToString(startCalendar);
            string endDate = Convert.ToString(endCalendar);
            string[] columnsName = { "id", "full_name", "position", "id_brigade", "birthday", "gender", "start_date", "end_date" };
            string[] columnsValue = { Convert.ToString(idValue), full_name, position, Convert.ToString(idBrigade), birthday, gender, startDate, endDate };
            database.UpdateElement(idValue, "workers", columnsName, columnsValue);
            MessageBox.Show("Товар успішно змінено.");
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
