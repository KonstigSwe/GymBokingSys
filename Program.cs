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
                Console.WriteLine("Enter your username:");
                var username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                var password = Console.ReadLine();
                Console.WriteLine("Enter your PhoneNumber:");
                string phoneNumber = Console.ReadLine();
                User us = new User(phoneNumber, username, password, Role.Admin);
                UserList.Add(us);
                XMLwriter();
            }
        }
        static void AddEmployee()
        {
            if (level == 10)
            {
                Console.WriteLine("Enter your username:");
                var username = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                var password = Console.ReadLine();
                Console.WriteLine("Enter your PhoneNumber:");
                string phoneNumber = Console.ReadLine();
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
                Console.WriteLine(" For login press 1 or for register 2");
     
                Console.Write(">");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Write your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    
                    foreach (User user in UserList)
                    {
                        if (username == user._name && password == user._password)
                        { 
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
                            run = 0;
                            break;
                        }
                        break;
                    }
                    if (corect == false)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    Console.WriteLine("Enter your PhoneNumber:");
                    string phoneNumber = Console.ReadLine();
                    User us = new User(phoneNumber, username, password, Role.User);
                    UserList.Add(us);
                    XMLwriter();
                }
            }
            return 4;
        }
    }
}

