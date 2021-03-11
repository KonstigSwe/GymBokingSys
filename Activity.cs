using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Activity
    {
        private string _bookName;
        private int _bookPhone;

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public int BookPhone
        {
            get { return _bookPhone; }
            set { _bookPhone = value; }
        }
        public void Booking(string name, int phoneNum)
        {
            //some code
        }
    }
}
