using System.Collections.Generic;

namespace SchoolAdmin.Models
{
    public class School
    {
        public string name { get; set; }

        public string address { get; set; }

        public static Dictionary<Student, Course> listOfEnrolledStudents { get; }

        public static List<Course> listOfAvailableCourses { get; }

        public void addCourse(Course c)
        {
            listOfAvailableCourses.Add(c);
        }

        public void deleteCourse(Course c)
        {
            listOfAvailableCourses.Remove(c);
        }

        public void registerStudent(Student s, Course c)
        {
            listOfEnrolledStudents.Add(s, c);
        }

        public void removeStudent(Student s)
        {
            listOfEnrolledStudents.Remove(s);
        }

        public void addCourseToStudent(Student s, Course c)
        {
            s.listOfCourses.Add(c);
        }

        public void removeCourseFromStudent(Student s, Course c)
        {
            s.listOfCourses.Remove(c);
        }
    }
}