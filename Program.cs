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

        }
    }

}
