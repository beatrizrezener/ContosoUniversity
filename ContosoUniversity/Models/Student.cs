using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        // The ID property will become the primary key
        // EF interprets ID or classnameID as the primary key.
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // The Enrollments property is a navigation property.
        // Navigation properties hold other entities that are related to this entity.
        // Enrollments will hold all of the Enrollment entities that are related to that Student entity.
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}