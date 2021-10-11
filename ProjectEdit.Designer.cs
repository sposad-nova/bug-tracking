
namespace bug_tracking_system
{
    partial class ProjectEdit
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
            this.nameProjectText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.creatProject = new System.Windows.Forms.Button();
            this.deleteProject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxIdDelete = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город";
            // 
            // nameProjectText
            // 
            this.nameProjectText.Location = new System.Drawing.Point(140, 21);
            this.nameProjectText.Name = "nameProjectText";
            this.nameProjectText.Size = new System.Drawing.Size(100, 20);
            this.nameProjectText.TabIndex = 2;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(140, 44);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 20);
            this.cityText.TabIndex = 3;
            // 
            // creatProject
            // 
            this.creatProject.Location = new System.Drawing.Point(165, 70);
            this.creatProject.Name = "creatProject";
            this.creatProject.Size = new System.Drawing.Size(75, 23);
            this.creatProject.TabIndex = 4;
            this.creatProject.Text = "Создать";
            this.creatProject.UseVisualStyleBackColor = true;
            this.creatProject.Click += new System.EventHandler(this.creatProject_Click);
            // 
            // deleteProject
            // 
            this.deleteProject.Location = new System.Drawing.Point(482, 251);
            this.deleteProject.Name = "deleteProject";
            this.deleteProject.Size = new System.Drawing.Size(75, 23);
            this.deleteProject.TabIndex = 6;
            this.deleteProject.Text = "Удалить";
            this.deleteProject.UseVisualStyleBackColor = true;
            this.deleteProject.Click += new System.EventHandler(this.deleteProject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(246, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 171);
            this.dataGridView1.TabIndex = 10;
            // 
            // comboBoxIdDelete
            // 
            this.comboBoxIdDelete.FormattingEnabled = true;
            this.comboBoxIdDelete.Location = new System.Drawing.Point(513, 214);
            this.comboBoxIdDelete.Name = "comboBoxIdDelete";
            this.comboBoxIdDelete.Size = new System.Drawing.Size(44, 21);
            this.comboBoxIdDelete.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(295, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Удалить проект под id = ";
            // 
            // ProjectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 294);
            this.Controls.Add(this.comboBoxIdDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteProject);
            this.Controls.Add(this.creatProject);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.nameProjectText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjectEdit";
            this.Text = "ProjectEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameProjectText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Button creatProject;
        private System.Windows.Forms.Button deleteProject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxIdDelete;
        private System.Windows.Forms.Label label9;
    }
}