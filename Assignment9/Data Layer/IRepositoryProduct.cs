using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Data_Layer
{
    interface IRepositoryProduct
    {
        List<Course> GetAllCourse();
        List<Student> GetStudentsByCourse(string courseNum);
        DataTable GetAllCoursesBySemester(string semester);
    }
}
