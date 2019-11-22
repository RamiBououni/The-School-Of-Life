using System;
using System.Collections.Generic;

namespace SchoolAdmin.Models
{
    public class Student
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public List<Course> listOfCourses { get; }
    }
}