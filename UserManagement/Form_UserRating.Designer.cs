namespace UserManagement
{
    partial class Form_UserRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UserRating));
            this.ratingGrpBox = new System.Windows.Forms.GroupBox();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.userRatingLbl = new System.Windows.Forms.Label();
            this.ratingGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ratingGrpBox
            // 
            this.ratingGrpBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingGrpBox.Controls.Add(this.rb0);
            this.ratingGrpBox.Controls.Add(this.rb1);
            this.ratingGrpBox.Controls.Add(this.rb2);
            this.ratingGrpBox.Controls.Add(this.rb3);
            this.ratingGrpBox.Controls.Add(this.rb4);
            this.ratingGrpBox.Controls.Add(this.rb5);
            this.ratingGrpBox.Location = new System.Drawing.Point(46, 87);
            this.ratingGrpBox.Name = "ratingGrpBox";
            this.ratingGrpBox.Size = new System.Drawing.Size(194, 85);
            this.ratingGrpBox.TabIndex = 6;
            this.ratingGrpBox.TabStop = false;
            this.ratingGrpBox.Text = "Choose a rating out of 5:";
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb0.Location = new System.Drawing.Point(30, 32);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(17, 30);
            this.rb0.TabIndex = 0;
            this.rb0.TabStop = true;
            this.rb0.Text = "0";
            this.rb0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1.Location = new System.Drawing.Point(53, 32);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(17, 30);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb2.Location = new System.Drawing.Point(76, 32);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(17, 30);
            this.rb2.TabIndex = 2;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb3.Location = new System.Drawing.Point(99, 32);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(17, 30);
            this.rb3.TabIndex = 3;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb4.Location = new System.Drawing.Point(122, 32);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(17, 30);
            this.rb4.TabIndex = 4;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb5.Location = new System.Drawing.Point(145, 32);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(17, 30);
            this.rb5.TabIndex = 5;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBtn.Location = new System.Drawing.Point(62, 218);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "&Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(148, 218);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // userRatingLbl
            // 
            this.userRatingLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userRatingLbl.AutoSize = true;
            this.userRatingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRatingLbl.Location = new System.Drawing.Point(82, 26);
            this.userRatingLbl.Name = "userRatingLbl";
            this.userRatingLbl.Size = new System.Drawing.Size(118, 24);
            this.userRatingLbl.TabIndex = 15;
            this.userRatingLbl.Text = "User Rating";
            // 
            // Form_UserRating
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.userRatingLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.ratingGrpBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form_UserRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Rating";
            this.ratingGrpBox.ResumeLayout(false);
            this.ratingGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ratingGrpBox;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label userRatingLbl;
    }
}