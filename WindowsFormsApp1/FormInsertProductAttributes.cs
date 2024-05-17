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
    public partial class FormInsertProductAttributes : Form
    {
        DataBase database = new DataBase();
        public FormInsertProductAttributes()
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
            int idValue = database.getIDFromTable("productattributes");
            string name = nameBox.Text;
            int idType = (int)(typeNumeric.Value);
            string type = typeBox.Text;
            string value = valueBox.Text;
            string[] columnsName = { "id", "name", "id_workshop", "type", "value" };
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idType), type, value };
            database.AddElement("productattributes", columnsName, columnsValue);
            this.Close();
        }
    }
}
