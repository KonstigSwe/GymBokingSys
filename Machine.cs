using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Machine : Activity
    {
        public string Type { get; set; }
        public int MachineID { get; set; }
        public int Status { get; set; }
        public List<Machine> machineList = new List<Machine>();

        public Machine()
        {
        }
        public Machine(string type, int machineID, int status)
        {
            Type = type;
            MachineID = machineID;
            Status = status;
        }    
        // Status 0 - OK, 1 - Repair, 2 - Purchase
        // should be developed with user input instead of hardcoded machines
        public void AddMachine()
        {
            machineList.Add(new Machine("Treadmill", 1, 0));
            machineList.Add(new Machine("Treadmill", 2, 0));
            machineList.Add(new Machine("Treadmill", 3, 0));
            machineList.Add(new Machine("Treadmill", 4, 0));
            machineList.Add(new Machine("Excercise Bike", 5, 0));
            machineList.Add(new Machine("Excercise Bike", 6, 0));
            machineList.Add(new Machine("Excercise Bike", 7, 0));
            machineList.Add(new Machine("Rowing Machine", 8, 0));
            machineList.Add(new Machine("Rowing Machine", 9, 0));
            machineList.Add(new Machine("Crosstrainer", 10, 0));
            machineList.Add(new Machine("Crosstrainer", 11, 0));
        }
    }    
}
