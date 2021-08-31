namespace ParkingApp
{
    partial class ParkingSpaceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grassPic = new System.Windows.Forms.PictureBox();
            this.entrancePic = new System.Windows.Forms.PictureBox();
            this.exitPic = new System.Windows.Forms.PictureBox();
            this.dollarPic = new System.Windows.Forms.PictureBox();
            this.autoPic = new System.Windows.Forms.PictureBox();
            this.treePic = new System.Windows.Forms.PictureBox();
            this.roadPic = new System.Windows.Forms.PictureBox();
            this.saveToFile = new System.Windows.Forms.Button();
            this.createNewParkingBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonsBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.leftAdjacentRoad = new System.Windows.Forms.Panel();
            this.rightAdjacentRoad = new System.Windows.Forms.Panel();
            this.upAdjacentRoad = new System.Windows.Forms.Panel();
            this.downAdjacentRoad = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPic)).BeginInit();
            this.buttonsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.grassPic);
            this.panel2.Controls.Add(this.entrancePic);
            this.panel2.Controls.Add(this.exitPic);
            this.panel2.Controls.Add(this.dollarPic);
            this.panel2.Controls.Add(this.autoPic);
            this.panel2.Controls.Add(this.treePic);
            this.panel2.Controls.Add(this.roadPic);
            this.panel2.Location = new System.Drawing.Point(587, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 219);
            this.panel2.TabIndex = 11;
            // 
            // grassPic
            // 
            this.grassPic.Image = global::ParkingApp.Properties.Resources.grassPic;
            this.grassPic.Location = new System.Drawing.Point(116, 151);
            this.grassPic.Name = "grassPic";
            this.grassPic.Size = new System.Drawing.Size(69, 65);
            this.grassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grassPic.TabIndex = 9;
            this.grassPic.TabStop = false;
            this.grassPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownGrass);
            // 
            // entrancePic
            // 
            this.entrancePic.Image = global::ParkingApp.Properties.Resources.entrancePic;
            this.entrancePic.Location = new System.Drawing.Point(4, 80);
            this.entrancePic.Name = "entrancePic";
            this.entrancePic.Size = new System.Drawing.Size(69, 65);
            this.entrancePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.entrancePic.TabIndex = 1;
            this.entrancePic.TabStop = false;
            this.entrancePic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEntrancePic);
            // 
            // exitPic
            // 
            this.exitPic.Image = global::ParkingApp.Properties.Resources.exitPic;
            this.exitPic.Location = new System.Drawing.Point(154, 80);
            this.exitPic.Name = "exitPic";
            this.exitPic.Size = new System.Drawing.Size(69, 65);
            this.exitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPic.TabIndex = 2;
            this.exitPic.TabStop = false;
            this.exitPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownExitPic);
            // 
            // dollarPic
            // 
            this.dollarPic.Image = global::ParkingApp.Properties.Resources.cashBoxPic;
            this.dollarPic.Location = new System.Drawing.Point(79, 80);
            this.dollarPic.Name = "dollarPic";
            this.dollarPic.Size = new System.Drawing.Size(69, 65);
            this.dollarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dollarPic.TabIndex = 5;
            this.dollarPic.TabStop = false;
            this.dollarPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dollarDown);
            // 
            // autoPic
            // 
            this.autoPic.Image = global::ParkingApp.Properties.Resources.parkingPlacePic;
            this.autoPic.Location = new System.Drawing.Point(34, 9);
            this.autoPic.Name = "autoPic";
            this.autoPic.Size = new System.Drawing.Size(69, 65);
            this.autoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.autoPic.TabIndex = 7;
            this.autoPic.TabStop = false;
            this.autoPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownCar);
            // 
            // treePic
            // 
            this.treePic.Image = global::ParkingApp.Properties.Resources.treePic;
            this.treePic.Location = new System.Drawing.Point(34, 151);
            this.treePic.Name = "treePic";
            this.treePic.Size = new System.Drawing.Size(69, 65);
            this.treePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.treePic.TabIndex = 4;
            this.treePic.TabStop = false;
            this.treePic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownTree);
            // 
            // roadPic
            // 
            this.roadPic.Image = global::ParkingApp.Properties.Resources.roadPic;
            this.roadPic.Location = new System.Drawing.Point(116, 9);
            this.roadPic.Name = "roadPic";
            this.roadPic.Size = new System.Drawing.Size(69, 65);
            this.roadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roadPic.TabIndex = 6;
            this.roadPic.TabStop = false;
            this.roadPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownRoad);
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(168, 19);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(75, 49);
            this.saveToFile.TabIndex = 13;
            this.saveToFile.Text = "Сохранить в файл";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // createNewParkingBtn
            // 
            this.createNewParkingBtn.Location = new System.Drawing.Point(6, 19);
            this.createNewParkingBtn.Name = "createNewParkingBtn";
            this.createNewParkingBtn.Size = new System.Drawing.Size(75, 49);
            this.createNewParkingBtn.TabIndex = 14;
            this.createNewParkingBtn.Text = "Создать новую парковку";
            this.createNewParkingBtn.UseVisualStyleBackColor = true;
            this.createNewParkingBtn.Click += new System.EventHandler(this.createNewParkingBtn_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 16;
            // 
            // buttonsBox
            // 
            this.buttonsBox.Controls.Add(this.button1);
            this.buttonsBox.Controls.Add(this.createNewParkingBtn);
            this.buttonsBox.Controls.Add(this.saveToFile);
            this.buttonsBox.Location = new System.Drawing.Point(570, 254);
            this.buttonsBox.Name = "buttonsBox";
            this.buttonsBox.Size = new System.Drawing.Size(251, 86);
            this.buttonsBox.TabIndex = 17;
            this.buttonsBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "В главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leftAdjacentRoad
            // 
            this.leftAdjacentRoad.AutoSize = true;
            this.leftAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftAdjacentRoad.Location = new System.Drawing.Point(375, 254);
            this.leftAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.leftAdjacentRoad.Name = "leftAdjacentRoad";
            this.leftAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.leftAdjacentRoad.TabIndex = 18;
            // 
            // rightAdjacentRoad
            // 
            this.rightAdjacentRoad.AutoSize = true;
            this.rightAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightAdjacentRoad.Location = new System.Drawing.Point(338, 282);
            this.rightAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.rightAdjacentRoad.Name = "rightAdjacentRoad";
            this.rightAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.rightAdjacentRoad.TabIndex = 19;
            // 
            // upAdjacentRoad
            // 
            this.upAdjacentRoad.AutoSize = true;
            this.upAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upAdjacentRoad.Location = new System.Drawing.Point(0, 0);
            this.upAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.upAdjacentRoad.Name = "upAdjacentRoad";
            this.upAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.upAdjacentRoad.TabIndex = 20;
            // 
            // downAdjacentRoad
            // 
            this.downAdjacentRoad.AutoSize = true;
            this.downAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downAdjacentRoad.Location = new System.Drawing.Point(-23, -46);
            this.downAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.downAdjacentRoad.Name = "downAdjacentRoad";
            this.downAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.downAdjacentRoad.TabIndex = 21;
            // 
            // ParkingSpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 548);
            this.Controls.Add(this.downAdjacentRoad);
            this.Controls.Add(this.upAdjacentRoad);
            this.Controls.Add(this.rightAdjacentRoad);
            this.Controls.Add(this.leftAdjacentRoad);
            this.Controls.Add(this.buttonsBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ParkingSpaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конфигурирование пространства парковки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadPic)).EndInit();
            this.buttonsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox entrancePic;
        private System.Windows.Forms.PictureBox exitPic;
        private System.Windows.Forms.PictureBox roadPic;
        private System.Windows.Forms.PictureBox dollarPic;
        private System.Windows.Forms.PictureBox treePic;
        private System.Windows.Forms.PictureBox grassPic;
        private System.Windows.Forms.PictureBox autoPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.Button createNewParkingBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox buttonsBox;
        private System.Windows.Forms.Panel leftAdjacentRoad;
        private System.Windows.Forms.Panel rightAdjacentRoad;
        private System.Windows.Forms.Panel upAdjacentRoad;
        private System.Windows.Forms.Panel downAdjacentRoad;
        private System.Windows.Forms.Button button1;
    }
}