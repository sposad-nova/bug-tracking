using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bug_tracking_system
{
    class User
    {
        string lastName;
        string fistName;
        string message;
        string sqlQuery;
        int id;
        DataTable dTable;
        DataTable dTableCB;
        DataTable[] dTableMas = new DataTable[2];

        public User()
        {
        }
        public User(string lastName, string fistName)
        {
            this.lastName = lastName;
            this.fistName = fistName;
        }
        public User(string id)
        {
            if(id != "")
                this.id = Convert.ToInt32(id);
        }

        // Создание нового пользователя
        public string creatUser()
        {
           return message = Edit($@"INSERT INTO Users(last_name, fist_name) VALUES ('{lastName}', '{fistName}')");
        }

        // Удаление пользователя
        public string deleteUser()
        {

            sqlQuery = $@"SELECT last_name FROM Users WHERE id = '{id}'";

            var connection = new SQLiteConnection("Data Source=" + Form1.baseAddress + ";" + " Mode=ReadWriteCreate;");
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = sqlQuery;
            SQLiteDataReader reader = command.ExecuteReader();
            string str = "";

            while (reader.Read())
            {
                str = String.Format("{0}", reader[0]);
            }

            connection.Close();

            Edit($@"DELETE FROM Tasks WHERE user = '{str}'");

            sqlQuery = "SELECT * FROM Users";
            message = Edit($@"DELETE FROM Users WHERE id = '{id}'");
            ConnectDb(sqlQuery);
            return message;
        }


        // Внесение изменений в Таблицу
        private string Edit(string sqlQuery)
        { 
            try
            {
                var connection = new SQLiteConnection("Data Source=" + Form1.baseAddress + ";" + " Mode=ReadWriteCreate;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                connection.Close();
                return message = "Изменения внесены успешно!";
            }
            catch (SQLiteException ex)
            {
                return message = "Error: " + ex.Message;
            }
        }


        //Создание/обновление Таблицы
        public DataTable [] ConnectDb(string sqlQuery)
        {
            try
            {
                dTable = new DataTable();
                var connection = new SQLiteConnection("Data Source=" + Form1.baseAddress + ";" + " Mode=ReadWrite;");
                connection.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                dTableMas[0] = dTable;

                SQLiteCommand command = connection.CreateCommand();
                dTableCB = new DataTable();
                command.CommandText = "SELECT * FROM Users";
                command.ExecuteNonQuery();
                SQLiteDataAdapter daTs = new SQLiteDataAdapter(command);
                daTs.Fill(dTableCB);
                dTableMas[1] = dTableCB;
                connection.Close();
                return dTableMas;
            }
            catch (SQLiteException ex)
            {
                dTable.Rows.Add("Error: " + ex.Message);
                return dTableMas;
            }
        }
    }
}
