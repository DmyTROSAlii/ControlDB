using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInsertWorkers : Form
    {
        DataBase database = new DataBase();
        //string[] oldColumnNames = { "id", "name" };
        public FormInsertWorkers()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.Black;
        }
        /// <summary>
        /// Внесеня данних в таблицю Goods по натиску кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int idValue = database.getIDFromTable("workers");
            string full_name = nameBox.Text;
            string position = positionBox.Text;
            int idBrigade = (int)brigadeNumeric.Value;
            string birthday = Convert.ToString(birthdayBox);
            string gender = sexBox.Text;
            string startDate = Convert.ToString(startCalendar);
            string endDate = Convert.ToString(endCalendar);
            string[] columnsName = { "id", "full_name", "position", "id_brigade", "birthday", "gender", "start_date", "end_date" };
            string[] columnsValue = { Convert.ToString(idValue), full_name, position, Convert.ToString(idBrigade), birthday, gender, startDate, endDate };
            database.AddElement("workers", columnsName, columnsValue);
            this.Close();
        }

        private void statusBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
