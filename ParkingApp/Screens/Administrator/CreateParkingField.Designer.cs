namespace ParkingApp
{
    partial class CreateParkingField
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
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.backToMainAdminScreenBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.leftRadioBtn = new System.Windows.Forms.RadioButton();
            this.rightRadioBtn = new System.Windows.Forms.RadioButton();
            this.downRadioBtn = new System.Windows.Forms.RadioButton();
            this.upRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(160, 61);
            this.widthTextBox.MaxLength = 2;
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 0;
            this.widthTextBox.Text = "10";
            this.widthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validation);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(160, 87);
            this.heightTextBox.MaxLength = 2;
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.Text = "10";
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validation);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(119, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Задайте размер парковки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ширина";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(157, 226);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Создать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backToMainAdminScreenBtn
            // 
            this.backToMainAdminScreenBtn.Location = new System.Drawing.Point(-2, -3);
            this.backToMainAdminScreenBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backToMainAdminScreenBtn.Name = "backToMainAdminScreenBtn";
            this.backToMainAdminScreenBtn.Size = new System.Drawing.Size(28, 22);
            this.backToMainAdminScreenBtn.TabIndex = 19;
            this.backToMainAdminScreenBtn.Text = "<-";
            this.backToMainAdminScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainAdminScreenBtn.Click += new System.EventHandler(this.backToMainAdminScreenBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, -3);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "5x5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Выберите расположение прилегающей дороги";
            // 
            // leftRadioBtn
            // 
            this.leftRadioBtn.AutoSize = true;
            this.leftRadioBtn.Checked = true;
            this.leftRadioBtn.Location = new System.Drawing.Point(98, 173);
            this.leftRadioBtn.Name = "leftRadioBtn";
            this.leftRadioBtn.Size = new System.Drawing.Size(56, 17);
            this.leftRadioBtn.TabIndex = 22;
            this.leftRadioBtn.TabStop = true;
            this.leftRadioBtn.Text = "Слева";
            this.leftRadioBtn.UseVisualStyleBackColor = true;
            // 
            // rightRadioBtn
            // 
            this.rightRadioBtn.AutoSize = true;
            this.rightRadioBtn.Location = new System.Drawing.Point(238, 173);
            this.rightRadioBtn.Name = "rightRadioBtn";
            this.rightRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.rightRadioBtn.TabIndex = 23;
            this.rightRadioBtn.Text = "Справа";
            this.rightRadioBtn.UseVisualStyleBackColor = true;
            // 
            // downRadioBtn
            // 
            this.downRadioBtn.AutoSize = true;
            this.downRadioBtn.Location = new System.Drawing.Point(6, 52);
            this.downRadioBtn.Name = "downRadioBtn";
            this.downRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.downRadioBtn.TabIndex = 24;
            this.downRadioBtn.Text = "Снизу";
            this.downRadioBtn.UseVisualStyleBackColor = true;
            // 
            // upRadioBtn
            // 
            this.upRadioBtn.AutoSize = true;
            this.upRadioBtn.Checked = true;
            this.upRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.upRadioBtn.Name = "upRadioBtn";
            this.upRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.upRadioBtn.TabIndex = 25;
            this.upRadioBtn.TabStop = true;
            this.upRadioBtn.Text = "Сверху";
            this.upRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upRadioBtn);
            this.groupBox1.Controls.Add(this.downRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(160, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 80);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // CreateParkingField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rightRadioBtn);
            this.Controls.Add(this.leftRadioBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToMainAdminScreenBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateParkingField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать пространство парковки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Load += new System.EventHandler(this.CreateParkingField_Load);
            this.Resize += new System.EventHandler(this.preventResize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backToMainAdminScreenBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton leftRadioBtn;
        private System.Windows.Forms.RadioButton rightRadioBtn;
        private System.Windows.Forms.RadioButton downRadioBtn;
        private System.Windows.Forms.RadioButton upRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}