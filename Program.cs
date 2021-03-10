using System;
using System.Collections.Generic;
namespace GymBokingSys
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Interface NewInterface = new Interface();
            NewInterface.welcomeMessage();
            Schedule df = new Schedule(1100, 30, "Niklassvensson","agda");
            Schedule dw = new Schedule(1100, 30, "Niklassvensson", "röjar ralf");
            Schedule.ScheduleList.Add(df);
            Schedule.ScheduleList.Add(dw);
            Employee agda = new Employee(2003, "agda","berit");

            agda.ShowSchedule();
        }
    }
}
