namespace ParkingApp.Screens.Manager
{
    partial class ConfigureModelingParamsForm
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
            this.backToAdminMainScreen = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DXtextBox = new System.Windows.Forms.TextBox();
            this.MXtextBox = new System.Windows.Forms.TextBox();
            this.exponTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bValuetextBox = new System.Windows.Forms.TextBox();
            this.aValuetextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.typeOfDistributionLowComboBox = new System.Windows.Forms.ComboBox();
            this.onParkingIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.appearanceIntervalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.probabilityTextBox = new System.Windows.Forms.TextBox();
            this.HazardFlowRadioBtn = new System.Windows.Forms.RadioButton();
            this.determFlowRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DXonParkingIntervalTB = new System.Windows.Forms.TextBox();
            this.MXonParkingIntervalTB = new System.Windows.Forms.TextBox();
            this.lambdaOnParkingIntervalTB = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.bOnParkingIntervalTB = new System.Windows.Forms.TextBox();
            this.aOnParkingIntervalTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // backToAdminMainScreen
            // 
            this.backToAdminMainScreen.Location = new System.Drawing.Point(-1, -1);
            this.backToAdminMainScreen.Margin = new System.Windows.Forms.Padding(2);
            this.backToAdminMainScreen.Name = "backToAdminMainScreen";
            this.backToAdminMainScreen.Size = new System.Drawing.Size(22, 18);
            this.backToAdminMainScreen.TabIndex = 14;
            this.backToAdminMainScreen.Text = "<-";
            this.backToAdminMainScreen.UseVisualStyleBackColor = true;
            this.backToAdminMainScreen.Click += new System.EventHandler(this.backToAdminMainScreen_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(232, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "DX";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(232, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "MX";
            // 
            // DXtextBox
            // 
            this.DXtextBox.Location = new System.Drawing.Point(255, 192);
            this.DXtextBox.Name = "DXtextBox";
            this.DXtextBox.Size = new System.Drawing.Size(50, 20);
            this.DXtextBox.TabIndex = 60;
            this.DXtextBox.Text = "0,1";
            this.DXtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.probabilityTextBox_KeyPress);
            // 
            // MXtextBox
            // 
            this.MXtextBox.Location = new System.Drawing.Point(255, 166);
            this.MXtextBox.Name = "MXtextBox";
            this.MXtextBox.Size = new System.Drawing.Size(50, 20);
            this.MXtextBox.TabIndex = 59;
            this.MXtextBox.Text = "4";
            this.MXtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.probabilityTextBox_KeyPress);
            // 
            // exponTextBox
            // 
            this.exponTextBox.Location = new System.Drawing.Point(255, 178);
            this.exponTextBox.Name = "exponTextBox";
            this.exponTextBox.Size = new System.Drawing.Size(50, 20);
            this.exponTextBox.TabIndex = 58;
            this.exponTextBox.Text = "0,28";
            this.exponTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.probabilityTextBox_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = " λ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "b";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(234, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "a";
            // 
            // bValuetextBox
            // 
            this.bValuetextBox.Location = new System.Drawing.Point(255, 192);
            this.bValuetextBox.Name = "bValuetextBox";
            this.bValuetextBox.Size = new System.Drawing.Size(50, 20);
            this.bValuetextBox.TabIndex = 54;
            this.bValuetextBox.Text = "120";
            this.bValuetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.probabilityTextBox_KeyPress);
            // 
            // aValuetextBox
            // 
            this.aValuetextBox.Location = new System.Drawing.Point(255, 166);
            this.aValuetextBox.Name = "aValuetextBox";
            this.aValuetextBox.Size = new System.Drawing.Size(50, 20);
            this.aValuetextBox.TabIndex = 53;
            this.aValuetextBox.Text = "0,5";
            this.aValuetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.probabilityTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "0.5";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(101, 344);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(159, 45);
            this.trackBar1.TabIndex = 48;
            this.trackBar1.Value = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Скорость воспроизведения:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeOfDistributionLowComboBox
            // 
            this.typeOfDistributionLowComboBox.FormattingEnabled = true;
            this.typeOfDistributionLowComboBox.Items.AddRange(new object[] {
            "Равномерный",
            "Экспоненциальный",
            "Нормальный"});
            this.typeOfDistributionLowComboBox.Location = new System.Drawing.Point(210, 139);
            this.typeOfDistributionLowComboBox.Name = "typeOfDistributionLowComboBox";
            this.typeOfDistributionLowComboBox.Size = new System.Drawing.Size(134, 21);
            this.typeOfDistributionLowComboBox.TabIndex = 45;
            this.typeOfDistributionLowComboBox.Text = "Закон распределения";
            this.typeOfDistributionLowComboBox.SelectionChangeCommitted += new System.EventHandler(this.typeOfDistributionLowComboBox_SelectionChangeCommitted);
            // 
            // onParkingIntervalTextBox
            // 
            this.onParkingIntervalTextBox.Location = new System.Drawing.Point(138, 145);
            this.onParkingIntervalTextBox.Name = "onParkingIntervalTextBox";
            this.onParkingIntervalTextBox.Size = new System.Drawing.Size(50, 20);
            this.onParkingIntervalTextBox.TabIndex = 44;
            this.onParkingIntervalTextBox.Text = "5";
            this.onParkingIntervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appearanceIntervalTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Интервал стоянки";
            // 
            // appearanceIntervalTextBox
            // 
            this.appearanceIntervalTextBox.Location = new System.Drawing.Point(138, 119);
            this.appearanceIntervalTextBox.Name = "appearanceIntervalTextBox";
            this.appearanceIntervalTextBox.Size = new System.Drawing.Size(50, 20);
            this.appearanceIntervalTextBox.TabIndex = 42;
            this.appearanceIntervalTextBox.Text = "3";
            this.appearanceIntervalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appearanceIntervalTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Интервал появления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "потока";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Параметры случайного";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "потока";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Параметры детерминированного";
            // 
            // probabilityTextBox
            // 
            this.probabilityTextBox.Location = new System.Drawing.Point(210, 20);
            this.probabilityTextBox.Name = "probabilityTextBox";
            this.probabilityTextBox.Size = new System.Drawing.Size(50, 20);
            this.probabilityTextBox.TabIndex = 36;
            this.probabilityTextBox.Text = "0,7";
            this.probabilityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.probabilityTextBox_KeyPress);
            // 
            // HazardFlowRadioBtn
            // 
            this.HazardFlowRadioBtn.AutoSize = true;
            this.HazardFlowRadioBtn.Location = new System.Drawing.Point(220, 55);
            this.HazardFlowRadioBtn.Name = "HazardFlowRadioBtn";
            this.HazardFlowRadioBtn.Size = new System.Drawing.Size(112, 17);
            this.HazardFlowRadioBtn.TabIndex = 35;
            this.HazardFlowRadioBtn.Text = "Случайный поток";
            this.HazardFlowRadioBtn.UseVisualStyleBackColor = true;
            this.HazardFlowRadioBtn.CheckedChanged += new System.EventHandler(this.randomFlowSelected);
            // 
            // determFlowRadioBtn
            // 
            this.determFlowRadioBtn.AutoSize = true;
            this.determFlowRadioBtn.Checked = true;
            this.determFlowRadioBtn.Location = new System.Drawing.Point(26, 55);
            this.determFlowRadioBtn.Name = "determFlowRadioBtn";
            this.determFlowRadioBtn.Size = new System.Drawing.Size(165, 17);
            this.determFlowRadioBtn.TabIndex = 34;
            this.determFlowRadioBtn.TabStop = true;
            this.determFlowRadioBtn.Text = "Детерминированный поток";
            this.determFlowRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Вероятность заезда";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(216, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Появление автомобиля";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(217, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 13);
            this.label19.TabIndex = 64;
            this.label19.Text = "Стоянка автомобиля";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(225, 297);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 13);
            this.label20.TabIndex = 74;
            this.label20.Text = "DX";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(226, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 73;
            this.label21.Text = "MX";
            // 
            // DXonParkingIntervalTB
            // 
            this.DXonParkingIntervalTB.Location = new System.Drawing.Point(255, 294);
            this.DXonParkingIntervalTB.Name = "DXonParkingIntervalTB";
            this.DXonParkingIntervalTB.Size = new System.Drawing.Size(50, 20);
            this.DXonParkingIntervalTB.TabIndex = 72;
            this.DXonParkingIntervalTB.Text = "0,1";
            // 
            // MXonParkingIntervalTB
            // 
            this.MXonParkingIntervalTB.Location = new System.Drawing.Point(255, 268);
            this.MXonParkingIntervalTB.Name = "MXonParkingIntervalTB";
            this.MXonParkingIntervalTB.Size = new System.Drawing.Size(50, 20);
            this.MXonParkingIntervalTB.TabIndex = 71;
            this.MXonParkingIntervalTB.Text = "4";
            // 
            // lambdaOnParkingIntervalTB
            // 
            this.lambdaOnParkingIntervalTB.Location = new System.Drawing.Point(255, 280);
            this.lambdaOnParkingIntervalTB.Name = "lambdaOnParkingIntervalTB";
            this.lambdaOnParkingIntervalTB.Size = new System.Drawing.Size(50, 20);
            this.lambdaOnParkingIntervalTB.TabIndex = 70;
            this.lambdaOnParkingIntervalTB.Text = "0,28";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(232, 283);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 69;
            this.label22.Text = " λ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(234, 297);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 68;
            this.label23.Text = "b";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(234, 271);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 67;
            this.label24.Text = "a";
            // 
            // bOnParkingIntervalTB
            // 
            this.bOnParkingIntervalTB.Location = new System.Drawing.Point(255, 294);
            this.bOnParkingIntervalTB.Name = "bOnParkingIntervalTB";
            this.bOnParkingIntervalTB.Size = new System.Drawing.Size(50, 20);
            this.bOnParkingIntervalTB.TabIndex = 66;
            this.bOnParkingIntervalTB.Text = "120";
            // 
            // aOnParkingIntervalTB
            // 
            this.aOnParkingIntervalTB.Location = new System.Drawing.Point(255, 268);
            this.aOnParkingIntervalTB.Name = "aOnParkingIntervalTB";
            this.aOnParkingIntervalTB.Size = new System.Drawing.Size(50, 20);
            this.aOnParkingIntervalTB.TabIndex = 65;
            this.aOnParkingIntervalTB.Text = "0,5";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Равномерный",
            "Экспоненциальный",
            "Нормальный"});
            this.comboBox1.Location = new System.Drawing.Point(209, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.Text = "Закон распределения";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.onParkingIntervalCB);
            // 
            // ConfigureModelingParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 436);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.DXonParkingIntervalTB);
            this.Controls.Add(this.MXonParkingIntervalTB);
            this.Controls.Add(this.lambdaOnParkingIntervalTB);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.bOnParkingIntervalTB);
            this.Controls.Add(this.aOnParkingIntervalTB);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DXtextBox);
            this.Controls.Add(this.MXtextBox);
            this.Controls.Add(this.exponTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bValuetextBox);
            this.Controls.Add(this.aValuetextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeOfDistributionLowComboBox);
            this.Controls.Add(this.onParkingIntervalTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.appearanceIntervalTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.probabilityTextBox);
            this.Controls.Add(this.HazardFlowRadioBtn);
            this.Controls.Add(this.determFlowRadioBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToAdminMainScreen);
            this.Name = "ConfigureModelingParamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка параметров моделирования";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Resize += new System.EventHandler(this.preventResize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backToAdminMainScreen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox DXtextBox;
        private System.Windows.Forms.TextBox MXtextBox;
        private System.Windows.Forms.TextBox exponTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bValuetextBox;
        private System.Windows.Forms.TextBox aValuetextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox typeOfDistributionLowComboBox;
        private System.Windows.Forms.TextBox onParkingIntervalTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox appearanceIntervalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox probabilityTextBox;
        private System.Windows.Forms.RadioButton HazardFlowRadioBtn;
        private System.Windows.Forms.RadioButton determFlowRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox DXonParkingIntervalTB;
        private System.Windows.Forms.TextBox MXonParkingIntervalTB;
        private System.Windows.Forms.TextBox lambdaOnParkingIntervalTB;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox bOnParkingIntervalTB;
        private System.Windows.Forms.TextBox aOnParkingIntervalTB;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}