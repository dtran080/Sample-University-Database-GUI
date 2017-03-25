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
    public partial class SearchStudentForm : Form
    {
        string[] stuInfo = null;

        public string[] StuInfo
        {
            get { return stuInfo; }
        }
        public SearchStudentForm()
        {
            InitializeComponent();
        }

        private void searchStuBtn_Click(object sender, EventArgs e)
        {
            if (searchStuBtn.DialogResult == DialogResult.OK)
            {
                
                string stuID = stuIdTB.Text;
                string firstName = stuFNTB.Text;
                string lastName = stuLNTB.Text;
                stuInfo = new string[] {stuID,firstName,lastName}; 
            }
        }
    }
}
