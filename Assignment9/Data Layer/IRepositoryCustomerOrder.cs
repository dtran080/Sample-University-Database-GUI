using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Data_Layer
{
    interface IRepositoryCustomerOrder
    {
        DataTable GetStudentsInCourse(string courseNum);
        List<Course> GetCoursesBySemester(string semester);
        List<String> GetAllSemester();
        DataTable GetStudentGrade(string[] stuInfo);
        int RegisterStudentIntoCourse(string[] studentCourse);
        int DropCourse(string[] stuInfo);
    }
}
