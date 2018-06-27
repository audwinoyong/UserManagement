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
    public partial class Form_Login : Form
    {
        public static UserHandler userHandler = new UserHandler();

        public static string usernameString;
        public static string passwordString;

        public Form_Login()
        {
            InitializeComponent();

            //load users from both text files
            userHandler.LoadAllUsers();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //find and match the user details
            User validUser = userHandler.ValidateLogin(usernameTxt.Text, passwordTxt.Text);

            if (validUser != null)
            {
                userHandler.LoggedInUser = validUser;
                
                this.Hide();
                Form_UserList form_UserList = new Form_UserList(userHandler);

                //set User List Form title depending on user type
                if (userHandler.LoggedInUser is Guest)
                {
                    form_UserList.Text = "User List (Guest) - User Management";
                }
                else if (userHandler.LoggedInUser is Admin)
                {
                    form_UserList.Text = string.Format("User List ({0}) - User Management", ((Admin)userHandler.LoggedInUser).AdminType);
                }

                form_UserList.ShowDialog();
                this.Show();

                //clear the textboxes text
                usernameTxt.Clear();
                passwordTxt.Clear();

                //set focus on the username textbox
                usernameTxt.Focus();
            }
            else
            {
                MessageBox.Show("Login Failure" + Environment.NewLine + "(unknown username or incorrect password)", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            //hides the login form
            this.Hide();
            Form_NewUser form_newUser = new Form_NewUser(usernameTxt.Text, passwordTxt.Text);
            form_newUser.ShowDialog();

            //get the username and password passed from New User Form
            usernameTxt.Text = usernameString;
            passwordTxt.Text = passwordString;
            
            this.Show();

            //set focus on the username textbox
            usernameTxt.Focus();
        }

    }
}
