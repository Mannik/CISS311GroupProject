using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISS311GroupProject.Classes
{
    class Employee
    {
        //fields
        private int employeeID;
        private string firstName, lastName;
        private bool isAdmin;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        //constructor
        public Employee(int employeeID, string firstName, string lastName, bool isAdmin)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.isAdmin = isAdmin;
        }

    }
}
