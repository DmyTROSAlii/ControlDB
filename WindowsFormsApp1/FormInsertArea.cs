using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormInsertArea : Form
    {
        DataBase database = new DataBase();
        public FormInsertArea()
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
            int idValue = database.getIDFromTable("Area"); // отримуємо незайманий id
            string name = textBox_Name.Text; // отимуємо внесену назву з форми
            int idWorkshop = (int)(workshopNumeric.Value); // отримуємо внесений id майстерні з форми
            int idBoss = (int)(bossNumeric.Value); // отримуємо внесений id начальника з форми
            string[] columnsName = { "id", "name", "id_workshop", "id_boss" }; // записуємо назви стовбців таблиці Area
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idWorkshop), Convert.ToString(idBoss) }; // записуємо значення до стовпців таблиці
            database.AddElement("Area", columnsName, columnsValue); // викликаємо метод для додавання елементу до таблиці
            this.Close(); // закриваємо дану форму
        }
    }
}
