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
      
    }
}
