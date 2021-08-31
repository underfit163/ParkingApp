namespace ParkingApp
{
    partial class ConfigureTarifForm
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
            this.label = new System.Windows.Forms.Label();
            this.dayRateRadioBtn = new System.Windows.Forms.RadioButton();
            this.hourlyRateRadioBtn = new System.Windows.Forms.RadioButton();
            this.carPriceField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveAndForwardBtn = new System.Windows.Forms.Button();
            this.backToMainAdminScreenBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(66, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(153, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Как будет взиматься плата?";
            // 
            // dayRateRadioBtn
            // 
            this.dayRateRadioBtn.AutoSize = true;
            this.dayRateRadioBtn.Checked = true;
            this.dayRateRadioBtn.Location = new System.Drawing.Point(83, 38);
            this.dayRateRadioBtn.Name = "dayRateRadioBtn";
            this.dayRateRadioBtn.Size = new System.Drawing.Size(133, 17);
            this.dayRateRadioBtn.TabIndex = 1;
            this.dayRateRadioBtn.TabStop = true;
            this.dayRateRadioBtn.Text = "По суточному тарифу";
            this.dayRateRadioBtn.UseVisualStyleBackColor = true;
            this.dayRateRadioBtn.Click += new System.EventHandler(this.clickRadioBtn);
            // 
            // hourlyRateRadioBtn
            // 
            this.hourlyRateRadioBtn.AutoSize = true;
            this.hourlyRateRadioBtn.Location = new System.Drawing.Point(83, 60);
            this.hourlyRateRadioBtn.Name = "hourlyRateRadioBtn";
            this.hourlyRateRadioBtn.Size = new System.Drawing.Size(129, 17);
            this.hourlyRateRadioBtn.TabIndex = 2;
            this.hourlyRateRadioBtn.TabStop = true;
            this.hourlyRateRadioBtn.Text = "По часовому тарифу";
            this.hourlyRateRadioBtn.UseVisualStyleBackColor = true;
            // 
            // carPriceField
            // 
            this.carPriceField.Location = new System.Drawing.Point(148, 84);
            this.carPriceField.MaxLength = 4;
            this.carPriceField.Name = "carPriceField";
            this.carPriceField.Size = new System.Drawing.Size(39, 20);
            this.carPriceField.TabIndex = 3;
            this.carPriceField.Text = "100";
            this.carPriceField.TextChanged += new System.EventHandler(this.carPriceField_TextChanged);
            this.carPriceField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Стоимость";
            // 
            // saveAndForwardBtn
            // 
            this.saveAndForwardBtn.Location = new System.Drawing.Point(53, 110);
            this.saveAndForwardBtn.Name = "saveAndForwardBtn";
            this.saveAndForwardBtn.Size = new System.Drawing.Size(180, 35);
            this.saveAndForwardBtn.TabIndex = 7;
            this.saveAndForwardBtn.Text = "Сохранить и перейти к редактору пространства парковки";
            this.saveAndForwardBtn.UseVisualStyleBackColor = true;
            this.saveAndForwardBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backToMainAdminScreenBtn
            // 
            this.backToMainAdminScreenBtn.Location = new System.Drawing.Point(-2, -4);
            this.backToMainAdminScreenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backToMainAdminScreenBtn.Name = "backToMainAdminScreenBtn";
            this.backToMainAdminScreenBtn.Size = new System.Drawing.Size(28, 22);
            this.backToMainAdminScreenBtn.TabIndex = 20;
            this.backToMainAdminScreenBtn.Text = "<-";
            this.backToMainAdminScreenBtn.UseVisualStyleBackColor = true;
            this.backToMainAdminScreenBtn.Click += new System.EventHandler(this.backToMainAdminScreenBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "₽";
            // 
            // ConfigureTarifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backToMainAdminScreenBtn);
            this.Controls.Add(this.saveAndForwardBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carPriceField);
            this.Controls.Add(this.hourlyRateRadioBtn);
            this.Controls.Add(this.dayRateRadioBtn);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigureTarifForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настроить тариф";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton dayRateRadioBtn;
        private System.Windows.Forms.RadioButton hourlyRateRadioBtn;
        private System.Windows.Forms.TextBox carPriceField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveAndForwardBtn;
        private System.Windows.Forms.Button backToMainAdminScreenBtn;
        private System.Windows.Forms.Label label3;
    }
}