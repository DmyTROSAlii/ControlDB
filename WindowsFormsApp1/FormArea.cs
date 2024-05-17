using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class FormArea : Form
    {
        /// <summary>
        /// Обновлення виводу таблиці при яких-ось діях
        /// </summary>
        private void ReloadData()
        {
            DataBase database = new DataBase();
            DataTable tableData = database.GetTableData("area", oldColumnNames, newColumNames, valueColumns, searchName);
            dataGridViewTable.DataSource = tableData;
        }
        static string searchName; // назва для пошуку
        static int valueColumns; // значення стовбців
        string[] newColumNames = { "id", "Назва", "Майстерня", "Начальник" }; // назви ствовбців у таблиці як записано в БД
        string[] oldColumnNames = { "id", "name", "id_workshop", "id_boss" }; // назви стовбців у таблиці як записано у формі виводу
        public FormArea()
        {
            DataBase database = new DataBase(); 
            InitializeComponent();
            KeyPreview = true; // Вмикаємо перегляд клавіщ на формі
            KeyDown += Form_KeyDown; // Привязуємо обробник до кнопки
            panelMenu.BackColor = Color.Black;
            panelDesktop.BackColor = Color.Black;
            DataTable tableData = database.GetTableData("area", oldColumnNames, newColumNames, valueColumns);
            dataGridViewTable.DataSource = tableData;
            // Прибираємо рядок зліва
            dataGridViewTable.RowHeadersVisible = false;
            // Текст робимо по центру
            dataGridViewTable.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо по центру
            dataGridViewTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Текст назв колонок робимо жирним шрифтом
            dataGridViewTable.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewTable.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            // Розтягуємо данні в таблиці по всій ширині
            dataGridViewTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Пошук при натиску на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Find_Click(object sender, EventArgs e)
        {
            searchName = textBox_Find.Text;
            searchName = textBox_Find.Text.Replace("'", "\\'");
            ReloadData();
        }
        /// <summary>
        /// Визов пошуку при натиску на Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Вимикаємо звук
                // Перевіряємо кнопку
                if (ActiveControl == textBox_Find) // Замінюємо textBox_Find на TextBox
                {
                    // Визиваємо кнопку
                    btn_Find.PerformClick(); // Замінюємо button_Search на кнопку
                }
            }
        }
        /// <summary>
        /// Відкритя форми з вставкою елементу до Бази данних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Створення нової форми
            var newForm = new FormInsertArea();
            // Відкриття нової форми як вікно діалога
            newForm.ShowDialog();
            // Коли ця форма закривається, попередня стає активною
            this.Activate();
            ReloadData();
        }
        /// <summary>
        /// Відкритя форми з видаленням елементу з Бази данних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var newForm = new FormDeleteArea();
            newForm.ShowDialog();
            this.Activate();
            ReloadData();
        }
        /// <summary>
        /// Відкриття форми зі змінною данних в таблиці
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var newForm = new FormUpdateArea();
            newForm.ShowDialog();
            this.Activate();
            ReloadData();
        }
    }
}
