using STUDENTPORTAL.Models;
using STUDENTPORTAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STUDENTPORTAL
{
    public class StudentReposity:IStudentRepository
    {
        public StudentInformation GetStudent(int Id)
        {
            StudentInformation studentInformation = new StudentInformation();

            return studentInformation;
        }
        public void Save(StudentInformation studentInformation)
        {

        }
            
    }
}
