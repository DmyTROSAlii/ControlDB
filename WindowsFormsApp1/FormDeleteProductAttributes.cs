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
    public partial class FormDeleteProductAttributes : Form
    {
        DataBase database = new DataBase();
        public FormDeleteProductAttributes()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.Black;
        }
        /// <summary>
        /// Видалення товару по натиску кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = (int)(numericID.Value);
            database.DeleteElement(id, "productattributes");
            this.Close();
        }
    }
}
