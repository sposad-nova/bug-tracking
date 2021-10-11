using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bug_tracking_system
{
    class Project
    {
        string nameProject;
        string city;
        string message;
        string sqlQuery;
        int id;
        DataTable dTable;
        DataTable dTableCB;
        DataTable[] dTableMas = new DataTable[2];

        public Project()
        {
        }

        public Project(string nameProject, string city)
        {
            this.nameProject = nameProject;
            this.city = city;
        }

        public Project(string id)
        {
            if(id != "")
            {
                this.id = Convert.ToInt32(id);
            }
            
        }

        //Создание/обновление Таблицы
        public DataTable[] ConnectDb(string sqlQuery)
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
                command.CommandText = "SELECT * FROM Projects";
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

        // Создание проекта
        public string creatProject()
        {
            return message = Edit($@"INSERT INTO Projects(name_project, city) VALUES ('{nameProject}', '{city}')");
        }


        // Удаление проекта
        public string deleteProject()
        {
            sqlQuery = $@"SELECT name_project FROM Projects WHERE id = '{id}'";

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

            Edit($@"DELETE FROM Tasks WHERE project = '{str}'");

            message = Edit($@"DELETE FROM Projects WHERE id = '{id}'");
            ConnectDb(sqlQuery);
            return message;
        }



    }
}
