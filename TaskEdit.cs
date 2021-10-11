using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bug_tracking_system
{
    public partial class TaskEdit : Form
    {
        DataTable dTable;
        Task task;
        public TaskEdit()
        {
            InitializeComponent();
            CreatTable();

            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (projectComboBox.Items.Count > 0)
            {
                projectComboBox.SelectedIndex = 0;
            }
          
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (typeComboBox.Items.Count > 0)
            {
                typeComboBox.SelectedIndex = 0;
            }
            
            userComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (userComboBox.Items.Count > 0)
            {
                userComboBox.SelectedIndex = 0;
            }

            priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (priorityComboBox.Items.Count > 0)
            {
                priorityComboBox.SelectedIndex = 0;
            }

            comboBoxIdDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBoxIdDelete.Items.Count > 0)
            {
                comboBoxIdDelete.SelectedIndex = 0;
            }
        }

        //Удаление Задачи
        private void deleteTask_Click(object sender, EventArgs e)
        {

            task = new Task(comboBoxIdDelete.Text);
            MessageBox.Show(task.deleteTask());
            CreatTable();
        }

        //Добавление Задачи
        private void creatTask_Click(object sender, EventArgs e)
        {
            task = new Task(nameBox.Text, projectComboBox.Text, topicText.Text, typeComboBox.SelectedItem.ToString(), userComboBox.Text, Convert.ToInt32(priorityComboBox.SelectedItem.ToString()), aboutText.Text);
            MessageBox.Show(task.creatTask());
            CreatTable();
        }

        //Создание Таблицы
        private void CreatTable()
        {
            string sqlQuery = "SELECT * FROM Tasks";
            task = new Task();

            dTable = task.ConnectDb(sqlQuery)[0];

            if (dTable.Columns.Count > 0)
            {
                dataGridView1.Columns.Clear();
                for (int i = 0; i < dTable.Columns.Count; i++)
                    dataGridView1.Columns.Add(dTable.Columns[i].ColumnName, dTable.Columns[i].Caption);

                if (dTable.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Таблица пустая!");
            }
            else
                MessageBox.Show("Таблица пустая!");

            comboBoxIdDelete.DataSource = task.ConnectDb(sqlQuery)[1];
            comboBoxIdDelete.DisplayMember = "id";
            comboBoxIdDelete.ValueMember = "id";
            comboBoxIdDelete.SelectedIndex = -1;

            projectComboBox.DataSource = task.ConnectDb(sqlQuery)[2];
            projectComboBox.DisplayMember = "name_project";
            projectComboBox.ValueMember = "name_project";
            projectComboBox.SelectedIndex = -1;

            userComboBox.DataSource = task.ConnectDb(sqlQuery)[3];
            userComboBox.DisplayMember = "last_name";
            userComboBox.ValueMember = "last_name";
            userComboBox.SelectedIndex = -1;
        }
    }
}
