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
            XMLwriter();
            Interface NewInterface = new Interface();
            NewInterface.welcomeMessage();
            Schedule df = new Schedule(1100, 30, "Niklassvensson","agda");
            Schedule dw = new Schedule(1100, 30, "Niklassvensson", "röjar ralf");
            Schedule.ScheduleList.Add(df);
            Schedule.ScheduleList.Add(dw);
            

            
        }
        static void XMLreader()
        {
            XmlTextReader textReader = new XmlTextReader("C:\\Users.xml");
            textReader.Read();
            while (textReader.Read())
            {
                textReader.MoveToElement();
                Console.WriteLine("XmlTextReader Properties Test");
                Console.WriteLine("===================");
                Console.WriteLine("Name:" + textReader.Name);
                Console.WriteLine("Base URI:" + textReader.BaseURI);
                Console.WriteLine("Local Name:" + textReader.LocalName);
                Console.WriteLine("Attribute Count:" + textReader.AttributeCount.ToString());
                Console.WriteLine("Depth:" + textReader.Depth.ToString());
                Console.WriteLine("Line Number:" + textReader.LineNumber.ToString());
                Console.WriteLine("Node Type:" + textReader.NodeType.ToString());
                Console.WriteLine("Attribute Count:" + textReader.Value.ToString());
            }
        }
        static void XMLwriter()
        {
            XmlTextWriter textWriter = new XmlTextWriter("C:\\Users.xml", null);
            textWriter.WriteStartDocument();
            // Write comments  
            textWriter.WriteComment("First Comment XmlTextWriter Sample Example");
            textWriter.WriteComment("myXmlFile.xml in root dir");
            // Write first element  
            textWriter.WriteStartElement("Student");
            textWriter.WriteStartElement("r", "RECORD", "urn:record");
            // Write next element  
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString("Student");
            textWriter.WriteEndElement();
            // Write one more element  
            textWriter.WriteStartElement("Address", "");
            textWriter.WriteString("Colony");
            textWriter.WriteEndElement();
            // WriteChars  
            char[] ch = new char[3];
            ch[0] = 'a';
            ch[1] = 'r';
            ch[2] = 'c';
            textWriter.WriteStartElement("Char");
            textWriter.WriteChars(ch, 0, ch.Length);
            textWriter.WriteEndElement();
            // Ends the document.  
            textWriter.WriteEndDocument();
            // close writer  
            textWriter.Close();
        }
    }
}
