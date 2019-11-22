using System;

namespace SchoolAdmin.Models
{
    public class Course
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public courseTypes type { get; set; }

    }

    public enum courseTypes
    {
        SoftwareDevelopment,
        WebDevelopment,
        DataEngineering,
        DataScience,
        DevOps
    }
}