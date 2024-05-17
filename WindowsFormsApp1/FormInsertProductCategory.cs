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
    public partial class FormInsertProductCategory : Form
    {
        DataBase database = new DataBase();
        public FormInsertProductCategory()
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
            int idValue = database.getIDFromTable("productcategory");
            string name = nameBox.Text;
            int idWorkshop = (int)(workshopNumeric.Value);
            string[] columnsName = { "id", "name", "id_workshop" };
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idWorkshop) };
            database.AddElement("productcategory", columnsName, columnsValue);
            this.Close();
        }
    }
}
