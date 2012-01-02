namespace Team_Manager
{
    partial class NewJobForm
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
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.calander = new System.Windows.Forms.MonthCalendar();
            this.reqWorkforceGroup = new System.Windows.Forms.GroupBox();
            this.jobTitleTxt = new System.Windows.Forms.TextBox();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.availableRolesDrop = new System.Windows.Forms.ComboBox();
            this.addReqBtn = new System.Windows.Forms.Button();
            this.currentReqWorkforcePanel = new System.Windows.Forms.TableLayoutPanel();
            this.reqWorkforceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(50, 13);
            this.jobTitleLabel.TabIndex = 0;
            this.jobTitleLabel.Text = "Job Title:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(11, 34);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location:";
            // 
            // calander
            // 
            this.calander.Location = new System.Drawing.Point(14, 56);
            this.calander.Name = "calander";
            this.calander.TabIndex = 2;
            // 
            // reqWorkforceGroup
            // 
            this.reqWorkforceGroup.Controls.Add(this.currentReqWorkforcePanel);
            this.reqWorkforceGroup.Controls.Add(this.addReqBtn);
            this.reqWorkforceGroup.Controls.Add(this.availableRolesDrop);
            this.reqWorkforceGroup.Location = new System.Drawing.Point(15, 230);
            this.reqWorkforceGroup.Name = "reqWorkforceGroup";
            this.reqWorkforceGroup.Size = new System.Drawing.Size(227, 234);
            this.reqWorkforceGroup.TabIndex = 3;
            this.reqWorkforceGroup.TabStop = false;
            this.reqWorkforceGroup.Text = "Required Workforce";
            // 
            // jobTitleTxt
            // 
            this.jobTitleTxt.Location = new System.Drawing.Point(68, 6);
            this.jobTitleTxt.Name = "jobTitleTxt";
            this.jobTitleTxt.Size = new System.Drawing.Size(174, 20);
            this.jobTitleTxt.TabIndex = 4;
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(68, 32);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(174, 20);
            this.locationTxt.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(167, 470);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(15, 470);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // availableRolesDrop
            // 
            this.availableRolesDrop.FormattingEnabled = true;
            this.availableRolesDrop.Location = new System.Drawing.Point(6, 19);
            this.availableRolesDrop.Name = "availableRolesDrop";
            this.availableRolesDrop.Size = new System.Drawing.Size(134, 21);
            this.availableRolesDrop.TabIndex = 0;
            // 
            // addReqBtn
            // 
            this.addReqBtn.Location = new System.Drawing.Point(146, 19);
            this.addReqBtn.Name = "addReqBtn";
            this.addReqBtn.Size = new System.Drawing.Size(75, 23);
            this.addReqBtn.TabIndex = 1;
            this.addReqBtn.Text = "Add";
            this.addReqBtn.UseVisualStyleBackColor = true;
            // 
            // currentReqWorkforcePanel
            // 
            this.currentReqWorkforcePanel.ColumnCount = 2;
            this.currentReqWorkforcePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.currentReqWorkforcePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.currentReqWorkforcePanel.Location = new System.Drawing.Point(0, 51);
            this.currentReqWorkforcePanel.Name = "currentReqWorkforcePanel";
            this.currentReqWorkforcePanel.RowCount = 2;
            this.currentReqWorkforcePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.currentReqWorkforcePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.currentReqWorkforcePanel.Size = new System.Drawing.Size(226, 182);
            this.currentReqWorkforcePanel.TabIndex = 2;
            // 
            // NewJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 504);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.jobTitleTxt);
            this.Controls.Add(this.reqWorkforceGroup);
            this.Controls.Add(this.calander);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.jobTitleLabel);
            this.Name = "NewJobForm";
            this.Text = "Add New Job";
            this.Load += new System.EventHandler(this.NewJobForm_Load);
            this.reqWorkforceGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.MonthCalendar calander;
        private System.Windows.Forms.GroupBox reqWorkforceGroup;
        private System.Windows.Forms.TextBox jobTitleTxt;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TableLayoutPanel currentReqWorkforcePanel;
        private System.Windows.Forms.Button addReqBtn;
        private System.Windows.Forms.ComboBox availableRolesDrop;
    }
}