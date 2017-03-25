using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.BusinessLayer
{
    interface IBusStudent
    {
        List<Course> GetAllCourse();
        List<Student> GetStudentsInCourse(string courseNum);
        DataTable GetStudentsDataTableInCourse(string courseNum);
        List<String> GetAllSemester();
        List<Course> GetCoursesFromSemester(string semester);
        DataTable GetStudentGrade(string[] stuInfo);
        DataTable GetAllCoursesBySemester(string semester);
        int RegisterStudentIntoCourse(string[] studentCourse);
        int DropCourse(string[] stuInfo);
    }
}
