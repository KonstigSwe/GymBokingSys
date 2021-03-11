using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Machine : Activity
    {
        public string Type { get; private set; }
        public int MachineID { get; private set; }
        public int Status { get; private set; }
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
        public void ShowStatusMachine()
        {
            Console.WriteLine("+---------------------+-----------------+");
            Console.WriteLine("|   Type       |  MachineId |    Status |");
            Console.WriteLine("+---------------------+-----------------+");
            foreach (Machine m in machineList)
            {
                Console.WriteLine("{0} \t      {1} \t   {2}", m.Type, m.MachineID, m.Status);
            }
            Console.WriteLine("+---------------------+-----------------+");
        }
        public void SetStatusMachine(int mID)
        {
            foreach(Machine m in machineList)
            {
                if (mID == m.MachineID)
                {
                    Console.Write("Do you want to change the Status on {0} with machineID {1}? y/n ",m.Type, mID);
                    string userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        Console.Write("What Status do you want change to? (0 for OK, 1 for Repair, 2 for Purchase New) ");
                        string userInput2 = Console.ReadLine();
                        switch (userInput2)
                        {
                            case "0": m.Status = 1; break;
                            case "1": m.Status = 1; break;
                            case "2": m.Status = 2; break;
                            default: Console.WriteLine("Wrong input"); break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No changes made");
                    }
                }
            }         
        }
    }    
}
