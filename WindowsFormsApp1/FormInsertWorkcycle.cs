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
    public partial class FormInsertWorkcycle : Form
    {
        DataBase database = new DataBase();
        //string[] oldColumnNames = { "id", "name" };
        public FormInsertWorkcycle()
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
            int idValue = database.getIDFromTable("workcycle");
            int idTypeProduct = (int)typeNumeric.Value;
            int idArea = (int)areaNumeric.Value;
            int idBrigade = (int)brigadeNumeric.Value;
            string startDate = Convert.ToString(startCalendar);
            string endDate = Convert.ToString(endCalendar);
            string status = statusBox.Text;
            string[] columnsName = { "id", "id_productType", "id_area", "id_brigade", "start_date", "end_date", "status" };
            string[] columnsValue = { Convert.ToString(idValue), Convert.ToString(idTypeProduct), Convert.ToString(idArea), Convert.ToString(idBrigade), startDate, endDate, status };
            database.AddElement("workcycle", columnsName, columnsValue);
            this.Close();
        }
    }
}
