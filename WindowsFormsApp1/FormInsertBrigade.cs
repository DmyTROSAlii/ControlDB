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
    public partial class FormInsertBrigade : Form
    {
        DataBase database = new DataBase();
        public FormInsertBrigade()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.Black;
        }
        /// <summary>
        /// Внесеня данних в таблицю по натиску кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int idValue = database.getIDFromTable("brigade");
            int idArea = (int)(areaNumeric.Value);
            int idBoss = (int)(bossNumeric.Value);
            int countWorkers = (int)(countNumeric.Value);
            string[] columnsName = { "id", "id_area", "id_boss", "count_workers" };
            string[] columnsValue = { Convert.ToString(idValue), Convert.ToString(idArea), Convert.ToString(idBoss), Convert.ToString(countWorkers) };
            database.AddElement("brigade", columnsName, columnsValue);
            this.Close();
        }
    }
}
