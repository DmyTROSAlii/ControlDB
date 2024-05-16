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
    public partial class FormUpdateArea : Form
    {
        DataBase database = new DataBase();

        public FormUpdateArea()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.Black;
        }
        /// <summary>
        /// Зміна данних в товарі
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idValue = (int)(idNumeric.Value);
            string name = nameBox.Text;
            int idWorkshop = (int)(workshopNumeric.Value);
            int idBoss = (int)(bossNumeric.Value);
            string[] columnsName = { "id", "name", "id_workshop", "id_boss" };
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idWorkshop), Convert.ToString(idBoss) };
            database.UpdateElement(idValue, "area", columnsName, columnsValue);
            MessageBox.Show("Товар успішно змінено.");
            this.Close();
        }
    }
}
