namespace ParkingApp
{
    partial class MainScreenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.administratorBtn = new System.Windows.Forms.Button();
            this.managerBtn = new System.Windows.Forms.Button();
            this.aboutSystemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите режим";
            // 
            // administratorBtn
            // 
            this.administratorBtn.Location = new System.Drawing.Point(189, 81);
            this.administratorBtn.Margin = new System.Windows.Forms.Padding(2);
            this.administratorBtn.Name = "administratorBtn";
            this.administratorBtn.Size = new System.Drawing.Size(125, 40);
            this.administratorBtn.TabIndex = 2;
            this.administratorBtn.Text = "Администратор";
            this.administratorBtn.UseVisualStyleBackColor = true;
            this.administratorBtn.Click += new System.EventHandler(this.administratorBtn_Click);
            // 
            // managerBtn
            // 
            this.managerBtn.Location = new System.Drawing.Point(189, 131);
            this.managerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(125, 40);
            this.managerBtn.TabIndex = 3;
            this.managerBtn.Text = "Управляющий";
            this.managerBtn.UseVisualStyleBackColor = true;
            this.managerBtn.Click += new System.EventHandler(this.managerBtn_Click);
            // 
            // aboutSystemBtn
            // 
            this.aboutSystemBtn.Location = new System.Drawing.Point(8, 8);
            this.aboutSystemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.aboutSystemBtn.Name = "aboutSystemBtn";
            this.aboutSystemBtn.Size = new System.Drawing.Size(75, 20);
            this.aboutSystemBtn.TabIndex = 4;
            this.aboutSystemBtn.Text = "О системе";
            this.aboutSystemBtn.UseVisualStyleBackColor = true;
            this.aboutSystemBtn.Click += new System.EventHandler(this.aboutSystemBtn_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 237);
            this.Controls.Add(this.aboutSystemBtn);
            this.Controls.Add(this.managerBtn);
            this.Controls.Add(this.administratorBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Платная парковка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button administratorBtn;
        private System.Windows.Forms.Button managerBtn;
        private System.Windows.Forms.Button aboutSystemBtn;
    }
}

