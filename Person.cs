using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Person
    {
        private int _phoneNumber { get; set; }
        public string _name { get; private set; }
        private string _password { get; set; }
        public Person(int phoneNumber,string name,string password)
        {
            this._phoneNumber = phoneNumber;
            this._name = name;
            this._password = password;
           
        }
    }
}
