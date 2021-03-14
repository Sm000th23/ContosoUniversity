///////////////////////////////////////////////////////////
// Date         Developer    Description
// 2021-03-11   Chase H.     Created intial file for ContosoUniversity
// 2021-03-13   Chase H.     Created Enrollment program
// 2021-03-13   Chase H.     Finished Enrollment program
//
namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-1972039-dykstra1] Set up Lettered Grade system 
    public enum Grade
    {
        A, B, C, D, F
    }
    //tinfo200:[2021-03-13-1972039-dykstra1] Setting up Enrollment class of EnrollmentID,
    //CourseID, StudentID, Grade and Student
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

        public Course Course { get; set; }
        
    }
}