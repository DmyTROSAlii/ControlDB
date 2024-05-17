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
    public partial class FormUpdateBrigade : Form
    {
        DataBase database = new DataBase();
        List<string> goodsNames;
        public FormUpdateBrigade()
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
            int idArea = (int)(areaNumeric.Value);
            int idBoss = (int)(bossNumeric.Value);
            int countWorkers = (int)(countNumeric.Value);
            string[] columnsName = { "id", "name", "id_workshop", "id_boss" };
            string[] columnsValue = { Convert.ToString(idValue), Convert.ToString(idArea), Convert.ToString(idBoss), Convert.ToString(countWorkers) };
            database.UpdateElement(idValue, "brigade", columnsName, columnsValue);
            MessageBox.Show("Товар успішно змінено.");
            this.Close();
        }
    }
}
