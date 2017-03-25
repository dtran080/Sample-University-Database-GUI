using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment9.Data_Layer;
using System.Data.Common;
using System.Data.SqlClient;

namespace Assignment9.Data_Layer
{
    class Repository:IRepositoryCustomerOrder,IRepositoryProduct
    {
        IDataAccess _idac = null;
        public Repository()
        {
            string connstr = "Data Source=ANHHOANG-HP\\SQLEXPRESS;Initial Catalog = UBDB; Integrated Security = True";
            _idac = new DataAccess(connstr);
        }
        public List<Course> GetAllCourse()
        {
             List<Course> CourseList = null;
            try 
            { 
                string sql = "select * from Courses"; 
                DataTable dt = _idac.GetManyRowsCols(sql, null); 
                CourseList = DBList.ToList<Course>(dt); 
            }
            catch (Exception) 
            { throw; } 
            return CourseList;
        }
        public List<Student> GetStudentsByCourse(string courseNum)
        {
            try
            {
                List<Student> SList = null;
                try
                {
                    string sql = "select * from Students"+
                        " join StudentCourses sc on s.StudentId = sc.StudentId"+
                        " where sc.CourseNum = @CourseNum ";
                    List<DbParameter> paramList = new List<DbParameter>();
                    SqlParameter p1 = new SqlParameter("@CategoryId", SqlDbType.VarChar);
                    p1.Value = courseNum;
                    paramList.Add(p1);
                    DataTable dt = _idac.GetManyRowsCols(sql, paramList);
                    SList = DBList.ToList<Student>(dt);
                }
                catch (Exception)
                {
                    throw; //NO STUDENT WHATEVER
                }
                return SList;
            }
            catch(Exception)
            {
                throw; //no such class exist
            }
        }
        public DataTable GetStudentsInCourse(string courseNum)
        {
            try
            {
                string sql = "select * from Students s" +
                        " join StudentCourses sc on s.StudentId = sc.StudentId" +
                        " where sc.CourseNum = @CourseNum ";
                List<DbParameter> paramList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@CourseNum", SqlDbType.VarChar);
                p1.Value = courseNum;
                paramList.Add(p1);
                return _idac.GetManyRowsCols(sql, paramList);
            }
            catch (Exception)
            {
                throw; //no such class exist
            }
        }
        public List<Course> GetCoursesBySemester(string semester)
        {
            try
            {
                List<Course> courseList = new List<Course>();
                Console.WriteLine("Semester: "+semester);
                string sql = "select * from Courses c "
                    +" join CoursesOffered co on c.CourseNum = co.CourseNum"
                    +" where co.Semester = @semester";
                List<DbParameter> paramList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@semester", SqlDbType.VarChar);
                p1.Value = semester;
                paramList.Add(p1);
                DataTable dt = _idac.GetManyRowsCols(sql,paramList);
                courseList = DBList.ToList<Course>(dt);
                return courseList;
            }
            catch (Exception)
            {
                throw; //semester not found
            }
        }
        public List<String> GetAllSemester()
        {
            try
            {
                List<String> semList = new List<String>();
                string sql = "select distinct Semester from CoursesOffered";
                DataTable dt = _idac.GetManyRowsCols(sql, null);
                //semList = DBList.ToList<String>(dt);
                foreach (DataRow row in dt.Rows)
                    semList.Add(row["Semester"].ToString());
                return semList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetStudentGrade(string[] stuInfo)
        {
            try
            {   
                string sql = "Select s.StudentID, s.FirstName, s.LastName, ct.CourseNum, ct.Semester, ct.grade "
                   + " from Students s join CoursesTaken ct on ct.StudentID = s.StudentID "
                   + (" where s.StudentID = @stuId or s.FirstName=@fName or s.LastName=@lName");
                List<DbParameter> paramList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@stuId", SqlDbType.VarChar);
                p1.Value = stuInfo[0];
                SqlParameter p2 = new SqlParameter("@fName", SqlDbType.VarChar);
                p2.Value = stuInfo[1];
                SqlParameter p3 = new SqlParameter("@lName", SqlDbType.VarChar);
                p3.Value = stuInfo[2];
                paramList.Add(p1);
                paramList.Add(p2);
                paramList.Add(p3);
                return _idac.GetManyRowsCols(sql, paramList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable GetAllCoursesBySemester(string semester)
        {
            try
            {
                string sql = "select * from Courses c "
                    + " join CoursesOffered co on c.CourseNum = co.CourseNum"
                    + " where co.Semester = @semester";
                List<DbParameter> paramList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@semester", SqlDbType.VarChar);
                p1.Value = semester;
                paramList.Add(p1);
                return _idac.GetManyRowsCols(sql, paramList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int RegisterStudentIntoCourse(string[] studentCourse)
        {
            try
            {
                string sql = "insert into  StudentCourses(StudentId,CourseNum,Semester) values (@StudentId,@CourseNum,@Semester)";
                List<DbParameter> paramList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar);
                p1.Value = studentCourse[0];
                paramList.Add(p1);
                SqlParameter p2 = new SqlParameter("@CourseNum", SqlDbType.VarChar);
                p2.Value = studentCourse[1];
                paramList.Add(p2);
                SqlParameter p3 = new SqlParameter("@Semester", SqlDbType.VarChar);
                p3.Value = studentCourse[2];
                paramList.Add(p3);
                return _idac.InsertUpdateDelete(sql,paramList);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int DropCourse(string[] stuInfo)
        {
            try
            {
                string sql = "delete from StudentCourses where StudentId = @StudentId and CourseNum = @CourseNum";
                List<DbParameter> paramList = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar);
                p1.Value = stuInfo[0];
                paramList.Add(p1);
                SqlParameter p2 = new SqlParameter("@CourseNum", SqlDbType.VarChar);
                p2.Value = stuInfo[1];
                paramList.Add(p2);
                return _idac.InsertUpdateDelete(sql, paramList);    
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
