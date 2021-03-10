using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Machine : Activity
    {
        private string _type;
        private int _machineID;
        private bool _status;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int MachineID
        {
            get { return _machineID; }
            set { _machineID = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
