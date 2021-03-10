using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class PtTraining : Activity
    {
        private string _ptName;

        public string PtName
        {
            get { return _ptName; }
            set { _ptName = value; }
        }
    }
}
