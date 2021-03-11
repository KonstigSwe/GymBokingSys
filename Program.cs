using System;
using System.Collections.Generic;
using System.Xml;
namespace GymBokingSys
{
    class Program
    {
        static List<User> UserList = new List<User>();
        static void Main(string[] args)
        {

            XMLreader();
            Interface NewInterface = new Interface();
            NewInterface.welcomeMessage();
            
            
            LoginAndReg();

        }
        static void XMLreader()
        {
            //@".\Users.xml"
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
        static int LoginAndReg()
        {

            int run = 1;
            // Admin och anställda bör också lagras på fil
            string admn = "admin";
            string empl = "empl";
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
                    // 1 User
                    // 2 Admin
                    // 3 Emloyee
                    foreach (User user in UserList)
                    {
                        if (username == user._name && password == user._password)
                        {
                            if (user._password == admn)
                            {
                                return 2;
                            }
                            if (user._password == empl)
                            {
                                return 3;
                            }
                            else
                            {
                                return 1;
                            }

                            Console.WriteLine("You have successfully logged in !!!");
                            Console.ReadLine();
                            corect = true;
                            break;
                        }
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

