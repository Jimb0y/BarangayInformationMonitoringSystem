namespace BarangayInformationMonitoringSystem.Forms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.totalResidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSeniorCitizensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPWDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResidents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHouseholds = new System.Windows.Forms.ToolStripMenuItem();
            this.seniorSitizenListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pWDListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDashboard,
            this.toolStripMenuItem1,
            this.mnuResidents,
            this.toolStripMenuItem2,
            this.mnuHouseholds,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(752, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalResidentToolStripMenuItem,
            this.totalSeniorCitizensToolStripMenuItem,
            this.totalPWDToolStripMenuItem,
            this.toolStripMenuItem4});
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(94, 24);
            this.mnuDashboard.Text = "Dashboard";
            this.mnuDashboard.Click += new System.EventHandler(this.mnuDashboard_Click);
            // 
            // totalResidentToolStripMenuItem
            // 
            this.totalResidentToolStripMenuItem.Name = "totalResidentToolStripMenuItem";
            this.totalResidentToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.totalResidentToolStripMenuItem.Text = "Total Resident";
            this.totalResidentToolStripMenuItem.Click += new System.EventHandler(this.totalResidentToolStripMenuItem_Click);
            // 
            // totalSeniorCitizensToolStripMenuItem
            // 
            this.totalSeniorCitizensToolStripMenuItem.Name = "totalSeniorCitizensToolStripMenuItem";
            this.totalSeniorCitizensToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.totalSeniorCitizensToolStripMenuItem.Text = "Total Senior Citizens";
            this.totalSeniorCitizensToolStripMenuItem.Click += new System.EventHandler(this.totalSeniorCitizensToolStripMenuItem_Click_1);
            // 
            // totalPWDToolStripMenuItem
            // 
            this.totalPWDToolStripMenuItem.Name = "totalPWDToolStripMenuItem";
            this.totalPWDToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.totalPWDToolStripMenuItem.Text = "Total PWD";
            this.totalPWDToolStripMenuItem.Click += new System.EventHandler(this.totalPWDToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(215, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem1.Text = " ";
            // 
            // mnuResidents
            // 
            this.mnuResidents.Name = "mnuResidents";
            this.mnuResidents.Size = new System.Drawing.Size(160, 24);
            this.mnuResidents.Text = "Resident Information";
            this.mnuResidents.Click += new System.EventHandler(this.mnuResidents_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem2.Text = " ";
            // 
            // mnuHouseholds
            // 
            this.mnuHouseholds.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seniorSitizenListToolStripMenuItem,
            this.pWDListToolStripMenuItem});
            this.mnuHouseholds.Name = "mnuHouseholds";
            this.mnuHouseholds.Size = new System.Drawing.Size(175, 24);
            this.mnuHouseholds.Text = "Household Information";
            // 
            // seniorSitizenListToolStripMenuItem
            // 
            this.seniorSitizenListToolStripMenuItem.Name = "seniorSitizenListToolStripMenuItem";
            this.seniorSitizenListToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.seniorSitizenListToolStripMenuItem.Text = "Senior Sitizen List";
            this.seniorSitizenListToolStripMenuItem.Click += new System.EventHandler(this.seniorSitizenListToolStripMenuItem_Click);
            // 
            // pWDListToolStripMenuItem
            // 
            this.pWDListToolStripMenuItem.Name = "pWDListToolStripMenuItem";
            this.pWDListToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.pWDListToolStripMenuItem.Text = "PWD List";
            this.pWDListToolStripMenuItem.Click += new System.EventHandler(this.pWDListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(25, 24);
            this.toolStripMenuItem5.Text = " ";
            // 
            // mnuAbout
            // 
            this.mnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheSystemToolStripMenuItem,
            this.aboutTheAuthorToolStripMenuItem,
            this.toolStripMenuItem6,
            this.exitToolStripMenuItem1});
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(62, 24);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // aboutTheSystemToolStripMenuItem
            // 
            this.aboutTheSystemToolStripMenuItem.Name = "aboutTheSystemToolStripMenuItem";
            this.aboutTheSystemToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.aboutTheSystemToolStripMenuItem.Text = "About the System";
            this.aboutTheSystemToolStripMenuItem.Click += new System.EventHandler(this.aboutTheSystemToolStripMenuItem_Click);
            // 
            // aboutTheAuthorToolStripMenuItem
            // 
            this.aboutTheAuthorToolStripMenuItem.Name = "aboutTheAuthorToolStripMenuItem";
            this.aboutTheAuthorToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.aboutTheAuthorToolStripMenuItem.Text = "About the Author";
            this.aboutTheAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutTheAuthorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BARANGAY CASILI INFORMATION MONITORING SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome! Manage your barangay records here!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDashboard;
        private System.Windows.Forms.ToolStripMenuItem totalResidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSeniorCitizensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPWDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuResidents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuHouseholds;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aboutTheSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seniorSitizenListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pWDListToolStripMenuItem;
    }
}