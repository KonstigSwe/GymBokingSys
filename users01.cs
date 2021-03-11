using System;
namespace GymBokingSys
{
    class Users01
    {
        internal string password;

        public int _phoneNumber { get; set; }
        public string _name { get; set; }
        public string _password { get; set; }
        public Users01(string name, string password, int phoneNumber)
        {
            this._phoneNumber = phoneNumber;
            this._name = name;
            this._password = password;

        }
    }


}
