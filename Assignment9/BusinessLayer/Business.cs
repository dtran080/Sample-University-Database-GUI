using Assignment9.Data_Layer;
using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.BusinessLayer
{
    class Business:IBusStudent
    {
        public IRepositoryProduct _irepProducts = null;
        public IRepositoryCustomerOrder _irepCustomers = null;
        public Business()
        {
            _irepProducts = new Repository() as IRepositoryProduct;
            _irepCustomers = new Repository() as IRepositoryCustomerOrder;
        }
        public Business(IRepositoryProduct irepProd, IRepositoryCustomerOrder irepCust)
        {
            _irepProducts = irepProd;
            _irepCustomers = irepCust;
        }
        public List<Course> GetAllCourse()
        {
            return _irepProducts.GetAllCourse();
        }
        public List<Student> GetStudentsInCourse(string courseNum)
        {
            return _irepProducts.GetStudentsByCourse(courseNum);
        }
        public DataTable GetStudentsDataTableInCourse(string courseNum)
        {
            return _irepCustomers.GetStudentsInCourse(courseNum);
        }
        public List<String> GetAllSemester()
        {
            return _irepCustomers.GetAllSemester();
        }
        public List<Course> GetCoursesFromSemester(string semester)
        {
            return _irepCustomers.GetCoursesBySemester(semester);
        }
        public DataTable GetStudentGrade(string[] stuInfo)
        {
            return _irepCustomers.GetStudentGrade(stuInfo);
        }
        public DataTable GetAllCoursesBySemester(string semester)
        {
            return _irepProducts.GetAllCoursesBySemester(semester);
        }
        public int RegisterStudentIntoCourse(string[] studentCourse)
        {
            return _irepCustomers.RegisterStudentIntoCourse(studentCourse);
        }
        public int DropCourse(string[] stuInfo)
        {
            return _irepCustomers.DropCourse(stuInfo);
        }
    }
}
