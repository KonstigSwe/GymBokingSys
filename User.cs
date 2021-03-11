using System;
using System.Collections.Generic;
using System.Text;

namespace GymBokingSys
{
    public class User : Person
    {
        public Role access;
        private string _Jobtitle { get; set; }
        public User(int phoneNumber, string name, string password,Role grade ) : base(phoneNumber, name, password)
        {

        }
        public User() : base()
        {

        }
        public void SetAccessUser()
        {
            access = Role.User;
        }
        public void SetAccessAdmin()
        {
            access = Role.Admin;
        }
        public void SetAccessEmployee()
        {
            access = Role.Employee;
        }
        public void ShowSchedule()
        {

        }
        public void DeleteUser()
        {

        }
        public void CreateGroupSession()
        {

        }
        public void DeleteGroupSession()
        {

        }
        public void CreateActivity()
        {

        }
        public void DeleteActivity()
        {

        }
    }
    public enum Role
    {
        User ,
        Admin ,
        Employee
    }

}

