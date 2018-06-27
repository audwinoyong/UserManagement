using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UserManagement
{
    public partial class Form_NewUser : Form
    {
        public Form_NewUser(string username, string password)
        {
            InitializeComponent();
            usernameTxt.Text = username;
            passwordTxt.Text = password;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //data formats are correct
            if (FormatIsCorrect())
            {
                //username is unique (username does not exists)
                if (!Form_Login.userHandler.UsernameExits(usernameTxt.Text))
                {
                    errorLbl.Text = "";

                    //add the new user to the user list
                    Form_Login.userHandler.Users.Add(new Guest(usernameTxt.Text, passwordTxt.Text, firstNameTxt.Text, lastNameTxt.Text, 0, 0.00, dateOfBirthPicker.Value));

                    Form_Login.usernameString = usernameTxt.Text;
                    Form_Login.passwordString = passwordTxt.Text;

                    //save
                    Form_Login.userHandler.SaveAllUsers();

                    this.Close();
                }
                //username already in use
                else
                {
                    errorLbl.Text = "Username already existed.";
                }
            }
        }

        /// <summary>
        /// Checks if all the formats are correct.
        /// </summary>
        private bool FormatIsCorrect()
        {
            if (ValidLength() && ValidUsernameAndPasswordFormat() && ValidNamesFormat())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if all the fields length have a minimum of 2 characters.
        /// </summary>
        private bool ValidLength()
        {
            if (usernameTxt.Text.Length > 1 && passwordTxt.Text.Length > 1 && firstNameTxt.Text.Length > 1 && lastNameTxt.Text.Length > 1)
            {
                return true;
            }
            else
            {
                errorLbl.Text = "All text fields must have a minimum of 2 characters.";
                return false;
            }
        }

        /// <summary>
        /// Checks if the format of username and password are correct.
        /// </summary>
        private bool ValidUsernameAndPasswordFormat()
        {
            //every character from the start to the end is a letter or number.
            string pattern = "^[a-zA-Z0-9]+$";

            Match usernameMatch = Regex.Match(usernameTxt.Text, pattern);
            Match passwordMatch = Regex.Match(passwordTxt.Text, pattern);

            if (usernameMatch.Success && passwordMatch.Success)
            {
                return true;
            }
            else
            {
                errorLbl.Text = "Username and Password can only have English alphabet characters and numbers." + Environment.NewLine +
                    "No symbols or spaces are allowed.";
                return false;
            }
        }

        /// <summary>
        /// Checks if the format of first name and last name are correct.
        /// </summary>
        private bool ValidNamesFormat()
        {
            //every character from the start to the end is a letter. Starts with a capital letter.
            string pattern = "^[A-Z][a-zA-Z]+$";

            Match firstNameMatch = Regex.Match(firstNameTxt.Text, pattern);
            Match lastNameMatch = Regex.Match(lastNameTxt.Text, pattern);

            if (firstNameMatch.Success && lastNameMatch.Success)
            {
                return true;
            }
            else
            {
                errorLbl.Text = "First Name and Last Name can only have English alphabet characters and must start with a capital letter." + Environment.NewLine + 
                    "No symbols or spaces are allowed.";
                return false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Form_Login.usernameString = null;
            Form_Login.passwordString = null;

            this.Close();
        }

    }
}
