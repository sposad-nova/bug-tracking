using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bug_tracking_system
{
    class Task
    {
        string name;
        string projeckt;
        string topic;
        string type;
        int priority;
        string user;
        string about;

        DataTable dTable;
        DataTable dTableCB;
        DataTable[] dTableMas = new DataTable[4];
        string message;
        string sqlQuery;
        string id;

        public Task()
        {
        }

        public Task(string _name, string _projeckt, string _topic, string _type, string _user, int _priority, string _about)
        {
            name = _name;
            projeckt = _projeckt;
            topic = _topic;
            type = _type;
            priority = _priority;
            user = _user;
            about = _about;
        }

        public Task(string id)
        {
            this.id = id;
        }


        // Создание новой задачи
        public string creatTask()
        {
            return message = Edit($@"INSERT INTO Tasks(task_name, project, topic, type, user, priority, about) VALUES ('{name}', '{projeckt}', '{topic}', '{type}', '{user}', '{priority}', '{about}')");
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

        //Удаление задачи
        public string deleteTask()
        {
            sqlQuery = "SELECT * FROM Tasks";
            message = Edit($@"DELETE FROM Tasks WHERE id = '{id}'");
            ConnectDb(sqlQuery);
            return message;
        }

        // Создание/обновление Таблицы
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
                command.CommandText = "SELECT * FROM Tasks";
                command.ExecuteNonQuery();
                SQLiteDataAdapter daTs = new SQLiteDataAdapter(command);
                daTs.Fill(dTableCB);
                dTableMas[1] = dTableCB;
                
                DataTable dTablePr = new DataTable();
                command.CommandText = "SELECT * FROM Projects";
                command.ExecuteNonQuery();
                SQLiteDataAdapter daPr = new SQLiteDataAdapter(command);
                daPr.Fill(dTablePr);
                dTableMas[2] = dTablePr;

                DataTable dTableUs = new DataTable();
                command.CommandText = "SELECT * FROM Users";
                command.ExecuteNonQuery();
                SQLiteDataAdapter daUs = new SQLiteDataAdapter(command);
                daUs.Fill(dTableUs);
                dTableMas[3] = dTableUs;

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
