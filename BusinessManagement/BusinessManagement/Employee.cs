using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagement
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string idNumber { get; set; }
        public string position { get; set; }
        public string department { get; set; }
        public string numberOfWriteups { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }

        public Employee()
        {
            firstName = "";
            lastName = "";
            idNumber = "";
            position = "";
            department = "";
            numberOfWriteups = "";
            username = "";
            password = "";
            isAdmin = false;
        }

        public Employee(Employee e)
        {
            firstName = e.firstName;
            lastName = e.lastName;
            idNumber = e.idNumber;
            position = e.position;
            department = e.department;
            numberOfWriteups = e.numberOfWriteups;
            username = e.username;
            password = e.password;
            isAdmin = e.isAdmin;
        }

        public Employee(string first, string last, string id, string pos, string dep,
            string write, string user, string pass, bool admin)
        {
            firstName = first;
            lastName = last;
            idNumber = id;
            position = pos;
            department = dep;
            numberOfWriteups = write;
            username = user;
            password = pass;
            isAdmin = admin;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}\n{idNumber}";
        }
    }
}
