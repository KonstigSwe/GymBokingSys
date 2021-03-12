using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GymBokingSys
{
    class Interface
    {
        public void welcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.Write("║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("   ...Welcome to Gym booking system...    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ResetColor();
        }
        public void progressBar()
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("█");
                Thread.Sleep(10);
            }
            Console.WriteLine();
        }
        public void login()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Log in");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(10, 7);
            Console.Write("Enter your user name: ");

            Console.SetCursorPosition(10, 9);
            Console.WriteLine("Enter your password: ");
            Console.ResetColor();
        }
        public void loginRegister()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Register in the booking system");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(10, 7);
            Console.Write("Enter your user name: ");

            Console.SetCursorPosition(10, 9);
            Console.WriteLine("Enter your password: ");

            Console.SetCursorPosition(10, 11);
            Console.WriteLine("Enter your PhoneNumber:");
            Console.ResetColor();
        }
        public void loginMessage()
        {

        }
        public void writeSchedule()
        {

        }
        // Function should get parameter to print from object
        public void ShowStatusMachine(Machine m)
        {         
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+---------------------+-----------------+");
            Console.WriteLine("|   Type       |  MachineId |    Status |");
            Console.WriteLine("+---------------------+-----------------+");
            foreach (Machine item in m.machineList)
            {
                Console.WriteLine("{0} \t      {1} \t   {2}", item.Type, item.MachineID, item.Status);
            }
            Console.WriteLine("+---------------------+-----------------+");
        }
        public void UserMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+------------+-----------+");
            Console.WriteLine("|          Menu          |");
            Console.WriteLine("+------------+-----------+");
            Console.WriteLine("Select a number in menu");
            Console.WriteLine("1 - Make a new booking\n" +
                              "2 - Show my bookings\n" +
                              "3 - Quit\n");
            Console.Write(">");

        }
        public void EmployeeMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+------------+-----------+");
            Console.WriteLine("|          Menu          |");
            Console.WriteLine("+------------+-----------+");
            Console.WriteLine("Select a number in menu");
            Console.WriteLine("1 - Show schedule\n" +
                              "2 - Quit");

            Console.Write(">");
        }
        public void AdminMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+------------+-----------+");
            Console.WriteLine("|          Menu          |");
            Console.WriteLine("+------------+-----------+");
            Console.WriteLine("Select a number in menu");
            Console.WriteLine("1 - Register new user\n" +
                              "2 - Create group session\n" +
                              "3 - Create activity\n" +
                              "4 - Show schedule\n" +
                              "5 - Delete group session\n" +
                              "6 - Delete activity\n" +
                              "7 - Delete user\n" +
                              "8 - Quit\n");

            Console.Write(">");
        }
        public void SetStatusMachine(int mID, Machine m)
        {         
            foreach (Machine item in m.machineList)
            {
                if (mID == m.MachineID)
                {
                    Console.Write("Do you want to change the Status on {0} with machineID {1}? y/n ", item.Type, mID);
                    string userInput = Console.ReadLine();
                    if (userInput == "y")
                    {
                        Console.Write("What Status do you want change to? (0 for OK, 1 for Repair, 2 for Purchase New) ");
                        string userInput2 = Console.ReadLine();
                        switch (userInput2)
                        {
                            case "0": item.Status = 1; break;
                            case "1": item.Status = 1; break;
                            case "2": item.Status = 2; break;
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
