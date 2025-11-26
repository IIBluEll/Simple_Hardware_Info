namespace SimpleHWInfo.HW_FullMonitor
{
    partial class HwFullMonitor_View
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
            hardWareListView = new ListView();
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
            MenuStrip.Size = new Size(556 , 24);
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
            aboutProgramToolStripMenuItem.Size = new Size(157 , 22);
            aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // hardWareListView
            // 
            hardWareListView.BackColor = SystemColors.Window;
            hardWareListView.Columns.AddRange(new ColumnHeader[] { Sensor , Value , Max , Min });
            hardWareListView.Dock = DockStyle.Fill;
            hardWareListView.GridLines = true;
            hardWareListView.Location = new Point(0 , 24);
            hardWareListView.MultiSelect = false;
            hardWareListView.Name = "hardWareListView";
            hardWareListView.Size = new Size(556 , 937);
            hardWareListView.TabIndex = 2;
            hardWareListView.UseCompatibleStateImageBehavior = false;
            hardWareListView.View = View.Details;
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
            // HwFullMonitor_View
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556 , 961);
            Controls.Add(hardWareListView);
            Controls.Add(MenuStrip);
            Font = new Font("D2Coding" , 9.75F , FontStyle.Regular , GraphicsUnit.Point , 129);
            MainMenuStrip = MenuStrip;
            Name = "HwFullMonitor_View";
            Text = "HW Full Sensor";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MenuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutProgramToolStripMenuItem;
        private ListView hardWareListView;
        private ColumnHeader Sensor;
        private ColumnHeader Value;
        private ColumnHeader Max;
        private ColumnHeader Min;
    }
}