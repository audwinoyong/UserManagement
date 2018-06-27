using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class Form_UserList : Form
    {
        public static UserHandler userHandler;

        public static bool ratingIsProvided;
        public static int chosenRating;
        public static bool isMadeAdmin;
        public static AdminType chosenAdminType;

        public Form_UserList(UserHandler loggedInUserHandler)
        {
            InitializeComponent();

            userHandler = loggedInUserHandler;

            CheckLoggedInUserType();
            ShowUsers();

            SetAllItemsAnchor();
        }

        /// <summary>
        /// Set the form window depending on the logged-in user type.
        /// </summary>
        private void CheckLoggedInUserType()
        {
            //is a Guest
            if (userHandler.LoggedInUser is Guest)
            {
                this.Size = new Size(663, 395);
                this.MinimumSize = new Size(663, 395);

                adminGrpBox.Visible = false;
                makeUserAdminBtn.Visible = false;

                makeUserAdminBtn.Location = new Point(12, 324);
                provideRatingBtn.Location = new Point(259, 324);
                logOutBtn.Location = new Point(498, 324);

                userTypeLbl.Text = "(Guest)";

                ShowGuestHeaderText();
            }
            //is an Admin
            else
            {
                this.MinimumSize = new Size(663, 559);

                ShowAdminHeaderText();

                //AdminType is Moderator
                if (((Admin)userHandler.LoggedInUser).AdminType == AdminType.Moderator)
                {
                    makeUserAdminBtn.Visible = false;

                    userTypeLbl.Text = string.Format("({0})", ((Admin)userHandler.LoggedInUser).AdminType);

                }
                //AdminType is SuperAdmin
                else
                {
                    userTypeLbl.Text = string.Format("({0})", ((Admin)userHandler.LoggedInUser).AdminType);
                }
            }
        }

        /// <summary>
        /// Show the column header text for Guest form screen.
        /// </summary>
        private void ShowGuestHeaderText()
        {
            loggedInUserHeaderLbl.Text = string.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}", 
                "First Name", "Last Name", "Date of Birth", "Rating Count", "Average Rating");
            loggedInUserLbl.Text = string.Format("{0} {1, -15} {2, -15}",
                userHandler.LoggedInUser.GetFullUserString(), userHandler.LoggedInUser.RatingsCount, userHandler.LoggedInUser.AverageRating);

            guestUserHeaderLbl.Text = string.Format("{0, -15} {1, -15} {2, -15} {3, -15}", 
                "Username", "First Name", "Rating Count", "Average Rating");
        }

        /// <summary>
        /// Show the column header text for Admin form screen.
        /// </summary>
        private void ShowAdminHeaderText()
        {
            loggedInUserHeaderLbl.Text = string.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5, -15}", 
                "Username", "First Name", "Last Name", "Admin Type", "Rating Count", "Average Rating");
            loggedInUserLbl.Text = string.Format("{0} {1, -15} {2, -15}",
                userHandler.LoggedInUser.GetFullUserString(), userHandler.LoggedInUser.RatingsCount, userHandler.LoggedInUser.AverageRating);

            guestUserHeaderLbl.Text = string.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}",
                "First Name", "Last Name", "Date of Birth", "Rating Count", "Average Rating");
            adminUserHeaderLbl.Text = string.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5, -15}",
                "Username", "First Name", "Last Name", "Admin Type", "Rating Count", "Average Rating");
        }

        /// <summary>
        /// Populate and show the Guest and Admin in both CheckedListBoxes.
        /// </summary>
        private void ShowUsers()
        {
            for (int i = 0; i < userHandler.Users.Count; i++)
            {
                if (userHandler.Users[i].Equals(userHandler.LoggedInUser))
                {
                    continue;
                }
                else
                {
                    if (userHandler.Users[i] is Guest)
                    {
                        guestListChkBoxes.Items.Add(userHandler.Users[i]);
                    }
                    else if (userHandler.Users[i] is Admin)
                    {
                        adminListChkBoxes.Items.Add(userHandler.Users[i]);
                    }
                }
            }
        }

        /// <summary>
        /// Set items anchor for all controls in the form.
        /// </summary>
        private void SetAllItemsAnchor()
        {
            foreach (Control item in Controls)
            {
                item.Anchor = AnchorStyles.None;
            }
        }

        private void provideRatingBtn_Click(object sender, EventArgs e)
        {
            Form_UserRating form_UserRating = new Form_UserRating();
            form_UserRating.ShowDialog();

            if (ratingIsProvided)
            {
                AddAllRatings(guestListChkBoxes);
                AddAllRatings(adminListChkBoxes);

                //UncheckAllItems(guestListChkBoxes);
                //UncheckAllItems(adminListChkBoxes);

                //save
                userHandler.SaveAllUsers();
            }
        }

        /// <summary>
        /// Add the rating for all checked users in the CheckedListBox.
        /// </summary>
        private void AddAllRatings(CheckedListBox clb)
        {
            foreach (User checkedUser in clb.CheckedItems)
            {
                //add chosen rating to each selected users
                checkedUser.AddRating(chosenRating);
            }
            //refresh the view
            clb.Refresh();
        }

        /// <summary>
        /// Uncheck all the items the CheckedListBox.
        /// </summary>
        private void UncheckAllItems(CheckedListBox clb)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                //set all items check state to false
                clb.SetItemChecked(i, false);
            }
        }

        private void makeUserAdminBtn_Click(object sender, EventArgs e)
        {
            Form_MakeUserAdmin form_makeUserAdmin = new Form_MakeUserAdmin();
            form_makeUserAdmin.ShowDialog();
            
            //submit button is clicked
            if (isMadeAdmin)
            {
                MakeUserAdmin(guestListChkBoxes);
                MakeUserAdmin(adminListChkBoxes);
                ShowUsers();

                //disable the buttons
                makeUserAdminBtn.Enabled = false;
                provideRatingBtn.Enabled = false;

                //save
                userHandler.SaveAllUsers();
            }
        }

        /// <summary>
        /// Make all selected users to the selected admin type,
        /// by removing the selected users and add them back as an Admin.
        /// </summary>
        private void MakeUserAdmin(CheckedListBox clb)
        {
            for (int i = 0; i < clb.CheckedItems.Count; i++)
            {
                string username = ((User)clb.CheckedItems[i]).Username;
                string password = ((User)clb.CheckedItems[i]).Password;
                string firstName = ((User)clb.CheckedItems[i]).FirstName;
                string lastName = ((User)clb.CheckedItems[i]).LastName;
                int ratingsCount = ((User)clb.CheckedItems[i]).RatingsCount;
                double averageRating = ((User)clb.CheckedItems[i]).AverageRating;

                Admin admin = new Admin(username, password, firstName, lastName, ratingsCount, averageRating, chosenAdminType);
                userHandler.Users.Remove((User)clb.CheckedItems[i]);
                userHandler.Users.Add(admin);
            }
            clb.Items.Clear();
        }

        private void guestListChkBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guestListChkBoxes.CheckedItems.Count > 0)
            {
                makeUserAdminBtn.Enabled = true;
                provideRatingBtn.Enabled = true;
            }
            else
            {
                makeUserAdminBtn.Enabled = false;
                provideRatingBtn.Enabled = false;
            }
        }

        private void adminListChkBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminListChkBoxes.CheckedItems.Count > 0)
            {
                makeUserAdminBtn.Enabled = true;
                provideRatingBtn.Enabled = true;
            }
            else
            {
                makeUserAdminBtn.Enabled = false;
                provideRatingBtn.Enabled = false;
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
