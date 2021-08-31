namespace ParkingApp
{
    partial class AdministratorSignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorSignInForm));
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.signInLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.backToMainScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            resources.ApplyResources(this.loginTextBox, "loginTextBox");
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validation);
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validation);
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.Name = "loginLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // signInBtn
            // 
            resources.ApplyResources(this.signInBtn, "signInBtn");
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // signInLabel
            // 
            resources.ApplyResources(this.signInLabel, "signInLabel");
            this.signInLabel.Name = "signInLabel";
            // 
            // enterButton
            // 
            resources.ApplyResources(this.enterButton, "enterButton");
            this.enterButton.Name = "enterButton";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // backToMainScreenBtn
            // 
            resources.ApplyResources(this.backToMainScreenBtn, "backToMainScreenBtn");
            this.backToMainScreenBtn.Name = "backToMainScreenBtn";
            this.backToMainScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainScreenBtn.Click += new System.EventHandler(this.backToMainScreenBtn_Click);
            // 
            // AdministratorSignInForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backToMainScreenBtn);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministratorSignInForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label signInLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button backToMainScreenBtn;
    }
}