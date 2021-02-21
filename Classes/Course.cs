using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISS311GroupProject.Classes
{
    class Course
    {
        //fields
        private int courseId, seats;
        private string title;
        private bool isAvailable;

        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        //constructor
        public Course(int courseId, string title, int seats, bool isAvailable)
        {
            this.courseId = courseId;
            this.title = title;
            this.seats = seats;
            this.isAvailable = isAvailable;
        }
    }
}
