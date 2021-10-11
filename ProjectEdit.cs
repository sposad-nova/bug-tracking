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
    public partial class ProjectEdit : Form
    {
        DataTable dTable;
        Project project;
        public ProjectEdit()
        {
            InitializeComponent();
            CreatTable();
            comboBoxIdDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            if (comboBoxIdDelete.Items.Count > 0)
            {
                comboBoxIdDelete.SelectedIndex = 0;
            }
        }

        private void creatProject_Click(object sender, EventArgs e)
        {
            project = new Project(nameProjectText.Text, cityText.Text);
            MessageBox.Show(project.creatProject());
            CreatTable();
        }

        private void deleteProject_Click(object sender, EventArgs e)
        {
            project = new Project(comboBoxIdDelete.Text);
            MessageBox.Show(project.deleteProject());
            CreatTable();
        }

        private void CreatTable()
        {
            string sqlQuery = "SELECT * FROM Projects";
            project = new Project();

            dTable = project.ConnectDb(sqlQuery)[0];

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

            comboBoxIdDelete.DataSource = project.ConnectDb(sqlQuery)[1];
            comboBoxIdDelete.DisplayMember = "id";
            comboBoxIdDelete.ValueMember = "id";
            comboBoxIdDelete.SelectedIndex = -1;
        }

    }
}
