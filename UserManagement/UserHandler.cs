using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserManagement
{
    public class UserHandler
    {
        //variables
        private List<User> users = new List<User>(); //list of User objects
        private User loggedInUser;

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public User LoggedInUser
        {
            get { return loggedInUser; }
            set { loggedInUser = value; }
        }

        //methods

        /// <summary>
        /// Load all user data from “Guests.txt” and “Admins.txt” plain text files
        /// and stores them in the User List member variable.
        /// </summary>
        public bool LoadAllUsers()
        {
            LoadUsers("Guests.txt");
            LoadUsers("Admin.txt");

            return true;
        }

        /// <summary>
        /// Load users from the specified text file passed in as a parameter.
        /// </summary>
        private void LoadUsers(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Unable to find and load file - ", filename);
            }

            StreamReader file = new StreamReader(filename);

            while (!file.EndOfStream)
            {
                string[] values = file.ReadLine().Split(',');

                int ratingsCount;

                if(!Int32.TryParse(values[5], out ratingsCount))
                {
                    throw new Exception("Invalid ratings count in " + filename);
                }

                double averageRating;

                if (!Double.TryParse(values[6], out averageRating))
                {
                    throw new Exception("Invalid average rating in " + filename);
                }

                //checks which file is being read
                if (filename.Equals("Guests.txt"))
                {
                    DateTime dateOfBirth;

                    if (!DateTime.TryParse(values[4], out dateOfBirth))
                    {
                        throw new Exception("Invalid date of birth in " + filename);
                    }

                    Guest guest = new Guest(values[0], values[1], values[2], values[3], ratingsCount, averageRating, dateOfBirth);
                    users.Add(guest);
                }
                else if (filename.Equals("Admin.txt"))
                {
                    AdminType adminType;

                    if (!Enum.TryParse(values[4], out adminType))
                    {
                        throw new Exception("Invalid admin type in " + filename);
                    }

                    Admin admin = new Admin(values[0], values[1], values[2], values[3], ratingsCount, averageRating, adminType);
                    users.Add(admin);
                }
            }
            file.Close();
        }

        /// <summary>
        /// Save all user data to “Guests.txt” and “Admins.txt” plain txt files.
        /// </summary>
        public bool SaveAllUsers()
        {
            //overwrite lines in the text files
            StreamWriter guestStreamWriter = new StreamWriter("Guests.txt");
            StreamWriter adminStreamWriter = new StreamWriter("Admin.txt");

            foreach (User user in users)
            {
                if (user is Guest)
                {
                    ((Guest)user).WriteGuestToFile(guestStreamWriter);
                }
                else if (user is Admin)
                {
                    ((Admin)user).WriteAdminToFile(adminStreamWriter);
                }
            }
            guestStreamWriter.Flush();
            adminStreamWriter.Flush();
            guestStreamWriter.Close();
            adminStreamWriter.Close();

            return true;
        }

        /// <summary>
        /// Validate the username and password entered.
        /// Returns the validated user if match, otherwise returns null.
        /// </summary>
        public User ValidateLogin(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.CheckUserNameAndPassword(username, password))
                {
                    return user;
                }
            }
            return null;
        }

        /// <summary>
        /// Returns true if username already exists, returns false otherwise.
        /// </summary>
        public bool UsernameExits(string username)
        {
            foreach (User user in users)
            {
                if (user.SameUsername(username))
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
