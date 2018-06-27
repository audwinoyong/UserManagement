namespace UserManagement
{
    partial class Form_MakeUserAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MakeUserAdmin));
            this.cbAdminLevel = new System.Windows.Forms.ComboBox();
            this.makeUserAdminLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.adminLevelLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAdminLevel
            // 
            this.cbAdminLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAdminLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdminLevel.FormattingEnabled = true;
            this.cbAdminLevel.Location = new System.Drawing.Point(62, 137);
            this.cbAdminLevel.Name = "cbAdminLevel";
            this.cbAdminLevel.Size = new System.Drawing.Size(161, 21);
            this.cbAdminLevel.TabIndex = 0;
            // 
            // makeUserAdminLbl
            // 
            this.makeUserAdminLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.makeUserAdminLbl.AutoSize = true;
            this.makeUserAdminLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeUserAdminLbl.Location = new System.Drawing.Point(45, 26);
            this.makeUserAdminLbl.Name = "makeUserAdminLbl";
            this.makeUserAdminLbl.Size = new System.Drawing.Size(199, 24);
            this.makeUserAdminLbl.TabIndex = 18;
            this.makeUserAdminLbl.Text = "Make User(s) Admin";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(148, 218);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBtn.Location = new System.Drawing.Point(62, 218);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // adminLevelLbl
            // 
            this.adminLevelLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminLevelLbl.Location = new System.Drawing.Point(59, 90);
            this.adminLevelLbl.Name = "adminLevelLbl";
            this.adminLevelLbl.Size = new System.Drawing.Size(164, 29);
            this.adminLevelLbl.TabIndex = 19;
            this.adminLevelLbl.Text = "What admin level would you like to make this user(s)?";
            // 
            // Form_MakeUserAdmin
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.adminLevelLbl);
            this.Controls.Add(this.makeUserAdminLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cbAdminLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form_MakeUserAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make User(s) Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAdminLevel;
        private System.Windows.Forms.Label makeUserAdminLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label adminLevelLbl;
    }
}