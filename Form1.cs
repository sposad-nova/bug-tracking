using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.Data.Common;
using System.Data.SqlClient;
using NLog;

namespace bug_tracking_system
{
    public partial class Form1 : Form
    {
        public static string baseAddress;
        public static Logger log;

        public Form1()
        {
            InitializeComponent();
            try
            {
                log = LogManager.GetCurrentClassLogger();

                log.Trace("Version: {0}", Environment.Version.ToString());
                log.Trace("OS: {0}", Environment.OSVersion.ToString());
                log.Trace("Command: {0}", Environment.CommandLine.ToString());

                NLog.Targets.FileTarget tar = (NLog.Targets.FileTarget)LogManager.Configuration.FindTargetByName("run_log");
                tar.DeleteOldFileOnStartup = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка работы с логом!n" + e.Message);
            }

            // ловим все не обработанные исключения
            //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_Exception);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }

        private void openDb_Click(object sender, EventArgs e)
        {

            // Открытие файла
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                   baseAddress = openFileDialog1.FileName;
                   var connection = new SqliteConnection("Data Source=" + baseAddress + ";" + " Mode=ReadWrite");
                   connection.Open();
                    Seach seach = new Seach();
                    seach.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error:{ " + ex.Message);
                }
            }
        }

        private void creatDB_Click(object sender, EventArgs e)
        {
            // Создаем БД
            DataTable dTable = new DataTable();
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;


            //Подключаемся к созданой БД и создаем таблицы
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    baseAddress = saveFileDialog1.FileName;
                }

                var connection = new SQLiteConnection("Data Source=" + baseAddress + ";" + " Mode=ReadWriteCreate;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE Users(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, last_name TEXT NOT NULL, fist_name TEXT NOT NULL)";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE Projects(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, name_project TEXT NOT NULL, city TEXT NOT NULL)";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE Tasks(id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, task_name TEXT NOT NULL, project TEXT NOT NULL, topic TEXT(100) NOT NULL, type TEXT(100) NOT NULL, user TEXT NOT NULL, priority INTEGER NOT NULL, about TEXT)";
                command.ExecuteNonQuery();             
                connection.Close();
                MessageBox.Show("База данных создана!");

            }


            Seach seach = new Seach();
            seach.Show();

        }
    }
}

        

