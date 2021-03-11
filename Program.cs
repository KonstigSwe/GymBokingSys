using System;

namespace GymBokingSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface NewInterface = new Interface();
            NewInterface.welcomeMessage();

            Login usrLogin = new Login();

            int debugg = usrLogin.LoginAndReg();

            Console.WriteLine("===DEBUGG===");

            if (debugg == 1)
            {
                Console.WriteLine("user Menu");
            }
            if (debugg == 2)
            {
                Console.WriteLine("Admin Menu");
            }
            else
            {
                Console.WriteLine("employee Menu");
            }

            Console.ReadKey();
            

        }
    }    
}