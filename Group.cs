using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Group : Activity
    {
        private string _groupCoach;
        private string _room;

        public string GroupCoach
        {
            get { return _groupCoach; }
            set { _groupCoach = value; }
        }
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
    }
}
