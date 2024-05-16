using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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
        // =======================================================================================
    


        // =======================================================================================
        /// <summary>
        /// Отримання списку товарів по категорії
        /// </summary>
        /// <param name="id_prod_category"></param>
        /// <returns></returns>
        public List<string> GetProductNamesByCategory(int? id_prod_category = null)
        {
            List<string> productNames = new List<string>();

            try
            {
                openConnection();

                string query = "SELECT id, name FROM goods";

                if (id_prod_category != null)
                {
                    query += " WHERE id_prod_category = @category";
                }

                MySqlCommand command = new MySqlCommand(query, sqlConnection);

                if (id_prod_category != null)
                {
                    command.Parameters.AddWithValue("@category", id_prod_category);
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        string formattedName = id + " - " + name;
                        productNames.Add(formattedName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при отриманні списку товарів за категорією: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return productNames;
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
                    // Handle special cases for joining other tables
                    /*if (oldColumnName.StartsWith("id_"))
                    {
                        if (oldColumnName != "id_brigade" || oldColumnName != "id_workcycle")
                        {
                            query += $"{oldColumnName}.name AS `{newColumnName}`, ";
                        }
                        else
                        {
                            query += $"{oldColumnName}.id AS `{newColumnName}`, ";
                        }
                    }
                    else
                    {
                        query += $"g.`{oldColumnName}` AS `{newColumnName}`, ";
                    }*/
                }

                // Remove the trailing comma and space
                query = query.TrimEnd(',', ' ');

                // Add the table name and join statements
                query += $" FROM `{tableName}` g ";

                /*foreach (string oldColumnName in oldColumnNames)
                {
                    if (oldColumnName.StartsWith("id_"))
                    {
                        string referencedTableName = oldColumnName.Substring(3);  // Remove "id_" prefix
                        query += $"LEFT JOIN `{referencedTableName}` ON g.`{oldColumnName}` = `{referencedTableName}`.id ";
                    }
                }*/

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


        // =======================================================================================

        /// <summary>
        /// Отримання назв таблиць з Бази данних
        /// </summary>
        /// <returns></returns>
        public List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();

            try
            {
                openConnection();

                string query = "SHOW TABLES";
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tableName = reader.GetString(0);
                    tableNames.Add(tableName);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Виникла помилка при отриманні назв таблиць: " + ex.Message);
            }
            finally
            {
                closeConnection();
            }

            return tableNames;
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

        public MySqlConnection getConnection()
        {
            return sqlConnection;
        }

        // -------------------------------------------------------

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

        public void DeleteElement(int id, string nameTables)
        {
            try
            {
                openConnection();

                string query = "DELETE FROM " + nameTables + " WHERE id = " + id;
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                //command.Parameters.AddWithValue("@id", id);
                //command.Parameters.AddWithValue("@nameTables", nameTables);

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
                //command.Parameters.AddWithValue("@id", id);
                //command.Parameters.AddWithValue("@nameTable", nameTable);
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
