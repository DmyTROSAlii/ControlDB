using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDeleteArea : Form
    {
        DataBase database = new DataBase();
        public FormDeleteArea()
        {
            InitializeComponent();
            tableLayoutPanelDeskTop.BackColor = Color.Black;
        }
        /// <summary>
        /// Видалення елементу по натиску кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = (int)(numericID.Value); // отримуємо внесений id
            database.DeleteElement(id, "area"); // викликаємо метод для видалення елементу з таблиці
            this.Close(); // закриваємо дану форму
        }
    }
}
