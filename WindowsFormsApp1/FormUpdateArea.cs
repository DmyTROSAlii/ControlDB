using System;
using System.Drawing;
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
            int idValue = (int)(idNumeric.Value); // отримуємо внесений id з форми
            string name = nameBox.Text; // отимуємо внесену назву з форми
            int idWorkshop = (int)(workshopNumeric.Value); // отримуємо внесений id майстерні з форми
            int idBoss = (int)(bossNumeric.Value); // отримуємо внесений id начальника з форми
            string[] columnsName = { "id", "name", "id_workshop", "id_boss" }; // записуємо назви стовбців таблиці Area
            string[] columnsValue = { Convert.ToString(idValue), name, Convert.ToString(idWorkshop), Convert.ToString(idBoss) }; // записуємо значення до стовпців таблиці
            database.UpdateElement(idValue, "area", columnsName, columnsValue);  // викликаємо метод для редагування елементу у таблиці
            MessageBox.Show("Товар успішно змінено."); // виводимо повідомлення, що товар успішно змінений
            this.Close(); // закриваємо дану форму
        }
    }
}
