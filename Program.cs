using System;
using System.Collections.Generic;
using System.Xml;
namespace GymBokingSys
{
    class Program
    {
        static List<User> UserList = new List<User>();
        static List<Employee> EmployeeList = new List<Employee>();
        static List<Administrator> AdminList = new List<Administrator>();
        static void Main(string[] args)
        {

            Interface NewInterface = new Interface();
            NewInterface.welcomeMessage();
            User bd = new User(221, "hariet", "blitz");
            User ba = new User(221, "harry", "login");
            UserList.Add(bd);
            UserList.Add(ba);
            XMLwriter();
            XMLreader();


        }
        static void XMLreader()
        {
            //@".\Users.xml"
            System.Xml.Serialization.XmlSerializer reader =
           new System.Xml.Serialization.XmlSerializer(typeof(User));
            System.IO.StreamReader file = new System.IO.StreamReader(
                @"C:\Users\nikla\Documents\Visual_studio_code\C#\GymBokingSys\Users.xml");
            User ds = (User)reader.Deserialize(file);
            file.Close();

            Console.WriteLine(ds._name);
        }
        static void XMLwriter()
        {
            foreach (User i in UserList)
            {
                var b = i;
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(User));
                var wfile = new System.IO.StreamWriter(@"C:\Users\nikla\Documents\Visual_studio_code\C#\GymBokingSys\Users.xml",true);
                writer.Serialize(wfile, b);
                wfile.Close();
            }
            // Now we can read the serialized book ...  

        }
    }

}
