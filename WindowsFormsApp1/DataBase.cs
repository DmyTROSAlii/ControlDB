using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    class DataBase
{
        static string mySqlconnection = "server=localhost; user=root; database=db_lab; password=2s0s0s4s";
        MySqlConnection sqlConnection = new MySqlConnection(mySqlconnection);
        /// <summary>
        /// Відкитя підключення к базі даних
        /// </summary>
        public void openConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        /// <summary>
        /// Закритя підключення к базі даних
        /// </summary>
        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// Отримання поля з використанням підлкюченя до БД
        /// </summary>
        public MySqlConnection getConnection()
        {
            return sqlConnection;
        }
        // =======================================================================================
        /// <summary>
        /// Вивод таблиць на DataGridView
        /// </summary>
        /// <param name="tableName">Назва таблицы</param>
        /// <param name="oldColumnNames">Старі назви колонок</param>
        /// <param name="newColumnNames">Нові назви колонок</param>
        /// <param name="numRows">Кількість строк що треба вивести</param>
        /// <returns></returns>
        public DataTable GetTableData(string tableName, string[] oldColumnNames, string[] newColumnNames, int numRows = -1, string searchName = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                openConnection();

                string query = "SELECT ";

                for (int i = 0; i < oldColumnNames.Length; i++)
                {
                    string oldColumnName = oldColumnNames[i];
                    string newColumnName = newColumnNames[i];
                    query += $"{oldColumnName} AS `{newColumnName}`, ";
                }

                // Remove the trailing comma and space
                query = query.TrimEnd(',', ' ');

                // Add the table name and join statements
                query += $" FROM `{tableName}` g ";

                if (!string.IsNullOrEmpty(searchName))
                {
                    // Add the WHERE clause to filter by similar name
                    query += $"WHERE g.name LIKE '%{searchName}%' ";
                }

                if (numRows > 0)
                {
                    query += $"LIMIT {numRows}";
                }

                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                adapter.Fill(dataTable);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Виникла помилка при отриманні даних з бази даних: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return dataTable;
        }
        // =======================================================================================
        /// <summary>
        /// Отримання id, який не зайнятий для вставки нового елементу
        /// </summary>
        /// <param name="nameTable"></param>
        /// <returns>id + 1</returns>
        public int getIDFromTable(string nameTable)
        {
            string query = "SELECT COUNT(*) FROM " + nameTable;
            int id = 0;

            try
            {
                openConnection();
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Console.WriteLine(reader);
                    id = reader.GetInt32(0);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Виникла помилка при отриманні id: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return id + 1;
        }
        /// <summary>
        /// Додавання нового елементу до таблиці
        /// </summary>
        /// <param name="nameTable"></param>
        /// <param name="columnsName"></param>
        /// <param name="columnsValue"></param>
        public void AddElement(string nameTable, string[] columnsName, string[] columnsValue)
        {
            try
            {
                openConnection();
                string nameCol = string.Join(", ", columnsName);
                string valueCol = string.Join(", ", columnsName.Select(name => "@" + name));

                string query = $"INSERT INTO {nameTable} ({nameCol}) VALUES ({valueCol})";

                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                for (int i = 0; i < columnsName.Length; i++)
                {
                    command.Parameters.AddWithValue("@" + columnsName[i], columnsValue[i]);
                }

                command.ExecuteNonQuery();
                MessageBox.Show("Товар успішно додано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при додаванні елемента в таблицю': " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        /// <summary>
        /// Видалення елементу з таблиці по id 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameTables"></param>
        public void DeleteElement(int id, string nameTables)
        {
            try
            {
                openConnection();

                string query = "DELETE FROM " + nameTables + " WHERE id = " + id;
                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Товар успішно видалено.");
                }
                else
                {
                    MessageBox.Show("Товар з вказаним ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні товару: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        /// <summary>
        /// Редагування елементу з таблиці по id 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameTable"></param>
        /// <param name="columnsName"></param>
        /// <param name="columnsValue"></param>
        public void UpdateElement(int id, string nameTable, string[] columnsName, string[] columnsValue)
        {
            try
            {
                openConnection();

                string query = "UPDATE " + nameTable + " SET ";
                for (int i = 0; i < columnsName.Length; i++)
                {
                    query += columnsName[i] + " = @" + columnsName[i] + ", ";
                }
                query = query.Remove(query.Length - 2);
                query += " WHERE id = " + id;

                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                for (int i = 0; i < columnsName.Length; i++)
                {
                    command.Parameters.AddWithValue("@" + columnsName[i], columnsValue[i]);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при змінні даних в таблиці: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
