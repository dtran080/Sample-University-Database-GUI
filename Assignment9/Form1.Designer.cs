namespace Assignment9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCourseOfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerForACourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropACourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagementToolStripMenuItem,
            this.courseManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentToolStripMenuItem,
            this.viewStudentGradeToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewStudentToolStripMenuItem.Text = "View Enrollment in Class";
            this.viewStudentToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // viewStudentGradeToolStripMenuItem
            // 
            this.viewStudentGradeToolStripMenuItem.Name = "viewStudentGradeToolStripMenuItem";
            this.viewStudentGradeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewStudentGradeToolStripMenuItem.Text = "View Student Grades";
            this.viewStudentGradeToolStripMenuItem.Click += new System.EventHandler(this.viewStudentGradeToolStripMenuItem_Click);
            // 
            // courseManagementToolStripMenuItem
            // 
            this.courseManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCourseOfferToolStripMenuItem,
            this.registerForACourseToolStripMenuItem,
            this.dropACourseToolStripMenuItem});
            this.courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            this.courseManagementToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.courseManagementToolStripMenuItem.Text = "Course Management";
            // 
            // viewCourseOfferToolStripMenuItem
            // 
            this.viewCourseOfferToolStripMenuItem.Name = "viewCourseOfferToolStripMenuItem";
            this.viewCourseOfferToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.viewCourseOfferToolStripMenuItem.Text = "View Course Offered";
            this.viewCourseOfferToolStripMenuItem.Click += new System.EventHandler(this.viewCourseOfferToolStripMenuItem_Click);
            // 
            // registerForACourseToolStripMenuItem
            // 
            this.registerForACourseToolStripMenuItem.Name = "registerForACourseToolStripMenuItem";
            this.registerForACourseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registerForACourseToolStripMenuItem.Text = "Register for a Course";
            this.registerForACourseToolStripMenuItem.Click += new System.EventHandler(this.registerForACourseToolStripMenuItem_Click);
            // 
            // dropACourseToolStripMenuItem
            // 
            this.dropACourseToolStripMenuItem.Name = "dropACourseToolStripMenuItem";
            this.dropACourseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.dropACourseToolStripMenuItem.Text = "Drop a Course";
            this.dropACourseToolStripMenuItem.Click += new System.EventHandler(this.dropACourseToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(138, 35);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(532, 319);
            this.dgv.TabIndex = 1;
            this.dgv.Click += new System.EventHandler(this.selectedRowsButton_Click);
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(5, 72);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(123, 21);
            this.cmb1.TabIndex = 2;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Location = new System.Drawing.Point(5, 164);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(123, 21);
            this.cmb2.TabIndex = 2;
            this.cmb2.SelectedIndexChanged += new System.EventHandler(this.cmb2_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(9, 148);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 359);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCourseOfferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerForACourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropACourseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

