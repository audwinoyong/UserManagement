namespace UserManagement
{
    partial class Form_NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NewUser));
            this.newUserScreenLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newUserScreenLbl
            // 
            this.newUserScreenLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newUserScreenLbl.AutoSize = true;
            this.newUserScreenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserScreenLbl.Location = new System.Drawing.Point(112, 26);
            this.newUserScreenLbl.Name = "newUserScreenLbl";
            this.newUserScreenLbl.Size = new System.Drawing.Size(101, 24);
            this.newUserScreenLbl.TabIndex = 5;
            this.newUserScreenLbl.Text = "New User";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(168, 271);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBtn.Location = new System.Drawing.Point(82, 271);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 17;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTxt.Location = new System.Drawing.Point(104, 102);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(200, 20);
            this.passwordTxt.TabIndex = 13;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usernameTxt.Location = new System.Drawing.Point(104, 76);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(200, 20);
            this.usernameTxt.TabIndex = 12;
            // 
            // passwordLbl
            // 
            this.passwordLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(29, 105);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(56, 13);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(29, 79);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(58, 13);
            this.usernameLbl.TabIndex = 7;
            this.usernameLbl.Text = "Username:";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameTxt.Location = new System.Drawing.Point(104, 128);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(200, 20);
            this.firstNameTxt.TabIndex = 14;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(29, 131);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.firstNameLbl.TabIndex = 9;
            this.firstNameLbl.Text = "First Name:";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTxt.Location = new System.Drawing.Point(104, 154);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(200, 20);
            this.lastNameTxt.TabIndex = 15;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(29, 157);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.lastNameLbl.TabIndex = 10;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirthPicker.CustomFormat = "  dd-MM-yyyy";
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(104, 180);
            this.dateOfBirthPicker.MaxDate = new System.DateTime(2017, 10, 16, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthPicker.TabIndex = 16;
            this.dateOfBirthPicker.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // dateOfBirthLbl
            // 
            this.dateOfBirthLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateOfBirthLbl.AutoSize = true;
            this.dateOfBirthLbl.Location = new System.Drawing.Point(29, 184);
            this.dateOfBirthLbl.Name = "dateOfBirthLbl";
            this.dateOfBirthLbl.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLbl.TabIndex = 11;
            this.dateOfBirthLbl.Text = "Date of Birth:";
            // 
            // errorLbl
            // 
            this.errorLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(29, 212);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLbl.Size = new System.Drawing.Size(275, 55);
            this.errorLbl.TabIndex = 0;
            // 
            // Form_NewUser
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(336, 305);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.dateOfBirthLbl);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.newUserScreenLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(352, 344);
            this.Name = "Form_NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User - User Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newUserScreenLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label dateOfBirthLbl;
        private System.Windows.Forms.Label errorLbl;
    }
}