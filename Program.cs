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


            Interface NewInterface = new Interface();
            NewInterface.welcomeMessage();
            User bd = new User(221, "hariet", "blitz",Role.User);
            User ba = new User(221, "harry", "login",Role.User);
            User baa = new User(221, "vera", "login",Role.User);
            baa.SetAccessAdmin();
            bd.SetAccessEmployee();
            UserList.Add(bd);
            UserList.Add(ba);
            UserList.Add(baa);
            XMLwriter();
            XMLreader();


        }
        static void XMLreader()
        {
            //@".\Users.xml"
            System.Xml.Serialization.XmlSerializer reader =
           new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            System.IO.StreamReader file = new System.IO.StreamReader( @"C:.\Users.xml");
            var collect =(List<User>)reader.Deserialize(file);
           file.Close();
            foreach(User i in collect)
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
        public int LoginAndReg()
        {
            var arrUsers = new Users01[]
            {
            new User("a","1",1234),
            new User("John","pass2",15),
            new User("Jane","pass2",32)
            };
            int run = 1;
            // Admin och anställda bör också lagras på fil
            string admn = "admin";
            string empl = "empl";
            while (run == 1)
            {
                Console.WriteLine("For login press 1 or for register 2");
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
                    foreach (Users01 user in arrUsers)
                    {
                        if (username == user._name && password == user._password)
                        {
                            if (user._password == admn)
                            {
                                return 2;
                            }
                            if (user.password == empl)
                            {
                                return 3;
                            }
                            else
                            {
                                return 1;
                            }

                            Console.WriteLine("You have successfully logged in !!!");
                            Console.ReadLine();
                        }
                    }
                    Console.WriteLine("Your username or password is incorect, try again !!!");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    Console.WriteLine("Enter your PhoneNumber:");
                    int phoneNumber = int.Parse(Console.ReadLine());
                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users01(username, password, phoneNumber);
                }
            }
            return 4;
        }
    }    
}

