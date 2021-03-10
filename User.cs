using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    public class User : Person
    {
        public User(int phoneNumber, string name, string password) : base(phoneNumber, name, password)
        {

        }
        public User() : base()
        {

        }
    }
    //public void ShowMyBookings()
    // {

    // }
}

