using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Machine : Activity
    {
        public string Type { get; private set; }
        public int MachineID { get; private set; }
        public bool Status { get; private set; }
        public List<Machine> machineList = new List<Machine>();


        public Machine(string type, int machineID, bool status)
        {
            Type = type;
            MachineID = machineID;
            Status = status;
        }
        public void AddMachine()
        {
            machineList.Add(new Machine("Treadmill", 1, true));
            machineList.Add(new Machine("Treadmill", 2, true));
            machineList.Add(new Machine("Treadmill", 3, true));
            machineList.Add(new Machine("Treadmill", 4, true));
            machineList.Add(new Machine("Cycle", 1, true));
            machineList.Add(new Machine("Cycle", 2, true));
            machineList.Add(new Machine("Cycle", 3, true));
            machineList.Add(new Machine("Rowing Machine", 1, true));
            machineList.Add(new Machine("Rowing Machine", 2, true));
            machineList.Add(new Machine("Crosstrainer", 1, true));
            machineList.Add(new Machine("Crosstrainer", 2, true));
        }
    }    
}
