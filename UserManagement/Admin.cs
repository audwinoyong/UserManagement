using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public enum AdminType
    {
        SuperAdmin,
        Moderator
    }
    class Admin : User
    {
        private AdminType adminType;

        public AdminType AdminType
        {
            get { return adminType; }
        }

        public Admin(string username, string password, string firstName, string lastName, int ratingsCount, double averageRatingAdmin, AdminType adminType)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.ratingsCount = ratingsCount;
            this.averageRating = averageRatingAdmin;
            this.adminType = adminType;
        }

        //methods 

        /// <summary>
        /// Writes all member variable of this Admin object (including those in the User base class) 
        /// to the end of the file passed in as a parameter and returns true if the write was successful.
        /// </summary>
        public bool WriteAdminToFile(System.IO.StreamWriter file)
        {
            //round down averageRating to 2 dcp.
            file.WriteLine("{0},{1},{2},{3},{4},{5},{6}",
                username, password, firstName, lastName, adminType, ratingsCount, Math.Floor(averageRating * 100) / 100);

            return true;
        }

        /// <summary>
        /// Overrides base class version. 
        /// Returns a string with username, first name, last name, and Admin type.
        /// </summary>
        public override string GetFullUserString()
        {
            return string.Format("{0, -15} {1, -15} {2, -15} {3, -15}", username, firstName, lastName, adminType.ToString());
        }
        
        /// <summary>
        /// Overrides the default ToString() to show in the CheckedListBox
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0} {1, -15} {2, -15}", GetFullUserString(), ratingsCount, averageRating);
        }
    }
}