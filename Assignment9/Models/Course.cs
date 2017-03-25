using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    partial class Course:EntityBase
    {
        int creditHours, departmentId;

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public int CreditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }
        string courseNum, courseName, description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string CourseNum
        {
            get { return courseNum; }
            set { courseNum = value; }
        }
        
        public Course() { }
        public Course(string courseNum, string courseName, int creditHours, string description, int departmentId)
        {
            this.courseNum = courseNum;
            this.courseName = courseName;
            this.creditHours = creditHours;
            this.description = description;
            this.departmentId = departmentId;
        }

    }
}
