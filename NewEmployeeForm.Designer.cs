namespace Team_Manager
{
    partial class NewEmployeeForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.employeeNameTxt = new System.Windows.Forms.TextBox();
            this.rolesLabel = new System.Windows.Forms.Label();
            this.AvailableRolesDrop = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // employeeNameTxt
            // 
            this.employeeNameTxt.Location = new System.Drawing.Point(56, 23);
            this.employeeNameTxt.Name = "employeeNameTxt";
            this.employeeNameTxt.Size = new System.Drawing.Size(193, 20);
            this.employeeNameTxt.TabIndex = 1;
            // 
            // rolesLabel
            // 
            this.rolesLabel.AutoSize = true;
            this.rolesLabel.Location = new System.Drawing.Point(255, 26);
            this.rolesLabel.Name = "rolesLabel";
            this.rolesLabel.Size = new System.Drawing.Size(32, 13);
            this.rolesLabel.TabIndex = 2;
            this.rolesLabel.Text = "Role:";
            // 
            // AvailableRolesDrop
            // 
            this.AvailableRolesDrop.FormattingEnabled = true;
            this.AvailableRolesDrop.Location = new System.Drawing.Point(293, 23);
            this.AvailableRolesDrop.Name = "AvailableRolesDrop";
            this.AvailableRolesDrop.Size = new System.Drawing.Size(137, 21);
            this.AvailableRolesDrop.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 63);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(106, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(293, 63);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 98);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.AvailableRolesDrop);
            this.Controls.Add(this.rolesLabel);
            this.Controls.Add(this.employeeNameTxt);
            this.Controls.Add(this.nameLabel);
            this.Name = "NewEmployeeForm";
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox employeeNameTxt;
        private System.Windows.Forms.Label rolesLabel;
        private System.Windows.Forms.ComboBox AvailableRolesDrop;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
    }
}