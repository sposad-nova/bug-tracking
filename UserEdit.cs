using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace bug_tracking_system
{
    public partial class UserEdit : Form
    {
        
        DataTable dTable;
        User user;

        public UserEdit()
        {
            Form1.log.Trace("run {0}", this.Text);
            InitializeComponent();
            CreatTable();
            comboBoxIdDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            if(comboBoxIdDelete.Items.Count > 0)
            {
                comboBoxIdDelete.SelectedIndex = 0;
            }
            
        }


        // Создание нового пользователя
        private void creatUser_Click(object sender, EventArgs e)
        {
            user = new User(lastNameText.Text, fistNameText.Text);
            MessageBox.Show(user.creatUser());
            CreatTable();
        }

       // Удаление пользователя
        private void deleteUser_Click(object sender, EventArgs e)
        {
            user = new User(comboBoxIdDelete.Text);
            MessageBox.Show(user.deleteUser());
            CreatTable();
        }

        //Создание/обновление Таблицы
        private void CreatTable()
        {
            string sqlQuery = "SELECT * FROM Users";
            user = new User();
            dTable = user.ConnectDb(sqlQuery)[0];

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

            comboBoxIdDelete.DataSource = user.ConnectDb(sqlQuery)[1];
            comboBoxIdDelete.DisplayMember = "id";
            comboBoxIdDelete.ValueMember = "id";
            comboBoxIdDelete.SelectedIndex = -1;
        }
    }
}
