
namespace ParkingApp.Screens
{
    partial class AboutSystemForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.backToMainScreenBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "Открыть сайт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backToMainScreenBtn
            // 
            this.backToMainScreenBtn.Location = new System.Drawing.Point(-3, -2);
            this.backToMainScreenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToMainScreenBtn.Name = "backToMainScreenBtn";
            this.backToMainScreenBtn.Size = new System.Drawing.Size(28, 22);
            this.backToMainScreenBtn.TabIndex = 27;
            this.backToMainScreenBtn.Text = "<-";
            this.backToMainScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainScreenBtn.Click += new System.EventHandler(this.backToMainScreenBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Самара 2020г.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Разработчики - студенты группы 6403: Тышкун Андрей, Власов Георгий, Киселева Снеж" +
    "ана.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Тема проекта: “Система моделирования работы платной парковки”.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Лабораторный практикум по дисциплине: \"Технологии программирования\".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Самарский университет";
            // 
            // AboutSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToMainScreenBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AboutSystemForm";
            this.Text = "AboutSystemForm";
            this.ResizeBegin += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backToMainScreenBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}