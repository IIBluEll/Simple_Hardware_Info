namespace SimpleHWInfo.HW_SimpleMonitor
{
    partial class SImpleHwMonitor_View
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
            if ( disposing && ( components != null ) )
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cpuGroup = new GroupBox();
            cpuPictureBox = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cpuUsageProgress = new ProgressBar();
            cpuTempProgress = new ProgressBar();
            cpuUsageLabel = new TextBox();
            label4 = new Label();
            cpuTempLabel = new TextBox();
            label3 = new Label();
            cpuClockLabel = new TextBox();
            label2 = new Label();
            cpuNameLabel = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            gpuGroup = new GroupBox();
            gpuPictureBox = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            gpuUsageProgress = new ProgressBar();
            gpuTempProgress = new ProgressBar();
            gpuUsageLabel = new TextBox();
            label11 = new Label();
            gpuTempLabel = new TextBox();
            label12 = new Label();
            gpuClockLabel = new TextBox();
            label13 = new Label();
            gpuNameLabel = new TextBox();
            label14 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            cpuGroup.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)cpuPictureBox ).BeginInit();
            tabPage2.SuspendLayout();
            gpuGroup.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)gpuPictureBox ).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0 , 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(598 , 230);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(cpuGroup);
            tabPage1.Location = new Point(4 , 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(635 , 237);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CPU";
            // 
            // cpuGroup
            // 
            cpuGroup.Controls.Add(cpuPictureBox);
            cpuGroup.Controls.Add(label7);
            cpuGroup.Controls.Add(label6);
            cpuGroup.Controls.Add(label5);
            cpuGroup.Controls.Add(cpuUsageProgress);
            cpuGroup.Controls.Add(cpuTempProgress);
            cpuGroup.Controls.Add(cpuUsageLabel);
            cpuGroup.Controls.Add(label4);
            cpuGroup.Controls.Add(cpuTempLabel);
            cpuGroup.Controls.Add(label3);
            cpuGroup.Controls.Add(cpuClockLabel);
            cpuGroup.Controls.Add(label2);
            cpuGroup.Controls.Add(cpuNameLabel);
            cpuGroup.Controls.Add(label1);
            cpuGroup.Font = new Font("D2Coding" , 14.2499981F , FontStyle.Bold , GraphicsUnit.Point , 129);
            cpuGroup.Location = new Point(6 , 6);
            cpuGroup.Name = "cpuGroup";
            cpuGroup.Size = new Size(575 , 190);
            cpuGroup.TabIndex = 1;
            cpuGroup.TabStop = false;
            cpuGroup.Text = "Simple Info";
            // 
            // cpuPictureBox
            // 
            cpuPictureBox.Location = new Point(423 , 29);
            cpuPictureBox.Name = "cpuPictureBox";
            cpuPictureBox.Size = new Size(131 , 140);
            cpuPictureBox.TabIndex = 2;
            cpuPictureBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label7.Location = new Point(119 , 147);
            label7.Name = "label7";
            label7.Size = new Size(16 , 18);
            label7.TabIndex = 15;
            label7.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label6.Location = new Point(119 , 107);
            label6.Name = "label6";
            label6.Size = new Size(16 , 18);
            label6.TabIndex = 14;
            label6.Text = "℃";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label5.Location = new Point(119 , 70);
            label5.Name = "label5";
            label5.Size = new Size(32 , 18);
            label5.TabIndex = 13;
            label5.Text = "Mhz";
            // 
            // cpuUsageProgress
            // 
            cpuUsageProgress.Location = new Point(141 , 144);
            cpuUsageProgress.Name = "cpuUsageProgress";
            cpuUsageProgress.Size = new Size(257 , 25);
            cpuUsageProgress.TabIndex = 12;
            // 
            // cpuTempProgress
            // 
            cpuTempProgress.BackColor = Color.FloralWhite;
            cpuTempProgress.Location = new Point(141 , 104);
            cpuTempProgress.Name = "cpuTempProgress";
            cpuTempProgress.Size = new Size(257 , 25);
            cpuTempProgress.TabIndex = 11;
            // 
            // cpuUsageLabel
            // 
            cpuUsageLabel.BackColor = SystemColors.ControlLight;
            cpuUsageLabel.Enabled = false;
            cpuUsageLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            cpuUsageLabel.Location = new Point(60 , 144);
            cpuUsageLabel.Multiline = true;
            cpuUsageLabel.Name = "cpuUsageLabel";
            cpuUsageLabel.Size = new Size(53 , 25);
            cpuUsageLabel.TabIndex = 9;
            cpuUsageLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label4.Location = new Point(6 , 147);
            label4.Name = "label4";
            label4.Size = new Size(48 , 18);
            label4.TabIndex = 8;
            label4.Text = "Usage";
            // 
            // cpuTempLabel
            // 
            cpuTempLabel.BackColor = SystemColors.ControlLight;
            cpuTempLabel.Enabled = false;
            cpuTempLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            cpuTempLabel.Location = new Point(60 , 104);
            cpuTempLabel.Multiline = true;
            cpuTempLabel.Name = "cpuTempLabel";
            cpuTempLabel.Size = new Size(53 , 25);
            cpuTempLabel.TabIndex = 7;
            cpuTempLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label3.Location = new Point(6 , 107);
            label3.Name = "label3";
            label3.Size = new Size(40 , 18);
            label3.TabIndex = 6;
            label3.Text = "Temp";
            // 
            // cpuClockLabel
            // 
            cpuClockLabel.BackColor = SystemColors.ControlLight;
            cpuClockLabel.Enabled = false;
            cpuClockLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            cpuClockLabel.Location = new Point(60 , 67);
            cpuClockLabel.Multiline = true;
            cpuClockLabel.Name = "cpuClockLabel";
            cpuClockLabel.Size = new Size(53 , 25);
            cpuClockLabel.TabIndex = 5;
            cpuClockLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label2.Location = new Point(6 , 70);
            label2.Name = "label2";
            label2.Size = new Size(48 , 18);
            label2.TabIndex = 4;
            label2.Text = "Clock";
            // 
            // cpuNameLabel
            // 
            cpuNameLabel.BackColor = SystemColors.ControlLight;
            cpuNameLabel.Enabled = false;
            cpuNameLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            cpuNameLabel.Location = new Point(60 , 29);
            cpuNameLabel.Multiline = true;
            cpuNameLabel.Name = "cpuNameLabel";
            cpuNameLabel.Size = new Size(338 , 20);
            cpuNameLabel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label1.Location = new Point(6 , 32);
            label1.Name = "label1";
            label1.Size = new Size(40 , 18);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(gpuGroup);
            tabPage2.Location = new Point(4 , 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(590 , 202);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "GPU";
            // 
            // gpuGroup
            // 
            gpuGroup.Controls.Add(gpuPictureBox);
            gpuGroup.Controls.Add(label8);
            gpuGroup.Controls.Add(label9);
            gpuGroup.Controls.Add(label10);
            gpuGroup.Controls.Add(gpuUsageProgress);
            gpuGroup.Controls.Add(gpuTempProgress);
            gpuGroup.Controls.Add(gpuUsageLabel);
            gpuGroup.Controls.Add(label11);
            gpuGroup.Controls.Add(gpuTempLabel);
            gpuGroup.Controls.Add(label12);
            gpuGroup.Controls.Add(gpuClockLabel);
            gpuGroup.Controls.Add(label13);
            gpuGroup.Controls.Add(gpuNameLabel);
            gpuGroup.Controls.Add(label14);
            gpuGroup.Font = new Font("D2Coding" , 14.2499981F , FontStyle.Bold , GraphicsUnit.Point , 129);
            gpuGroup.Location = new Point(6 , 6);
            gpuGroup.Name = "gpuGroup";
            gpuGroup.Size = new Size(575 , 190);
            gpuGroup.TabIndex = 2;
            gpuGroup.TabStop = false;
            gpuGroup.Text = "Simple Info";
            // 
            // gpuPictureBox
            // 
            gpuPictureBox.Location = new Point(423 , 29);
            gpuPictureBox.Name = "gpuPictureBox";
            gpuPictureBox.Size = new Size(131 , 140);
            gpuPictureBox.TabIndex = 2;
            gpuPictureBox.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label8.Location = new Point(119 , 147);
            label8.Name = "label8";
            label8.Size = new Size(16 , 18);
            label8.TabIndex = 15;
            label8.Text = "%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label9.Location = new Point(119 , 107);
            label9.Name = "label9";
            label9.Size = new Size(16 , 18);
            label9.TabIndex = 14;
            label9.Text = "℃";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label10.Location = new Point(119 , 70);
            label10.Name = "label10";
            label10.Size = new Size(32 , 18);
            label10.TabIndex = 13;
            label10.Text = "Mhz";
            // 
            // gpuUsageProgress
            // 
            gpuUsageProgress.Location = new Point(141 , 144);
            gpuUsageProgress.Name = "gpuUsageProgress";
            gpuUsageProgress.Size = new Size(257 , 25);
            gpuUsageProgress.TabIndex = 12;
            // 
            // gpuTempProgress
            // 
            gpuTempProgress.BackColor = Color.FloralWhite;
            gpuTempProgress.Location = new Point(141 , 104);
            gpuTempProgress.Name = "gpuTempProgress";
            gpuTempProgress.Size = new Size(257 , 25);
            gpuTempProgress.TabIndex = 11;
            // 
            // gpuUsageLabel
            // 
            gpuUsageLabel.BackColor = SystemColors.ControlLight;
            gpuUsageLabel.Enabled = false;
            gpuUsageLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            gpuUsageLabel.Location = new Point(60 , 144);
            gpuUsageLabel.Multiline = true;
            gpuUsageLabel.Name = "gpuUsageLabel";
            gpuUsageLabel.Size = new Size(53 , 25);
            gpuUsageLabel.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label11.Location = new Point(6 , 147);
            label11.Name = "label11";
            label11.Size = new Size(48 , 18);
            label11.TabIndex = 8;
            label11.Text = "Usage";
            // 
            // gpuTempLabel
            // 
            gpuTempLabel.BackColor = SystemColors.ControlLight;
            gpuTempLabel.Enabled = false;
            gpuTempLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            gpuTempLabel.Location = new Point(60 , 104);
            gpuTempLabel.Multiline = true;
            gpuTempLabel.Name = "gpuTempLabel";
            gpuTempLabel.Size = new Size(53 , 25);
            gpuTempLabel.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label12.Location = new Point(6 , 107);
            label12.Name = "label12";
            label12.Size = new Size(40 , 18);
            label12.TabIndex = 6;
            label12.Text = "Temp";
            // 
            // gpuClockLabel
            // 
            gpuClockLabel.BackColor = SystemColors.ControlLight;
            gpuClockLabel.Enabled = false;
            gpuClockLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            gpuClockLabel.Location = new Point(60 , 67);
            gpuClockLabel.Multiline = true;
            gpuClockLabel.Name = "gpuClockLabel";
            gpuClockLabel.Size = new Size(53 , 25);
            gpuClockLabel.TabIndex = 5;
            gpuClockLabel.TextChanged +=  gpuClockLabel_TextChanged ;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label13.Location = new Point(6 , 70);
            label13.Name = "label13";
            label13.Size = new Size(48 , 18);
            label13.TabIndex = 4;
            label13.Text = "Clock";
            // 
            // gpuNameLabel
            // 
            gpuNameLabel.BackColor = SystemColors.ControlLight;
            gpuNameLabel.Enabled = false;
            gpuNameLabel.Font = new Font("D2Coding" , 12F , FontStyle.Bold , GraphicsUnit.Point , 129);
            gpuNameLabel.Location = new Point(60 , 29);
            gpuNameLabel.Multiline = true;
            gpuNameLabel.Name = "gpuNameLabel";
            gpuNameLabel.Size = new Size(338 , 20);
            gpuNameLabel.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("D2Coding" , 12F , FontStyle.Bold);
            label14.Location = new Point(6 , 32);
            label14.Name = "label14";
            label14.Size = new Size(40 , 18);
            label14.TabIndex = 2;
            label14.Text = "Name";
            // 
            // SImpleHwMonitor_View
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598 , 230);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SImpleHwMonitor_View";
            Text = "SImpleHwMonitor_View";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            cpuGroup.ResumeLayout(false);
            cpuGroup.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)cpuPictureBox ).EndInit();
            tabPage2.ResumeLayout(false);
            gpuGroup.ResumeLayout(false);
            gpuGroup.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)gpuPictureBox ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox cpuGroup;
        private TextBox cpuClockLabel;
        private Label label2;
        private TextBox cpuNameLabel;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private ProgressBar cpuUsageProgress;
        private ProgressBar cpuTempProgress;
        private TextBox cpuUsageLabel;
        private Label label4;
        private TextBox cpuTempLabel;
        private Label label3;
        private PictureBox cpuPictureBox;
        private GroupBox gpuGroup;
        private PictureBox gpuPictureBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private ProgressBar gpuUsageProgress;
        private ProgressBar gpuTempProgress;
        private TextBox gpuUsageLabel;
        private Label label11;
        private TextBox gpuTempLabel;
        private Label label12;
        private TextBox gpuClockLabel;
        private Label label13;
        private TextBox gpuNameLabel;
        private Label label14;
    }
}