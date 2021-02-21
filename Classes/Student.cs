using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISS311GroupProject.Classes
{
    class Student
    {
        //fields
        private int studentId, credits;
        private string firstName, lastName;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
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

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        //constructor
        public Student(int studentId, string firstName, string lastName, int credits)
        {
            this.studentId = studentId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.credits = credits;
        }
    }
}
