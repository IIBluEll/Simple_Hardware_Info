namespace SimpleHWInfo.HW_Monitor
{
    partial class HwMonitor_View
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
            MenuStrip = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutProgramToolStripMenuItem = new ToolStripMenuItem();
            HardWareListView = new ListView();
            Sensor = new ColumnHeader();
            Value = new ColumnHeader();
            Max = new ColumnHeader();
            Min = new ColumnHeader();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            MenuStrip.Location = new Point(0 , 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800 , 24);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutProgramToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44 , 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            aboutProgramToolStripMenuItem.Size = new Size(180 , 22);
            aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // HardWareListView
            // 
            HardWareListView.BackColor = SystemColors.Window;
            HardWareListView.Columns.AddRange(new ColumnHeader[] { Sensor , Value , Max , Min });
            HardWareListView.Dock = DockStyle.Fill;
            HardWareListView.GridLines = true;
            HardWareListView.Location = new Point(0 , 24);
            HardWareListView.MultiSelect = false;
            HardWareListView.Name = "HardWareListView";
            HardWareListView.Size = new Size(800 , 426);
            HardWareListView.TabIndex = 2;
            HardWareListView.UseCompatibleStateImageBehavior = false;
            HardWareListView.View = View.Details;
            // 
            // Sensor
            // 
            Sensor.Text = "Sensor";
            Sensor.Width = 250;
            // 
            // Value
            // 
            Value.Text = "Value";
            Value.TextAlign = HorizontalAlignment.Center;
            Value.Width = 100;
            // 
            // Max
            // 
            Max.Text = "Max";
            Max.TextAlign = HorizontalAlignment.Center;
            Max.Width = 100;
            // 
            // Min
            // 
            Min.Text = "Min";
            Min.TextAlign = HorizontalAlignment.Center;
            Min.Width = 100;
            // 
            // HwMonitor_View
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 , 450);
            Controls.Add(HardWareListView);
            Controls.Add(MenuStrip);
            Font = new Font("D2Coding" , 9.75F , FontStyle.Regular , GraphicsUnit.Point , 129);
            MainMenuStrip = MenuStrip;
            Name = "HwMonitor_View";
            Text = "HwMonitor_View";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MenuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutProgramToolStripMenuItem;
        private ListView HardWareListView;
        private ColumnHeader Sensor;
        private ColumnHeader Value;
        private ColumnHeader Max;
        private ColumnHeader Min;
    }
}