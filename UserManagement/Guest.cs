using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    class Guest : User
    {
        private DateTime dateOfBirth;

        public Guest(string username, string password, string firstName, string lastName, int ratingsCount, double averageRating, DateTime dateOfBirth)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ratingsCount = ratingsCount;
            this.averageRating = averageRating;
            this.dateOfBirth = dateOfBirth;
        }

        //methods 

        /// <summary>
        /// Writes all member variable of this Guest object (including those in the User base class) 
        /// to the end of the file passed in as a parameter and returns true if the write was successful.
        /// </summary>
        public bool WriteGuestToFile(System.IO.StreamWriter file)
        {
            //round down averageRating to 2 dcp.
            file.WriteLine("{0},{1},{2},{3},{4},{5},{6}", 
                username, password, firstName, lastName, dateOfBirth.ToString("dd-MM-yyyy"), ratingsCount, Math.Floor(averageRating * 100) / 100);
            
            return true;
        }

        /// <summary>
        /// Overrides base class version. 
        /// Returns a string with first name, last name, and date of birth.
        /// </summary>
        public override string GetFullUserString()
        {
            return string.Format("{0, -15} {1, -15} {2, -15}", firstName, lastName, dateOfBirth.ToString("dd-MM-yyyy"));
        }

        /// <summary>
        /// Overrides the default ToString() to show in the CheckedListBox.
        /// If the logged-in user is a Guest, call base class GetShortUserString().
        /// Else if it is an Admin, call GetFullUserString().
        /// </summary>
        public override string ToString()
        {
            if (Form_UserList.userHandler.LoggedInUser is Guest)
            {
                return string.Format("{0} {1, -15} {2, -15}", GetShortUserString(), ratingsCount, averageRating);
            }
            else
            {
                return string.Format("{0} {1, -15} {2, -15}", GetFullUserString(), ratingsCount, averageRating);
            }

        }

    }
}
