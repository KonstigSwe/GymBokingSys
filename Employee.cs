using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    class Employee:Person
    {
        
        private string _Jobtitle { get; set; }
        public Employee(int phoneNumber, string name, string password) : base(phoneNumber, name, password)
        {

        }
        public void ShowSchedule()
        {
            
        }
    }
}
