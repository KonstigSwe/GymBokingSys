using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Group : Activity
    {
        private string _groupCoach;

        public string GroupCoach
        {
            get { return _groupCoach; }
            set { _groupCoach = value; }
        }
    }
}
