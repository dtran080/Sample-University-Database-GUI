using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    partial class Student:EntityBase
    {
        private string studentId, firstName, lastName, address, city, state, telephone;

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public Student() { }
        public Student(string studentId, string fName, string lname, string address,
            string city, string state, string telephone)
        {
            this.studentId = studentId;
            this.firstName = fName;
            this.lastName = lname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.telephone = telephone;
        }

    }
}
