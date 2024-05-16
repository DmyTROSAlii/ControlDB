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
    public partial class FormInsertArea : Form
    {
        DataBase database = new DataBase();
        string[] oldColumnNames = { "id", "name" };
        public FormInsertArea()
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
            int idValue = database.getIDFromTable("Area");
            string name = textBox_Name.Text;
            int idWorkshop = (int)(workshopNumeric.Value);
            int idBoss = (int)(bossNumeric.Value);
            string[] columnsName = { "id", "name", "id_workshop", "id_boss" };
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idWorkshop), Convert.ToString(idBoss) };
            database.AddElement("Area", columnsName, columnsValue);
            this.Close();
        }
    }
}
