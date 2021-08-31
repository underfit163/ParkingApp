namespace ParkingApp.Screens.Manager
{
    partial class ModelingSpaceForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftAdjacentRoad = new System.Windows.Forms.Panel();
            this.rightAdjacentRoad = new System.Windows.Forms.Panel();
            this.upAdjacentRoad = new System.Windows.Forms.Panel();
            this.downAdjacentRoad = new System.Windows.Forms.Panel();
            this.freePlacesCounter = new System.Windows.Forms.Label();
            this.SystemTime = new System.Windows.Forms.Timer(this.components);
            this.SystemTimeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // leftAdjacentRoad
            // 
            this.leftAdjacentRoad.AutoSize = true;
            this.leftAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftAdjacentRoad.Location = new System.Drawing.Point(0, 0);
            this.leftAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.leftAdjacentRoad.Name = "leftAdjacentRoad";
            this.leftAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.leftAdjacentRoad.TabIndex = 15;
            // 
            // rightAdjacentRoad
            // 
            this.rightAdjacentRoad.AutoSize = true;
            this.rightAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightAdjacentRoad.Location = new System.Drawing.Point(0, 0);
            this.rightAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.rightAdjacentRoad.Name = "rightAdjacentRoad";
            this.rightAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.rightAdjacentRoad.TabIndex = 16;
            // 
            // upAdjacentRoad
            // 
            this.upAdjacentRoad.AutoSize = true;
            this.upAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.upAdjacentRoad.Location = new System.Drawing.Point(0, 0);
            this.upAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.upAdjacentRoad.Name = "upAdjacentRoad";
            this.upAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.upAdjacentRoad.TabIndex = 17;
            // 
            // downAdjacentRoad
            // 
            this.downAdjacentRoad.AutoSize = true;
            this.downAdjacentRoad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downAdjacentRoad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.downAdjacentRoad.Location = new System.Drawing.Point(0, 0);
            this.downAdjacentRoad.Margin = new System.Windows.Forms.Padding(0);
            this.downAdjacentRoad.Name = "downAdjacentRoad";
            this.downAdjacentRoad.Size = new System.Drawing.Size(0, 0);
            this.downAdjacentRoad.TabIndex = 18;
            // 
            // freePlacesCounter
            // 
            this.freePlacesCounter.AutoSize = true;
            this.freePlacesCounter.Location = new System.Drawing.Point(333, 23);
            this.freePlacesCounter.Name = "freePlacesCounter";
            this.freePlacesCounter.Size = new System.Drawing.Size(166, 13);
            this.freePlacesCounter.TabIndex = 19;
            this.freePlacesCounter.Text = "Свободных парковочных мест: ";
            // 
            // SystemTime
            // 
            this.SystemTime.Interval = 1000;
            this.SystemTime.Tick += new System.EventHandler(this.SystemTime_Tick1);
            // 
            // SystemTimeLabel
            // 
            this.SystemTimeLabel.AutoSize = true;
            this.SystemTimeLabel.Location = new System.Drawing.Point(59, 23);
            this.SystemTimeLabel.Name = "SystemTimeLabel";
            this.SystemTimeLabel.Size = new System.Drawing.Size(104, 13);
            this.SystemTimeLabel.TabIndex = 20;
            this.SystemTimeLabel.Text = "Системное время: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(711, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 81;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(300, 550);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exit);
            // 
            // ModelingSpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(931, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SystemTimeLabel);
            this.Controls.Add(this.freePlacesCounter);
            this.Controls.Add(this.downAdjacentRoad);
            this.Controls.Add(this.upAdjacentRoad);
            this.Controls.Add(this.rightAdjacentRoad);
            this.Controls.Add(this.leftAdjacentRoad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModelingSpaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shutDownApplication);
            this.Load += new System.EventHandler(this.ModelingSpaceForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.exit);
            this.Resize += new System.EventHandler(this.preventResize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leftAdjacentRoad;
        private System.Windows.Forms.Panel rightAdjacentRoad;
        private System.Windows.Forms.Panel upAdjacentRoad;
        private System.Windows.Forms.Panel downAdjacentRoad;
        private System.Windows.Forms.Label freePlacesCounter;
        private System.Windows.Forms.Timer SystemTime;
        private System.Windows.Forms.Label SystemTimeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}