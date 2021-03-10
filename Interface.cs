using System;
using System.Collections.Generic;
using System.Text;

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
            Console.Write("   ...Welcome to our booking system...    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press a key");
            Console.ReadKey();


        }
        public void writeSchedule()
        {

        }
    }
}
