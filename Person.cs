using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    public class Person
    {
        public int _phoneNumber { get; set; }
        public string _name { get;  set; }
        public string _password { get; set; }
        public Person(int phoneNumber, string name, string password)
        {
            this._phoneNumber = phoneNumber;
            this._name = name;
            this._password = password;

        }
        public Person() { }
    }
}
