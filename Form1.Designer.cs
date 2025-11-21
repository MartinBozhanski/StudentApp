namespace FirstTask
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstAllCourses = new ListBox();
            lstEnrolled = new ListBox();
            btnEnroll = new Button();
            btnUnenroll = new Button();
            lblName = new Label();
            lblFaculty = new Label();
            lblCredits = new Label();
            SuspendLayout();
           
            lstAllCourses.FormattingEnabled = true;
            lstAllCourses.ItemHeight = 15;
            lstAllCourses.Location = new Point(12, 13);
            lstAllCourses.Name = "lstAllCourses";
            lstAllCourses.Size = new Size(564, 94);
            lstAllCourses.TabIndex = 0;
            lstAllCourses.SelectedIndexChanged += lstAllCourses_SelectedIndexChanged;
            
            lstEnrolled.FormattingEnabled = true;
            lstEnrolled.ItemHeight = 15;
            lstEnrolled.Location = new Point(12, 127);
            lstEnrolled.Name = "lstEnrolled";
            lstEnrolled.Size = new Size(564, 94);
            lstEnrolled.TabIndex = 1;
           
            btnEnroll.Location = new Point(607, 175);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(75, 23);
            btnEnroll.TabIndex = 2;
            btnEnroll.Text = "Запиши";
            btnEnroll.UseVisualStyleBackColor = true;
            btnEnroll.Click += btnEnroll_Click;
           
            btnUnenroll.Location = new Point(607, 222);
            btnUnenroll.Name = "btnUnenroll";
            btnUnenroll.Size = new Size(75, 23);
            btnUnenroll.TabIndex = 3;
            btnUnenroll.Text = "Отпиши";
            btnUnenroll.UseVisualStyleBackColor = true;
            btnUnenroll.Click += btnUnenroll_Click;
           
            lblName.AutoSize = true;
            lblName.Location = new Point(607, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Име на студента";
           
            lblFaculty.AutoSize = true;
            lblFaculty.Location = new Point(607, 92);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(109, 15);
            lblFaculty.TabIndex = 5;
            lblFaculty.Text = "Факултетен номер";
           
            lblCredits.AutoSize = true;
            lblCredits.Location = new Point(607, 127);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(88, 15);
            lblCredits.TabIndex = 6;
            lblCredits.Text = "Общо кредити";
            lblCredits.Click += lblCredits_Click;
           
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCredits);
            Controls.Add(lblFaculty);
            Controls.Add(lblName);
            Controls.Add(btnUnenroll);
            Controls.Add(btnEnroll);
            Controls.Add(lstEnrolled);
            Controls.Add(lstAllCourses);
            Name = "Form1";
            Text = "Система за записване";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAllCourses;
        private ListBox lstEnrolled;
        private Button btnEnroll;
        private Button btnUnenroll;
        private Label lblName;
        private Label lblFaculty;
        private Label lblCredits;
    }
}
