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
    public partial class FormInsertEnterprise : Form
    {
        DataBase database = new DataBase();
        string[] oldColumnNames = { "id", "name" };
        public FormInsertEnterprise()
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
            int idValue = database.getIDFromTable("enterprise");
            string name = textBox_Name.Text;
            string[] columnsName = { "id", "name" };
            string[] columnsValue = { Convert.ToString(idValue), name };
            database.AddElement("enterprise", columnsName, columnsValue);
            this.Close();
        }
    }
}
