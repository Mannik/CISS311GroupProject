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
        private int studentID, credits;
        private string firstName, lastName;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
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
        public Student(int studentID, string firstName, string lastName, int credits)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.credits = credits;
        }
    }
}
