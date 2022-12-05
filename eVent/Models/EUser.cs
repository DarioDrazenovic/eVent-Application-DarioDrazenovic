using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eVent.Models
{
    public class EUser
    {
        public EUser(int IDEUser, string email, string password, string firstName, string lastName, bool admin)
        {
            this.IDEuser = IDEUser;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Admin = admin;
        }

        public int IDEuser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Admin { get; set; }
    }
}