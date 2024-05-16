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
    public partial class FormUpdateProductAttributes : Form
    {
        DataBase database = new DataBase();
        List<string> goodsNames;
        public FormUpdateProductAttributes()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.Black;
        }
        /// <summary>
        /// Зміна данних в елементів
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idValue = (int)(idNumeric.Value);
            string name = nameBox.Text;
            int idType = (int)(typeNumeric.Value);
            string type = typeBox.Text;
            string value = valueBox.Text;
            string[] columnsName = { "id", "name", "id_workshop", "type", "value" };
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idType), type, value };
            database.UpdateElement(idValue, "productattributes", columnsName, columnsValue);
            MessageBox.Show("Товар успішно змінено.");
            this.Close();
        }
    }
}
