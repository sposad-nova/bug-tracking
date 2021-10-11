
namespace bug_tracking_system
{
    partial class Seach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fist_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSeach = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.creatTask = new System.Windows.Forms.Button();
            this.creatProjeckt = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.last_name,
            this.fist_name});
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 276);
            this.dataGridView1.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Фамилия";
            this.last_name.Name = "last_name";
            // 
            // fist_name
            // 
            this.fist_name.HeaderText = "Имя";
            this.fist_name.Name = "fist_name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все пользователи",
            "Все проекты",
            "Все задачи в проекте",
            "Все задачи у пользователя"});
            this.comboBox1.Location = new System.Drawing.Point(3, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSeach
            // 
            this.buttonSeach.Location = new System.Drawing.Point(423, 284);
            this.buttonSeach.Name = "buttonSeach";
            this.buttonSeach.Size = new System.Drawing.Size(75, 23);
            this.buttonSeach.TabIndex = 8;
            this.buttonSeach.Text = "Найти";
            this.buttonSeach.UseVisualStyleBackColor = true;
            this.buttonSeach.Click += new System.EventHandler(this.buttonSeach_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 9;
            // 
            // creatTask
            // 
            this.creatTask.Location = new System.Drawing.Point(12, 447);
            this.creatTask.Name = "creatTask";
            this.creatTask.Size = new System.Drawing.Size(91, 23);
            this.creatTask.TabIndex = 10;
            this.creatTask.Text = "Задача";
            this.creatTask.UseVisualStyleBackColor = true;
            this.creatTask.Click += new System.EventHandler(this.creatTask_Click_1);
            // 
            // creatProjeckt
            // 
            this.creatProjeckt.Location = new System.Drawing.Point(12, 418);
            this.creatProjeckt.Name = "creatProjeckt";
            this.creatProjeckt.Size = new System.Drawing.Size(91, 23);
            this.creatProjeckt.TabIndex = 11;
            this.creatProjeckt.Text = "Проект";
            this.creatProjeckt.UseVisualStyleBackColor = true;
            this.creatProjeckt.Click += new System.EventHandler(this.creatProjeckt_Click_1);
            // 
            // editUser
            // 
            this.editUser.Location = new System.Drawing.Point(12, 389);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(91, 23);
            this.editUser.TabIndex = 12;
            this.editUser.Text = "Пользователь";
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Click += new System.EventHandler(this.editUser_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Создать/Удалить";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Seach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creatTask);
            this.Controls.Add(this.creatProjeckt);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSeach);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Seach";
            this.Text = "Seach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fist_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSeach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button creatTask;
        private System.Windows.Forms.Button creatProjeckt;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Label label1;
    }
}