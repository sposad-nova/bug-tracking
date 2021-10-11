
namespace bug_tracking_system
{
    partial class UserEdit
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
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fistNameText = new System.Windows.Forms.TextBox();
            this.creatUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxIdDelete = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(87, 12);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // fistNameText
            // 
            this.fistNameText.Location = new System.Drawing.Point(87, 38);
            this.fistNameText.Name = "fistNameText";
            this.fistNameText.Size = new System.Drawing.Size(100, 20);
            this.fistNameText.TabIndex = 3;
            // 
            // creatUser
            // 
            this.creatUser.Location = new System.Drawing.Point(112, 74);
            this.creatUser.Name = "creatUser";
            this.creatUser.Size = new System.Drawing.Size(75, 23);
            this.creatUser.TabIndex = 6;
            this.creatUser.Text = "Создать";
            this.creatUser.UseVisualStyleBackColor = true;
            this.creatUser.Click += new System.EventHandler(this.creatUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(376, 189);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(75, 23);
            this.deleteUser.TabIndex = 8;
            this.deleteUser.Text = "Удалить";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 171);
            this.dataGridView1.TabIndex = 9;
            // 
            // comboBoxIdDelete
            // 
            this.comboBoxIdDelete.FormattingEnabled = true;
            this.comboBoxIdDelete.Location = new System.Drawing.Point(325, 189);
            this.comboBoxIdDelete.Name = "comboBoxIdDelete";
            this.comboBoxIdDelete.Size = new System.Drawing.Size(44, 21);
            this.comboBoxIdDelete.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(71, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Удалить пользователя под id = ";
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 258);
            this.Controls.Add(this.comboBoxIdDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.creatUser);
            this.Controls.Add(this.fistNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameText);
            this.Name = "UserEdit";
            this.Text = "UserEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fistNameText;
        private System.Windows.Forms.Button creatUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxIdDelete;
        private System.Windows.Forms.Label label9;
    }
}