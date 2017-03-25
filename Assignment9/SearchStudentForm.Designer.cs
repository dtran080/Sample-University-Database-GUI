namespace Assignment9
{
    partial class SearchStudentForm
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
            this.searchStuBtn = new System.Windows.Forms.Button();
            this.stuLNTB = new System.Windows.Forms.TextBox();
            this.stuFNTB = new System.Windows.Forms.TextBox();
            this.stuIdTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchStuBtn
            // 
            this.searchStuBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.searchStuBtn.Location = new System.Drawing.Point(115, 94);
            this.searchStuBtn.Name = "searchStuBtn";
            this.searchStuBtn.Size = new System.Drawing.Size(75, 23);
            this.searchStuBtn.TabIndex = 9;
            this.searchStuBtn.Text = "Submit";
            this.searchStuBtn.UseMnemonic = false;
            this.searchStuBtn.UseVisualStyleBackColor = true;
            this.searchStuBtn.Click += new System.EventHandler(this.searchStuBtn_Click);
            // 
            // stuLNTB
            // 
            this.stuLNTB.Location = new System.Drawing.Point(93, 67);
            this.stuLNTB.Name = "stuLNTB";
            this.stuLNTB.Size = new System.Drawing.Size(190, 20);
            this.stuLNTB.TabIndex = 6;
            // 
            // stuFNTB
            // 
            this.stuFNTB.Location = new System.Drawing.Point(93, 39);
            this.stuFNTB.Name = "stuFNTB";
            this.stuFNTB.Size = new System.Drawing.Size(190, 20);
            this.stuFNTB.TabIndex = 7;
            // 
            // stuIdTB
            // 
            this.stuIdTB.Location = new System.Drawing.Point(93, 12);
            this.stuIdTB.Name = "stuIdTB";
            this.stuIdTB.Size = new System.Drawing.Size(190, 20);
            this.stuIdTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Id *";
            // 
            // SearchStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 136);
            this.Controls.Add(this.searchStuBtn);
            this.Controls.Add(this.stuLNTB);
            this.Controls.Add(this.stuFNTB);
            this.Controls.Add(this.stuIdTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchStudentForm";
            this.Text = "SearchStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchStuBtn;
        private System.Windows.Forms.TextBox stuLNTB;
        private System.Windows.Forms.TextBox stuFNTB;
        private System.Windows.Forms.TextBox stuIdTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}