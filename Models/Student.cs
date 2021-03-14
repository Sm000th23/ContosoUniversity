///////////////////////////////////////////////////////////
// Date         Developer    Description
// 2021-03-11   Chase H.     Created intial file for ContosoUniversity
// 2021-03-13   Chase H.     Created Student program
// 2021-03-13   Chase H.     Finished Student program
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-1972039-dykstra1] Setting up Student class ID, LastName, FirstMidName, EnrollDate and Enrollments
    // for the database
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
