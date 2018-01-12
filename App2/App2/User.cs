using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SQLite;

namespace App2
{
    public class User
    {
        [PrimaryKey, AutoIncrement]

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public User() { }

        public User(string Username, string Password, string Email)
        {
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
        }

        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals("") && !this.Email.Equals(""))
            {
                if (App.UserDatabase.VerifyUser(this))
                    return true;
                else
                {
                    Debug.WriteLine("User: ");
                    Debug.WriteLine(this.Username.ToString());
                    Debug.WriteLine("Password: ");
                    Debug.WriteLine(this.Password.ToString());
                    Debug.WriteLine("Email: ");
                    Debug.WriteLine(this.Email.ToString());

                    return false;
                }
            }
            else
                return false;
        }
    }
}
