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
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.Write("║");
            Console.Write("    ...Welcome to Gym booking sysyem...    ");
            Console.WriteLine("║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");
            for (int i = 1; i <= 45; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(15);
                Console.Write("█");
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        public void writeSchedule()
        {

        }
    }
}
