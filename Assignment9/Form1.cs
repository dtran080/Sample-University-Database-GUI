using Assignment9.BusinessLayer;
using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class Form1 : Form
    {
        IBusStudent _ibusStudent = null;
        public Form1()
        {
            InitializeComponent();
            _ibusStudent = new Business() as IBusStudent;
        }

        bool viewClass,registerClass,dropClass;

        private void viewCourseOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanAllLabelsAndBox();
            List<String> semList = _ibusStudent.GetAllSemester();
            cmb1.DataSource = semList;
            Refresh();
            lbl1.Text = "Semester";
            viewClass = true;
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {   //display all semester
                CleanAllLabelsAndBox();
                List<String> semList = _ibusStudent.GetAllSemester();
                cmb1.DataSource = semList;
                Refresh();
                lbl1.Text = "Semester";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CleanAllLabelsAndBox()
        { //empty stuff out
            viewClass = false;
            registerClass = false;
            dropClass = false;
            lbl1.Text = "";
            lbl2.Text = "";
            cmb1.DataSource = null;
            cmb2.DataSource = null;
            dgv.DataSource = null;
            dgv.Refresh();
            cmb1.Items.Clear();
            cmb2.Items.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Go around the menu and look for the folder you need");
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbl1.Text == "Semester")
                {
                    Console.WriteLine("View Class, Register: " + viewClass + registerClass);
                    if (!viewClass)
                    {
                        //cmb1.Items.Clear();
                        string semester = this.cmb1.GetItemText(this.cmb1.SelectedItem);
                        List<Course> CourseList = _ibusStudent.GetCoursesFromSemester(semester);
                        cmb2.DataSource = CourseList;
                        cmb2.DisplayMember = "CourseNum";
                        cmb2.ValueMember = "CourseNum";
                        cmb2.Refresh();
                        lbl2.Text = "Courses List";
                    }
                    else
                    {   
                        string semester = this.cmb1.GetItemText(this.cmb1.SelectedItem);
                        dgv.DataSource = _ibusStudent.GetCoursesFromSemester(semester);
                        dgv.Refresh();
                        
                    }
                    
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbl2.Text.Equals("Courses List"))
                {
                    //ComboBox cmb = (ComboBox)sender;
                    // string selectedCourseName = cmb.SelectedItem.ToString();
                    string selectedCourseNum = this.cmb2.GetItemText(this.cmb2.SelectedItem);
                    Console.WriteLine("Selected: " + selectedCourseNum);
                    dgv.DataSource = _ibusStudent.GetStudentsDataTableInCourse(selectedCourseNum);
                    dgv.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void viewStudentGradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanAllLabelsAndBox();
            SearchStudentForm ssFrom = new SearchStudentForm();
            if (ssFrom.ShowDialog() == DialogResult.OK)
            {
                string[] stuInfo = ssFrom.StuInfo;
                dgv.DataSource = _ibusStudent.GetStudentGrade(stuInfo);
                dgv.Refresh();
            }
        }


        private void registerForACourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //same function as the above 
            CleanAllLabelsAndBox();
            List<String> semList = _ibusStudent.GetAllSemester();
            cmb1.DataSource = semList;
            Refresh();
            lbl1.Text = "Semester";
            viewClass = true;
            registerClass = true;
        }
     
        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                string semester = this.cmb1.GetItemText(this.cmb1.SelectedItem);
                string courseNum = dgv.SelectedRows[0].Cells[4].Value.ToString();
                string studentId = "";
                
                SearchStudentForm ssFrom = new SearchStudentForm();
                if (ssFrom.ShowDialog() == DialogResult.OK)
                {
                    string[] stuInfo = ssFrom.StuInfo;
                    studentId = stuInfo[0];
                }
                sb.Append(String.Format("Course Num: {0}\n studentId: {1}\n Semester: {2}",courseNum,studentId,semester));
                if (registerClass)
                {
                    int row = _ibusStudent.RegisterStudentIntoCourse(new string[] { studentId, courseNum, semester });
                    sb.Append("\n in row: " + row);
                    MessageBox.Show("Add Into DB:\n" + sb.ToString());
                }
                else if (dropClass)
                {
                    int row = _ibusStudent.DropCourse(new String[] { studentId, courseNum });
                    sb.Append("\n in row: " + row);
                    if (row!=0)
                        MessageBox.Show("Drop students enrollment in Course\n" + sb.ToString());
                    else
                    {
                        MessageBox.Show("Can't find Student's Enrollment in the Course");
                    }
                }
                            
            }
        }

        private void dropACourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //same function as the above 
                CleanAllLabelsAndBox();
                List<String> semList = _ibusStudent.GetAllSemester();
                cmb1.DataSource = semList;
                Refresh();
                lbl1.Text = "Semester";
                viewClass = true;
                dropClass = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
