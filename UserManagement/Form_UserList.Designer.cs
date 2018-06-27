namespace UserManagement
{
    partial class Form_UserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserList));
            this.provideRatingBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.userListScreenLbl = new System.Windows.Forms.Label();
            this.makeUserAdminBtn = new System.Windows.Forms.Button();
            this.loggedInUserLbl = new System.Windows.Forms.Label();
            this.userTypeLbl = new System.Windows.Forms.Label();
            this.guestListChkBoxes = new System.Windows.Forms.CheckedListBox();
            this.adminListChkBoxes = new System.Windows.Forms.CheckedListBox();
            this.guestGrpBox = new System.Windows.Forms.GroupBox();
            this.guestUserHeaderLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loggedInUserHeaderLbl = new System.Windows.Forms.Label();
            this.adminGrpBox = new System.Windows.Forms.GroupBox();
            this.adminUserHeaderLbl = new System.Windows.Forms.Label();
            this.logoPicBoxLeft = new System.Windows.Forms.PictureBox();
            this.logoPicBoxRight = new System.Windows.Forms.PictureBox();
            this.guestGrpBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.adminGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBoxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // provideRatingBtn
            // 
            this.provideRatingBtn.Enabled = false;
            this.provideRatingBtn.Location = new System.Drawing.Point(259, 488);
            this.provideRatingBtn.Name = "provideRatingBtn";
            this.provideRatingBtn.Size = new System.Drawing.Size(139, 23);
            this.provideRatingBtn.TabIndex = 1;
            this.provideRatingBtn.Text = "Provide &Rating to User(s)";
            this.provideRatingBtn.UseVisualStyleBackColor = true;
            this.provideRatingBtn.Click += new System.EventHandler(this.provideRatingBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(498, 488);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(139, 23);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.Text = "Log &Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // userListScreenLbl
            // 
            this.userListScreenLbl.AutoSize = true;
            this.userListScreenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListScreenLbl.Location = new System.Drawing.Point(277, 26);
            this.userListScreenLbl.Name = "userListScreenLbl";
            this.userListScreenLbl.Size = new System.Drawing.Size(90, 24);
            this.userListScreenLbl.TabIndex = 6;
            this.userListScreenLbl.Text = "User List";
            // 
            // makeUserAdminBtn
            // 
            this.makeUserAdminBtn.Enabled = false;
            this.makeUserAdminBtn.Location = new System.Drawing.Point(12, 488);
            this.makeUserAdminBtn.Name = "makeUserAdminBtn";
            this.makeUserAdminBtn.Size = new System.Drawing.Size(139, 23);
            this.makeUserAdminBtn.TabIndex = 7;
            this.makeUserAdminBtn.Text = "Make User(s) &Admin";
            this.makeUserAdminBtn.UseVisualStyleBackColor = true;
            this.makeUserAdminBtn.Click += new System.EventHandler(this.makeUserAdminBtn_Click);
            // 
            // loggedInUserLbl
            // 
            this.loggedInUserLbl.AutoSize = true;
            this.loggedInUserLbl.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInUserLbl.Location = new System.Drawing.Point(23, 29);
            this.loggedInUserLbl.Name = "loggedInUserLbl";
            this.loggedInUserLbl.Size = new System.Drawing.Size(43, 13);
            this.loggedInUserLbl.TabIndex = 8;
            this.loggedInUserLbl.Text = "Detail";
            // 
            // userTypeLbl
            // 
            this.userTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLbl.Location = new System.Drawing.Point(255, 50);
            this.userTypeLbl.Name = "userTypeLbl";
            this.userTypeLbl.Size = new System.Drawing.Size(140, 24);
            this.userTypeLbl.TabIndex = 9;
            this.userTypeLbl.Text = "(Type)";
            this.userTypeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guestListChkBoxes
            // 
            this.guestListChkBoxes.BackColor = System.Drawing.SystemColors.Control;
            this.guestListChkBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guestListChkBoxes.CheckOnClick = true;
            this.guestListChkBoxes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestListChkBoxes.FormattingEnabled = true;
            this.guestListChkBoxes.HorizontalScrollbar = true;
            this.guestListChkBoxes.Location = new System.Drawing.Point(6, 32);
            this.guestListChkBoxes.Name = "guestListChkBoxes";
            this.guestListChkBoxes.Size = new System.Drawing.Size(612, 107);
            this.guestListChkBoxes.TabIndex = 0;
            this.guestListChkBoxes.SelectedIndexChanged += new System.EventHandler(this.guestListChkBoxes_SelectedIndexChanged);
            // 
            // adminListChkBoxes
            // 
            this.adminListChkBoxes.BackColor = System.Drawing.SystemColors.Control;
            this.adminListChkBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminListChkBoxes.CheckOnClick = true;
            this.adminListChkBoxes.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminListChkBoxes.FormattingEnabled = true;
            this.adminListChkBoxes.HorizontalScrollbar = true;
            this.adminListChkBoxes.Location = new System.Drawing.Point(6, 32);
            this.adminListChkBoxes.Name = "adminListChkBoxes";
            this.adminListChkBoxes.Size = new System.Drawing.Size(612, 107);
            this.adminListChkBoxes.TabIndex = 1;
            this.adminListChkBoxes.SelectedIndexChanged += new System.EventHandler(this.adminListChkBoxes_SelectedIndexChanged);
            // 
            // guestGrpBox
            // 
            this.guestGrpBox.AutoSize = true;
            this.guestGrpBox.Controls.Add(this.guestUserHeaderLbl);
            this.guestGrpBox.Controls.Add(this.guestListChkBoxes);
            this.guestGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestGrpBox.Location = new System.Drawing.Point(13, 160);
            this.guestGrpBox.Name = "guestGrpBox";
            this.guestGrpBox.Size = new System.Drawing.Size(624, 158);
            this.guestGrpBox.TabIndex = 10;
            this.guestGrpBox.TabStop = false;
            this.guestGrpBox.Text = "Guest:";
            // 
            // guestUserHeaderLbl
            // 
            this.guestUserHeaderLbl.AutoSize = true;
            this.guestUserHeaderLbl.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestUserHeaderLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guestUserHeaderLbl.Location = new System.Drawing.Point(23, 16);
            this.guestUserHeaderLbl.Name = "guestUserHeaderLbl";
            this.guestUserHeaderLbl.Size = new System.Drawing.Size(85, 13);
            this.guestUserHeaderLbl.TabIndex = 11;
            this.guestUserHeaderLbl.Text = "Column Header";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.loggedInUserHeaderLbl);
            this.groupBox2.Controls.Add(this.loggedInUserLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 58);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logged-in User:";
            // 
            // loggedInUserHeaderLbl
            // 
            this.loggedInUserHeaderLbl.AutoSize = true;
            this.loggedInUserHeaderLbl.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInUserHeaderLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loggedInUserHeaderLbl.Location = new System.Drawing.Point(23, 16);
            this.loggedInUserHeaderLbl.Name = "loggedInUserHeaderLbl";
            this.loggedInUserHeaderLbl.Size = new System.Drawing.Size(85, 13);
            this.loggedInUserHeaderLbl.TabIndex = 12;
            this.loggedInUserHeaderLbl.Text = "Column Header";
            // 
            // adminGrpBox
            // 
            this.adminGrpBox.AutoSize = true;
            this.adminGrpBox.Controls.Add(this.adminUserHeaderLbl);
            this.adminGrpBox.Controls.Add(this.adminListChkBoxes);
            this.adminGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminGrpBox.Location = new System.Drawing.Point(13, 324);
            this.adminGrpBox.Name = "adminGrpBox";
            this.adminGrpBox.Size = new System.Drawing.Size(624, 158);
            this.adminGrpBox.TabIndex = 12;
            this.adminGrpBox.TabStop = false;
            this.adminGrpBox.Text = "Admin:";
            // 
            // adminUserHeaderLbl
            // 
            this.adminUserHeaderLbl.AutoSize = true;
            this.adminUserHeaderLbl.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserHeaderLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminUserHeaderLbl.Location = new System.Drawing.Point(23, 16);
            this.adminUserHeaderLbl.Name = "adminUserHeaderLbl";
            this.adminUserHeaderLbl.Size = new System.Drawing.Size(85, 13);
            this.adminUserHeaderLbl.TabIndex = 12;
            this.adminUserHeaderLbl.Text = "Column Header";
            // 
            // logoPicBoxLeft
            // 
            this.logoPicBoxLeft.Image = global::UserManagement.Properties.Resources.User_Rating_PNG;
            this.logoPicBoxLeft.Location = new System.Drawing.Point(199, 26);
            this.logoPicBoxLeft.Name = "logoPicBoxLeft";
            this.logoPicBoxLeft.Size = new System.Drawing.Size(50, 50);
            this.logoPicBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBoxLeft.TabIndex = 13;
            this.logoPicBoxLeft.TabStop = false;
            // 
            // logoPicBoxRight
            // 
            this.logoPicBoxRight.Image = global::UserManagement.Properties.Resources.User_Rating_PNG;
            this.logoPicBoxRight.Location = new System.Drawing.Point(401, 26);
            this.logoPicBoxRight.Name = "logoPicBoxRight";
            this.logoPicBoxRight.Size = new System.Drawing.Size(50, 50);
            this.logoPicBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBoxRight.TabIndex = 14;
            this.logoPicBoxRight.TabStop = false;
            // 
            // Form_UserList
            // 
            this.AcceptButton = this.provideRatingBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 520);
            this.Controls.Add(this.logoPicBoxRight);
            this.Controls.Add(this.logoPicBoxLeft);
            this.Controls.Add(this.makeUserAdminBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.provideRatingBtn);
            this.Controls.Add(this.adminGrpBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guestGrpBox);
            this.Controls.Add(this.userTypeLbl);
            this.Controls.Add(this.userListScreenLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_UserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User List (Type) - User Management";
            this.guestGrpBox.ResumeLayout(false);
            this.guestGrpBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.adminGrpBox.ResumeLayout(false);
            this.adminGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBoxRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button provideRatingBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label userListScreenLbl;
        private System.Windows.Forms.Button makeUserAdminBtn;
        private System.Windows.Forms.Label loggedInUserLbl;
        private System.Windows.Forms.Label userTypeLbl;
        private System.Windows.Forms.CheckedListBox guestListChkBoxes;
        private System.Windows.Forms.CheckedListBox adminListChkBoxes;
        private System.Windows.Forms.GroupBox guestGrpBox;
        private System.Windows.Forms.Label guestUserHeaderLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label loggedInUserHeaderLbl;
        private System.Windows.Forms.GroupBox adminGrpBox;
        private System.Windows.Forms.Label adminUserHeaderLbl;
        private System.Windows.Forms.PictureBox logoPicBoxLeft;
        private System.Windows.Forms.PictureBox logoPicBoxRight;
    }
}