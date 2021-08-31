namespace ParkingApp.Screens.Administrator
{
    partial class SaveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.parkingFilePathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backToParkingSpaceForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название файла";
            // 
            // parkingFilePathTextBox
            // 
            this.parkingFilePathTextBox.Location = new System.Drawing.Point(65, 50);
            this.parkingFilePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.parkingFilePathTextBox.Name = "parkingFilePathTextBox";
            this.parkingFilePathTextBox.Size = new System.Drawing.Size(132, 20);
            this.parkingFilePathTextBox.TabIndex = 1;
            this.parkingFilePathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backToParkingSpaceForm
            // 
            this.backToParkingSpaceForm.Location = new System.Drawing.Point(-4, -5);
            this.backToParkingSpaceForm.Margin = new System.Windows.Forms.Padding(2);
            this.backToParkingSpaceForm.Name = "backToParkingSpaceForm";
            this.backToParkingSpaceForm.Size = new System.Drawing.Size(34, 22);
            this.backToParkingSpaceForm.TabIndex = 3;
            this.backToParkingSpaceForm.Text = "<-";
            this.backToParkingSpaceForm.UseVisualStyleBackColor = true;
            this.backToParkingSpaceForm.Click += new System.EventHandler(this.backToParkingSpaceForm_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 118);
            this.Controls.Add(this.backToParkingSpaceForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parkingFilePathTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сохранить парковку";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parkingFilePathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backToParkingSpaceForm;
    }
}