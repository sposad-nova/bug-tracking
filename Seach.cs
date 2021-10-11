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
    public partial class Seach : Form
    {
        string sqlQuery;
        IntemList intemList;
        public Seach()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intem = comboBox1.SelectedIndex;
            intemList = new IntemList(intem, textBox1.Text);
            sqlQuery = intemList.Add();
        }

        private void buttonSeach_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            intemList = new IntemList(comboBox1.SelectedIndex, textBox1.Text);
            sqlQuery = intemList.Add();

            try
            {
                var connection = new SQLiteConnection("Data Source=" + Form1.baseAddress + ";" + " Mode=ReadWriteCreate;");
                connection.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);


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
                        dataGridView1.Columns.RemoveAt(0);
                    }
                    else
                        MessageBox.Show("Database is empty");
                }
                else
                    MessageBox.Show("Database is empty");
                connection.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editUser_Click_1(object sender, EventArgs e)
        {
            if (Form1.baseAddress != null)
            {
                UserEdit userEdit = new UserEdit();
                userEdit.Show();
            }
            else
                MessageBox.Show("Откройте или создайте БД");
        }

        private void creatTask_Click_1(object sender, EventArgs e)
        {
            if (Form1.baseAddress != null)
            {
                TaskEdit taskEdit = new TaskEdit();
                taskEdit.Show();
            }
            else
                MessageBox.Show("Откройте или создайте БД");
        }

        private void creatProjeckt_Click_1(object sender, EventArgs e)
        {
            if (Form1.baseAddress != null)
            {
                ProjectEdit projectEdit = new ProjectEdit();
                projectEdit.Show();
            }
            else
                MessageBox.Show("Откройте или создайте БД");
        }
    }
}
