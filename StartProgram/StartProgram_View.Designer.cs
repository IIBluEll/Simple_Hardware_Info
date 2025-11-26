namespace SimpleHWInfo.StartProgram
{
    partial class StartProgram_View
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            GithubLinkLabel = new LinkLabel();
            StartBtn = new Button();
            label3 = new Label();
            modeComboBox = new ComboBox();
            SettingBtn = new Button();
            ( (System.ComponentModel.ISupportInitialize)pictureBox1 ).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._123123;
            pictureBox1.Location = new Point(12 , 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74 , 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("D2Coding" , 15.7499981F , FontStyle.Bold , GraphicsUnit.Point , 129);
            label1.Location = new Point(99 , 24);
            label1.Name = "label1";
            label1.Size = new Size(150 , 24);
            label1.TabIndex = 1;
            label1.Text = "SIMPLE HW INFO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("D2Coding" , 10F);
            label2.Location = new Point(123 , 48);
            label2.Name = "label2";
            label2.Size = new Size(99 , 17);
            label2.TabIndex = 2;
            label2.Text = "Version 0.0.1";
            // 
            // GithubLinkLabel
            // 
            GithubLinkLabel.AutoSize = true;
            GithubLinkLabel.Font = new Font("D2Coding" , 11F);
            GithubLinkLabel.Location = new Point(239 , 226);
            GithubLinkLabel.Name = "GithubLinkLabel";
            GithubLinkLabel.Size = new Size(85 , 18);
            GithubLinkLabel.TabIndex = 3;
            GithubLinkLabel.TabStop = true;
            GithubLinkLabel.Text = "Github Link";
            GithubLinkLabel.LinkClicked +=  GithubLinkLabel_LinkClicked ;
            // 
            // StartBtn
            // 
            StartBtn.Font = new Font("D2Coding" , 14.2499981F , FontStyle.Bold);
            StartBtn.Location = new Point(80 , 122);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(192 , 41);
            StartBtn.TabIndex = 4;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click +=  StartBtn_Click ;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("D2Coding" , 11F);
            label3.Location = new Point(13 , 227);
            label3.Name = "label3";
            label3.Size = new Size(85 , 18);
            label3.TabIndex = 5;
            label3.Text = "Hyunmin Lee";
            // 
            // modeComboBox
            // 
            modeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeComboBox.Font = new Font("D2Coding" , 11.25F , FontStyle.Bold , GraphicsUnit.Point , 129);
            modeComboBox.FormattingEnabled = true;
            modeComboBox.Items.AddRange(new object[] { "Full Sensor Mode" , "Simple Sensor Mode" });
            modeComboBox.Location = new Point(80 , 90);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(192 , 26);
            modeComboBox.TabIndex = 6;
            // 
            // SettingBtn
            // 
            SettingBtn.Font = new Font("D2Coding" , 14.2499981F , FontStyle.Bold);
            SettingBtn.Location = new Point(80 , 169);
            SettingBtn.Name = "SettingBtn";
            SettingBtn.Size = new Size(192 , 41);
            SettingBtn.TabIndex = 7;
            SettingBtn.Text = "Setting";
            SettingBtn.UseVisualStyleBackColor = true;
            // 
            // StartProgram_View
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336 , 253);
            Controls.Add(SettingBtn);
            Controls.Add(modeComboBox);
            Controls.Add(label3);
            Controls.Add(StartBtn);
            Controls.Add(GithubLinkLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("D2Coding" , 9.75F , FontStyle.Bold , GraphicsUnit.Point , 129);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartProgram_View";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "SimpleHW INFO";
            ( (System.ComponentModel.ISupportInitialize)pictureBox1 ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private LinkLabel GithubLinkLabel;
        private Button StartBtn;
        private Label label3;
        private ComboBox modeComboBox;
        private Button SettingBtn;
    }
}
