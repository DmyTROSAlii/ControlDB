using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Tables
    {
        /*private void ReloadData()
        {
            DataBase database = new DataBase();
            valueColumns = (int)nudStr.Value;
            DataTable tableData = database.GetTableData("enterprise", oldColumnNames, newColumNames, valueColumns, searchName);
            dataGridViewTable.DataSource = tableData;
        }*/
        //static string searchName;
       //static int valueColumns;
        //string[] newColumNames = { "id", "Склад", "Постачальник", "Знижка", "Мітка", "Категорія", "Назва", "Опис", "Ціна", "Створено", "Оновлено" };
        //string[] oldColumnNames = { "id", "id_warehouses", "id_prod_suppliers", "id_discounts", "id_tags", "id_prod_category", "name", "description", "price", "created", "renovation" };
        /*public FormGoods()
        {

            DataBase database = new DataBase();
            InitializeComponent();
            KeyPreview = true; // Включаем просмотр клавиш на форме
            KeyDown += FormGoods_KeyDown; // Привязываем обработчик события KeyDown к форме
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelMenu.BackColor = Color.FromArgb(34, 33, 74);
            DataTable tableData = database.GetTableData("goods", oldColumnNames, newColumNames, valueColumns);
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
        }*/
        /// <summary>
        /// Виникає при зміні числа в numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudStr_ValueChanged(object sender, EventArgs e)
        {
            //ReloadData();
        }
        /// <summary>
        /// Відкритя форми з вставкою Товару до Бази данних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new FormInsertEnterprise();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            //this.Activate();
            //ReloadData();
        }
        /// <summary>
        /// Пошук при натиску на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Find_Click(object sender, EventArgs e)
        {
            //searchName = textBox_Find.Text;
            //searchName = textBox_Find.Text.Replace("'", "\\'");
            //ReloadData();
        }
        /// <summary>
        /// Визов пошуку при натиску на Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /* private void FormGoods_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Предотвращаем воспроизведение системного звука
                // Проверяем, какая кнопка должна быть вызвана
                if (ActiveControl == textBox_Find) // Замените textBox_Find на ваш TextBox
                {
                    // Вызываем определенную кнопку
                    btn_Find.PerformClick(); // Замените button_Search на вашу кнопку
                }
            }
        }*/
        /// <summary>
        /// Відкритя форми з видаленням Товару з Бази данних
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            var newForm = new FormDeleteEnterprise();

            // Открытие новой формы как модального диалога
            newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            // this.Activate();
            //ReloadData();
        }
        /// <summary>
        /// Відкриття форми зі змінною данних в таблиці
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            // Создание новой формы
            //var newForm = new FormUpdateEnterprise();

            // Открытие новой формы как модального диалога
            //newForm.ShowDialog();
            // Когда новая форма закрывается, предыдущая форма становится активной снова
            // this.Activate();
            //ReloadData();
        }

        // Get sql data from base
        /*List<string> warehouseNames = database.GetWarehouseNames();
            List<string> prodSupplierNames = database.GetSupplierNames();
            List<string> activeDiscounts = database.GetActiveDiscounts();
            List<string> tagNames = database.GetTagNames();
            List<string> categoryNames = database.GetCategoryNames();
            comboBox_warehouses.DataSource = warehouseNames;
            comboBox_prod_suppliers.DataSource = prodSupplierNames;
            comboBox_discounts.DataSource = activeDiscounts;
            comboBox_tags.DataSource = tagNames;
            comboBox_prod_category.DataSource = categoryNames;
            List<string> idEnterprise = database;*/

        // Get data from combobox
        // int IndexShift = 1; // Погрешность +1 к index в базе данных
        /*int id_warehouses = comboBox_warehouses.SelectedIndex;
        int id_prod_suppliers = comboBox_prod_suppliers.SelectedIndex;
        int id_discounts = comboBox_discounts.SelectedIndex;
        int id_tags = comboBox_tags.SelectedIndex;
        int id_prod_category = comboBox_prod_category.SelectedIndex;*/


        // Update element file
        // string selectedValue = comboBox_NameGoods.SelectedItem.ToString();
        /*string[] parts = selectedValue.Split('-');

        if (parts.Length == 2)
        {
            int productId;
            if (int.TryParse(parts[0].Trim(), out productId))
            {
                string productName = parts[1].Trim();*/

        //DialogResult result = MessageBox.Show("Дійсно ви хочете змінити товар - " + productName + "?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //if (result == DialogResult.Yes)

        /*int IndexShift = 1; // Погрешность +1 к index в базе данных
        int id_warehouses = comboBox_warehouses.SelectedIndex;
        int id_prod_suppliers = comboBox_prod_suppliers.SelectedIndex;
        int id_discounts = comboBox_discounts.SelectedIndex;
        int id_tags = comboBox_tags.SelectedIndex;
        int id_prod_category = comboBox_prod_category.SelectedIndex;
        string name = textBox_Name.Text;
        List<string> goodNames = database.GetGoodNames();
            string description = textBox_Description.Text;
            decimal price;
            if (decimal.TryParse(textBox_Price.Text, out price) && price > 0)
            {
                database.UpdateGoods(productId, id_warehouses + IndexShift, id_prod_suppliers + IndexShift, id_discounts + IndexShift, id_tags + IndexShift, id_prod_category + IndexShift, name, description, price);
                MessageBox.Show("Товар успішно змінено.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Виникла помилка. Ціна повинна мати число більше нуля.");
            }
    */


        //}
        /// <summary>
        /// Зміна категорії пошуку товару
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_category.SelectedIndex > 0)
            {
                goodsNames = database.GetProductNamesByCategory(comboBox_category.SelectedIndex);
                comboBox_NameGoods.DataSource = goodsNames;
            }
            else
            {
                goodsNames = database.GetProductNamesByCategory();
                comboBox_NameGoods.DataSource = goodsNames;
            }
        }*/



        // If Unique Value in Table
        /*if (names.Contains(name))
           {
               MessageBox.Show("Помилка: Товар із таким ім'ям уже існує.");
           }
           else
           {

           }*/
    }
}
