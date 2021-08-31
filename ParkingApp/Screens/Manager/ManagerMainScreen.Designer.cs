namespace ParkingApp
{
    partial class ManagerMainScreen
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
            this.backToMainScreenBtn = new System.Windows.Forms.Button();
            this.startModelingBtn = new System.Windows.Forms.Button();
            this.configureModellingParamsBtn = new System.Windows.Forms.Button();
            this.loadparkingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMainScreenBtn
            // 
            this.backToMainScreenBtn.Location = new System.Drawing.Point(-2, -4);
            this.backToMainScreenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToMainScreenBtn.Name = "backToMainScreenBtn";
            this.backToMainScreenBtn.Size = new System.Drawing.Size(139, 22);
            this.backToMainScreenBtn.TabIndex = 20;
            this.backToMainScreenBtn.Text = "Сменить пользователя";
            this.backToMainScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainScreenBtn.Click += new System.EventHandler(this.backToMainScreenBtn_Click);
            // 
            // startModelingBtn
            // 
            this.startModelingBtn.Location = new System.Drawing.Point(127, 34);
            this.startModelingBtn.Name = "startModelingBtn";
            this.startModelingBtn.Size = new System.Drawing.Size(181, 52);
            this.startModelingBtn.TabIndex = 21;
            this.startModelingBtn.Text = "Запустить моделирование";
            this.startModelingBtn.UseVisualStyleBackColor = true;
            this.startModelingBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // configureModellingParamsBtn
            // 
            this.configureModellingParamsBtn.Location = new System.Drawing.Point(127, 92);
            this.configureModellingParamsBtn.Name = "configureModellingParamsBtn";
            this.configureModellingParamsBtn.Size = new System.Drawing.Size(181, 52);
            this.configureModellingParamsBtn.TabIndex = 22;
            this.configureModellingParamsBtn.Text = "Настроить параметры моделирования";
            this.configureModellingParamsBtn.UseVisualStyleBackColor = true;
            this.configureModellingParamsBtn.Click += new System.EventHandler(this.configureModellingParamsBtn_Click);
            // 
            // loadparkingBtn
            // 
            this.loadparkingBtn.Location = new System.Drawing.Point(127, 150);
            this.loadparkingBtn.Name = "loadparkingBtn";
            this.loadparkingBtn.Size = new System.Drawing.Size(181, 52);
            this.loadparkingBtn.TabIndex = 23;
            this.loadparkingBtn.Text = "Загрузить парковку";
            this.loadparkingBtn.UseVisualStyleBackColor = true;
            this.loadparkingBtn.Click += new System.EventHandler(this.loadparkingBtn_Click);
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 224);
            this.Controls.Add(this.loadparkingBtn);
            this.Controls.Add(this.configureModellingParamsBtn);
            this.Controls.Add(this.startModelingBtn);
            this.Controls.Add(this.backToMainScreenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManagerMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню управляющего";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainScreenBtn;
        private System.Windows.Forms.Button startModelingBtn;
        private System.Windows.Forms.Button configureModellingParamsBtn;
        private System.Windows.Forms.Button loadparkingBtn;
    }
}