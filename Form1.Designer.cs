
namespace bug_tracking_system
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openDb = new System.Windows.Forms.Button();
            this.creatDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openDb
            // 
            this.openDb.Location = new System.Drawing.Point(26, 12);
            this.openDb.Name = "openDb";
            this.openDb.Size = new System.Drawing.Size(221, 54);
            this.openDb.TabIndex = 2;
            this.openDb.Text = "Открыть\r\nбазу данных";
            this.openDb.UseVisualStyleBackColor = true;
            this.openDb.Click += new System.EventHandler(this.openDb_Click);
            // 
            // creatDB
            // 
            this.creatDB.Location = new System.Drawing.Point(26, 72);
            this.creatDB.Name = "creatDB";
            this.creatDB.Size = new System.Drawing.Size(221, 61);
            this.creatDB.TabIndex = 3;
            this.creatDB.Text = "Создать\r\nбазу данных";
            this.creatDB.UseVisualStyleBackColor = true;
            this.creatDB.Click += new System.EventHandler(this.creatDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 155);
            this.Controls.Add(this.creatDB);
            this.Controls.Add(this.openDb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openDb;
        private System.Windows.Forms.Button creatDB;
    }
}

