namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        // Entity Framework interprets a property as a foreign key property if it's named
        // <navigation property name><primary key property name>
        // CourseID property is a foreign key, and the corresponding navigation property is Course 
        public int CourseID { get; set; }
        // StudentID property is a foreign key, and the corresponding navigation property is Student
        public int StudentID { get; set; }
        // The question mark after the Grade type declaration indicates that the Grade property is nullable
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}