namespace Team_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.workforceGroup = new System.Windows.Forms.GroupBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewJob = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            this.workforceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRole = new System.Windows.Forms.ToolStripMenuItem();
            this.assignAdditionalRole = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.JobsTabs = new System.Windows.Forms.TabControl();
            this.initialJobsTab = new System.Windows.Forms.TabPage();
            this.helpMsg = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.JobsTabs.SuspendLayout();
            this.initialJobsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // workforceGroup
            // 
            this.workforceGroup.Location = new System.Drawing.Point(432, 27);
            this.workforceGroup.Name = "workforceGroup";
            this.workforceGroup.Size = new System.Drawing.Size(200, 355);
            this.workforceGroup.TabIndex = 0;
            this.workforceGroup.TabStop = false;
            this.workforceGroup.Text = "Workforce";
            this.workforceGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.workforceMenu,
            this.helpMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(644, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewJob,
            this.quit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // addNewJob
            // 
            this.addNewJob.Name = "addNewJob";
            this.addNewJob.Size = new System.Drawing.Size(152, 22);
            this.addNewJob.Text = "Add New Job";
            this.addNewJob.Click += new System.EventHandler(this.addNewJob_Click);
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(152, 22);
            this.quit.Text = "Quit";
            // 
            // workforceMenu
            // 
            this.workforceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMember,
            this.addNewRole,
            this.assignAdditionalRole});
            this.workforceMenu.Name = "workforceMenu";
            this.workforceMenu.Size = new System.Drawing.Size(74, 20);
            this.workforceMenu.Text = "Workforce";
            // 
            // addNewMember
            // 
            this.addNewMember.Name = "addNewMember";
            this.addNewMember.Size = new System.Drawing.Size(193, 22);
            this.addNewMember.Text = "Add New Member";
            this.addNewMember.Click += new System.EventHandler(this.addNewMember_Click);
            // 
            // addNewRole
            // 
            this.addNewRole.Name = "addNewRole";
            this.addNewRole.Size = new System.Drawing.Size(193, 22);
            this.addNewRole.Text = "Add New Role";
            this.addNewRole.Click += new System.EventHandler(this.addNewRole_Click);
            // 
            // assignAdditionalRole
            // 
            this.assignAdditionalRole.Name = "assignAdditionalRole";
            this.assignAdditionalRole.Size = new System.Drawing.Size(193, 22);
            this.assignAdditionalRole.Text = "Assign Additional Role";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.progressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 400);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(644, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(26, 17);
            this.status.Text = "Idle";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // JobsTabs
            // 
            this.JobsTabs.Controls.Add(this.initialJobsTab);
            this.JobsTabs.Location = new System.Drawing.Point(12, 27);
            this.JobsTabs.Name = "JobsTabs";
            this.JobsTabs.SelectedIndex = 0;
            this.JobsTabs.Size = new System.Drawing.Size(414, 355);
            this.JobsTabs.TabIndex = 3;
            // 
            // initialJobsTab
            // 
            this.initialJobsTab.Controls.Add(this.helpMsg);
            this.initialJobsTab.Location = new System.Drawing.Point(4, 22);
            this.initialJobsTab.Name = "initialJobsTab";
            this.initialJobsTab.Padding = new System.Windows.Forms.Padding(3);
            this.initialJobsTab.Size = new System.Drawing.Size(406, 329);
            this.initialJobsTab.TabIndex = 0;
            this.initialJobsTab.Text = "Jobs";
            this.initialJobsTab.UseVisualStyleBackColor = true;
            // 
            // helpMsg
            // 
            this.helpMsg.Location = new System.Drawing.Point(6, 6);
            this.helpMsg.Name = "helpMsg";
            this.helpMsg.ReadOnly = true;
            this.helpMsg.Size = new System.Drawing.Size(394, 317);
            this.helpMsg.TabIndex = 0;
            this.helpMsg.Text = resources.GetString("helpMsg.Text");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 422);
            this.Controls.Add(this.JobsTabs);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.workforceGroup);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Main";
            this.Text = "Team Manager";
            this.Enter += new System.EventHandler(this.Main_Enter);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.JobsTabs.ResumeLayout(false);
            this.initialJobsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox workforceGroup;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewJob;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.ToolStripMenuItem workforceMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewMember;
        private System.Windows.Forms.ToolStripMenuItem addNewRole;
        private System.Windows.Forms.ToolStripMenuItem assignAdditionalRole;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.TabPage initialJobsTab;
        private System.Windows.Forms.RichTextBox helpMsg;
        public System.Windows.Forms.TabControl JobsTabs;
    }
}

