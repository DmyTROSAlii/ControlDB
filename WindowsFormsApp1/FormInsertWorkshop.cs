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
    public partial class FormInsertWorkshop : Form
    {
        DataBase database = new DataBase();
        string[] oldColumnNames = { "id", "name" };
        public FormInsertWorkshop()
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
            int idValue = database.getIDFromTable("workshop");
            string name = nameBox.Text;
            int idEnterprise = (int)(enterpriseNumeric.Value);
            int idBoss = (int)(bossNumeric.Value);
            string[] columnsName = { "id", "name", "id_enterprise", "id_boss" };
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idEnterprise), Convert.ToString(idBoss) };
            database.AddElement("workshop", columnsName, columnsValue);
            this.Close();
        }
    }
}
