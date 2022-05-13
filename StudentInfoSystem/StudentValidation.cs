using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        Student GetStudentDataByUser(UserLogin.User user)
        {
            Student student = new Student();   
            if(user.facultyNumber == null || !user.facultyNumber.Equals(user.facultyNumber))
            {
                Console.WriteLine("No such student with this fac number!");
                return null;
            }
                return (from s in StudentData.TestStudents
                        where s.facultyNumber == user.facultyNumber select s).First();
        }

    }
}
