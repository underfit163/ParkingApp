namespace ParkingApp
{
    partial class SignInForm
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backToMainScreenBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordLabel.Location = new System.Drawing.Point(116, 63);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 13);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "Введите пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginLabel.Location = new System.Drawing.Point(116, 24);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(81, 13);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Введите логин";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(80, 77);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.MaxLength = 8;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(80, 38);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.MaxLength = 8;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 20);
            this.loginTextBox.TabIndex = 10;
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(116, 101);
            this.repeatPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.repeatPasswordLabel.TabIndex = 15;
            this.repeatPasswordLabel.Text = "Повторить пароль";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(80, 116);
            this.repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.repeatPasswordTextBox.MaxLength = 8;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(150, 20);
            this.repeatPasswordTextBox.TabIndex = 14;
            this.repeatPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(88, 167);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(131, 27);
            this.SignInButton.TabIndex = 16;
            this.SignInButton.Text = "Зарегистрироваться";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(112, 145);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Text = "Administrator";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // backToMainScreenBtn
            // 
            this.backToMainScreenBtn.Location = new System.Drawing.Point(-5, -4);
            this.backToMainScreenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToMainScreenBtn.Name = "backToMainScreenBtn";
            this.backToMainScreenBtn.Size = new System.Drawing.Size(28, 22);
            this.backToMainScreenBtn.TabIndex = 18;
            this.backToMainScreenBtn.Text = "<-";
            this.backToMainScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainScreenBtn.Click += new System.EventHandler(this.backToMainScreenBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 19;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToMainScreenBtn);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зарегистрироваться";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button backToMainScreenBtn;
        private System.Windows.Forms.Button button1;
    }
}