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
    public partial class FormUpdateWorkshop : Form
    {
        DataBase database = new DataBase();

        public FormUpdateWorkshop()
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
            int idEnterprise = (int)(enterpriseNumeric.Value);
            int idBoss = (int)(bossNumeric.Value);
            string[] columnsName = { "id", "name", "id_enterprise", "id_boss" };
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idEnterprise), Convert.ToString(idBoss) };
            database.UpdateElement(idValue, "workshop", columnsName, columnsValue);
            MessageBox.Show("Товар успішно змінено.");
            this.Close();
        }
    }
}
