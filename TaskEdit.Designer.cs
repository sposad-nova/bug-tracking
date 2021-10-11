
namespace bug_tracking_system
{
    partial class TaskEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.topicText = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.aboutText = new System.Windows.Forms.TextBox();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.creatTask = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteTask = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxIdDelete = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проект";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тема";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Приоритет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Исполнитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Описание";
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(105, 33);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(121, 21);
            this.projectComboBox.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(105, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 20);
            this.nameBox.TabIndex = 9;
            // 
            // topicText
            // 
            this.topicText.Location = new System.Drawing.Point(105, 66);
            this.topicText.Name = "topicText";
            this.topicText.Size = new System.Drawing.Size(121, 20);
            this.topicText.TabIndex = 10;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Задача",
            "Ошибка"});
            this.typeComboBox.Location = new System.Drawing.Point(105, 93);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 11;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.priorityComboBox.Location = new System.Drawing.Point(105, 159);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(121, 21);
            this.priorityComboBox.TabIndex = 12;
            // 
            // aboutText
            // 
            this.aboutText.Location = new System.Drawing.Point(75, 239);
            this.aboutText.Multiline = true;
            this.aboutText.Name = "aboutText";
            this.aboutText.Size = new System.Drawing.Size(151, 121);
            this.aboutText.TabIndex = 13;
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(105, 123);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(121, 21);
            this.userComboBox.TabIndex = 14;
            // 
            // creatTask
            // 
            this.creatTask.Location = new System.Drawing.Point(151, 376);
            this.creatTask.Name = "creatTask";
            this.creatTask.Size = new System.Drawing.Size(75, 23);
            this.creatTask.TabIndex = 15;
            this.creatTask.Text = "Создать";
            this.creatTask.UseVisualStyleBackColor = true;
            this.creatTask.Click += new System.EventHandler(this.creatTask_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "(от 1 до 5, где 1 самый низкий, \r\n5 самый высокий)";
            // 
            // deleteTask
            // 
            this.deleteTask.Location = new System.Drawing.Point(506, 258);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(75, 23);
            this.deleteTask.TabIndex = 18;
            this.deleteTask.Text = "Удалить";
            this.deleteTask.UseVisualStyleBackColor = true;
            this.deleteTask.Click += new System.EventHandler(this.deleteTask_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 213);
            this.dataGridView1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(294, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Удалить задачу id = ";
            // 
            // comboBoxIdDelete
            // 
            this.comboBoxIdDelete.FormattingEnabled = true;
            this.comboBoxIdDelete.Location = new System.Drawing.Point(456, 258);
            this.comboBoxIdDelete.Name = "comboBoxIdDelete";
            this.comboBoxIdDelete.Size = new System.Drawing.Size(44, 21);
            this.comboBoxIdDelete.TabIndex = 21;
            // 
            // TaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 533);
            this.Controls.Add(this.comboBoxIdDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteTask);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.creatTask);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.aboutText);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.topicText);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskEdit";
            this.Text = "TaskEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox topicText;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.TextBox aboutText;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Button creatTask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteTask;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxIdDelete;
    }
}