using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserManagement
{
    public abstract class User
    {
        //variables
        protected string username, password, firstName, lastName;
        protected int ratingsCount;
        protected double averageRating;

        //properties
        public string Username
        {
            get { return username; }
        }
        public string Password
        {
            get { return password; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public int RatingsCount
        {
            get { return ratingsCount; }
        }
        public double AverageRating
        {
            get { return averageRating; }
        }

        //methods

        /// <summary>
        /// Check whether the username and password match.
        /// </summary>
        public bool CheckUserNameAndPassword(string username, string password)
        {
            return this.username.Equals(username) && this.password.Equals(password);
        }

        /// <summary>
        /// Returns a string containing username and first name only.
        /// </summary>
        public string GetShortUserString()
        {
            return string.Format("{0, -15} {1, -15}", username, firstName);
        }

        /// <summary>
        /// Updates the average rating with the new rating.
        /// </summary>
        public void AddRating(int rating)
        {
            //formula: average(new) = sum(new) / ratingsCount(new)
            //         average(new) = [average(old) * ratingsCount(old) + rating(new)] / (ratingsCount(new))

            averageRating = (averageRating * ratingsCount + rating) / (ratingsCount + 1);

            //round down to 2 dcp
            averageRating = Math.Floor(averageRating * 100) / 100;

            ratingsCount++;
        }

        /// <summary>
        /// Checks if the username entered is the same as User username.
        /// Return true if match, false otherwise.
        /// </summary>
        public bool SameUsername(string username)
        {
            return this.username.Equals(username);
        }

        /// <summary>
        /// Abstract method.
        /// </summary>
        public abstract string GetFullUserString();

    }
}