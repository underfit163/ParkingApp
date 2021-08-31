namespace ParkingApp
{
    partial class AdministratorMainScreen
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
            this.createBtn = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.configureTariff = new System.Windows.Forms.Button();
            this.backToMainScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(140, 32);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(140, 32);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Создать/Редактировать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(140, 70);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(140, 32);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // configureTariff
            // 
            this.configureTariff.Location = new System.Drawing.Point(140, 108);
            this.configureTariff.Name = "configureTariff";
            this.configureTariff.Size = new System.Drawing.Size(140, 32);
            this.configureTariff.TabIndex = 2;
            this.configureTariff.Text = "Настроить тариф";
            this.configureTariff.UseVisualStyleBackColor = true;
            this.configureTariff.Click += new System.EventHandler(this.configureTariff_Click);
            // 
            // backToMainScreenBtn
            // 
            this.backToMainScreenBtn.Location = new System.Drawing.Point(-3, -3);
            this.backToMainScreenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToMainScreenBtn.Name = "backToMainScreenBtn";
            this.backToMainScreenBtn.Size = new System.Drawing.Size(139, 22);
            this.backToMainScreenBtn.TabIndex = 19;
            this.backToMainScreenBtn.Text = "Сменить пользователя";
            this.backToMainScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainScreenBtn.Click += new System.EventHandler(this.backToMainScreenBtn_Click);
            // 
            // AdministratorMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 180);
            this.Controls.Add(this.backToMainScreenBtn);
            this.Controls.Add(this.configureTariff);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.createBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministratorMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button configureTariff;
        private System.Windows.Forms.Button backToMainScreenBtn;
    }
}