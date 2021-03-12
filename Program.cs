using System;
using System.Collections.Generic;
using System.Xml;
namespace GymBokingSys
{
    class Program
    {
        static int level;
        static List<User> UserList = new List<User>();

        static void Main(string[] args)
        {


            XMLreader();
            Interface NewInterface = new Interface();
            NewInterface.welcomeMessage();
            
            
             level = LoginAndReg();

        }

        





        static void XMLreader()
        {
            
            System.Xml.Serialization.XmlSerializer reader =
           new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:.\Users.xml");
            var collect = (List<User>)reader.Deserialize(file);
            file.Close();
            foreach (User i in collect)
            {
                UserList.Add(i);
            }
        }
        static void XMLwriter()
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            var wfile = new System.IO.StreamWriter(@"C:.\Users.xml", false);

            var b = UserList;
            writer.Serialize(wfile, b);
            wfile.Close();
            // Now we can read the serialized book ...  

        }
        static void AddAdmin()
        {
            if (level == 10)
            {
                //Console.WriteLine("Enter your username:");
                // var username = Console.ReadLine();
                //Console.WriteLine("Enter your password:");
                //var password = Console.ReadLine();
                //Console.WriteLine("Enter your PhoneNumber:");
                //string phoneNumber = Console.ReadLine();
                Interface loginInterface = new Interface();
                loginInterface.loginRegister();
                // Creating text boxes
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(32, 7);
                Console.Write("                              "); // User name
                Console.SetCursorPosition(32, 9);
                Console.Write("                              "); // Password
                Console.SetCursorPosition(34, 11);
                Console.Write("                              "); // Phone number

                // Reading 
                Console.SetCursorPosition(32, 7);
                var username = Console.ReadLine();
                Console.SetCursorPosition(32, 9);
                var password = Console.ReadLine();
                Console.SetCursorPosition(34, 11);
                string phoneNumber = Console.ReadLine();
                Console.SetCursorPosition(10, 13);
                loginInterface.progressBar();
                Console.ResetColor();
                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Saved to the bank...");
                Console.ResetColor();
                //-----------------------------------------------------
                User us = new User(phoneNumber, username, password, Role.Admin);
                UserList.Add(us);
                XMLwriter();
            }
        }
        static void AddEmployee()
        {
            if (level == 10)
            {
                //Console.WriteLine("Enter your username:");
                //var username = Console.ReadLine();
                //Console.WriteLine("Enter your password:");
                //var password = Console.ReadLine();
                //Console.WriteLine("Enter your PhoneNumber:");
                //string phoneNumber = Console.ReadLine();
                Interface loginInterface = new Interface();
                loginInterface.loginRegister();
                // Creating text boxes
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(32, 7);
                Console.Write("                              "); // User name
                Console.SetCursorPosition(32, 9);
                Console.Write("                              "); // Password
                Console.SetCursorPosition(34, 11);
                Console.Write("                              "); // Phone number

                // Reading 
                Console.SetCursorPosition(32, 7);
                var username = Console.ReadLine();
                Console.SetCursorPosition(32, 9);
                var password = Console.ReadLine();
                Console.SetCursorPosition(34, 11);
                string phoneNumber = Console.ReadLine();
                Console.SetCursorPosition(10, 13);
                loginInterface.progressBar();
                Console.ResetColor();
                Console.SetCursorPosition(10, 15);
                Console.WriteLine("Saved to the bank...");
                Console.ResetColor();
                //-----------------------------------------------------
                User us = new User(phoneNumber, username, password, Role.Employee);
                UserList.Add(us);
                XMLwriter();
            }
        }
        static int LoginAndReg()
        {

            int run = 1;
            // Admin och anställda bör också lagras på fil
            
            bool corect = false;
            while (run == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Select ");
                Console.WriteLine("[1] Log in    [2] Register");
                Console.Write(">");
                Console.ResetColor();
                var input = Console.ReadLine();


                if (input == "1")
                {
                    //Console.WriteLine("Write your username:");
                    //var username = Console.ReadLine();
                    //Console.WriteLine("Enter your password:");
                    //var password = Console.ReadLine();
                    //-----------------------------------------------------
                    Interface loginInterface = new Interface();
                    loginInterface.login();
                    // Reading user name and password
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(32, 7);
                    Console.Write("                              "); // User name
                    Console.SetCursorPosition(32, 9);
                    Console.Write("                              "); // Password

                    Console.SetCursorPosition(32, 7);
                    var username = Console.ReadLine();
                    Console.SetCursorPosition(32, 9);
                    var password = Console.ReadLine();
                    Console.SetCursorPosition(10, 11);
                    loginInterface.progressBar();
                    Console.SetCursorPosition(10, 15);
                    //Console.WriteLine("Thank you");
                    Console.ResetColor();
                    //Console.Clear();

                    //-----------------------------------------------------

                    foreach (User user in UserList)
                    {
                        if (username == user._name && password == user._password)
                        {
                            Console.SetCursorPosition(10, 12);
                            Console.WriteLine("You have successfully logged in !!!");
                            if(user.access == Role.Admin)
                            {
                                return 10;
                            }
                            if (user.access == Role.Employee)
                            {
                                return 5;
                            }
                            Console.ReadLine();
                            corect = true;
                            break;
                        }
                    }
                    if (corect == false)
                    {
                        Console.SetCursorPosition(10, 12);
                        Console.WriteLine("Your username or password is incorect, try again !!!\n");
                    }
                }
                else if (input == "2")
                {
                    //Console.WriteLine("Enter your username:");
                    //var username = Console.ReadLine();
                    //Console.WriteLine("Enter your password:");
                    //var password = Console.ReadLine();
                    //Console.WriteLine("Enter your PhoneNumber:");
                    //string phoneNumber = Console.ReadLine();
                    //-----------------------------------------------------
                    Interface loginInterface = new Interface();
                    loginInterface.loginRegister();
                    // Creating text boxes
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(32, 7);
                    Console.Write("                              "); // User name
                    Console.SetCursorPosition(32, 9);
                    Console.Write("                              "); // Password
                    Console.SetCursorPosition(34, 11);
                    Console.Write("                              "); // Phone number

                    // Reading 
                    Console.SetCursorPosition(32, 7);
                    var username = Console.ReadLine();
                    Console.SetCursorPosition(32, 9);
                    var password = Console.ReadLine();
                    Console.SetCursorPosition(34, 11);
                    string phoneNumber = Console.ReadLine();
                    Console.SetCursorPosition(10, 13);
                    loginInterface.progressBar();
                    Console.ResetColor();
                    Console.SetCursorPosition(10, 15);
                    Console.WriteLine("Saved to the bank...");
                    Console.ResetColor();
                    //-----------------------------------------------------
                    User us = new User(phoneNumber, username, password, Role.User);
                    UserList.Add(us);
                    XMLwriter();
                }
            }
            return 4;
        }
    }
}

