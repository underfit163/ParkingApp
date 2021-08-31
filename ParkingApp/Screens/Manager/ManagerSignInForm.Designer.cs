namespace ParkingApp
{
    partial class ManagerSignInForm
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
            this.signInLabel = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.backToMainScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signInLabel.Location = new System.Drawing.Point(139, 148);
            this.signInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(81, 13);
            this.signInLabel.TabIndex = 11;
            this.signInLabel.Text = "Нет аккаунта?";
            // 
            // signInBtn
            // 
            this.signInBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signInBtn.Location = new System.Drawing.Point(110, 163);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(2);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(127, 21);
            this.signInBtn.TabIndex = 10;
            this.signInBtn.Text = "Зарегистрироваться";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.passwordLabel.Location = new System.Drawing.Point(139, 69);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(88, 13);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Введите пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginLabel.Location = new System.Drawing.Point(139, 30);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(81, 13);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Введите логин";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(103, 84);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.MaxLength = 8;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "manager";
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validation);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(103, 45);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.MaxLength = 8;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(150, 20);
            this.loginTextBox.TabIndex = 6;
            this.loginTextBox.Text = "manager";
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validation);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(142, 109);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 12;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // backToMainScreenBtn
            // 
            this.backToMainScreenBtn.Location = new System.Drawing.Point(-1, -4);
            this.backToMainScreenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToMainScreenBtn.Name = "backToMainScreenBtn";
            this.backToMainScreenBtn.Size = new System.Drawing.Size(28, 22);
            this.backToMainScreenBtn.TabIndex = 19;
            this.backToMainScreenBtn.Text = "<-";
            this.backToMainScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainScreenBtn.Click += new System.EventHandler(this.backToMainScreenBtn_Click);
            // 
            // ManagerSignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 211);
            this.Controls.Add(this.backToMainScreenBtn);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerSignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Войти";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button backToMainScreenBtn;
    }
}