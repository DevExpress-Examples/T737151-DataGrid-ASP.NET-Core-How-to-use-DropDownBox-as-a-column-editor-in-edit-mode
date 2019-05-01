using System;
using System.Collections.Generic;

namespace CS.Models {
    public class Employee
    {
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public string HomePhone { get; set; }
        public int ID { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }
        public string Picture { get; internal set; }
        public string Position { get; set; }
        public string Prefix { get; set; }
        public string Skype { get; set; }
        public string State { get; set; }
        public int[] StateID { get; set; }
        public List<EmployeeTask> Tasks { get; set; }
    }
}