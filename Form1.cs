// Име: Мартин Бисеров Божански
// Факултетен номер: F113190

using StudentApp.classes;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private Student student; // Обект "Student", който ще записва и отписва курсове.
        private List<Course> allCourses; // Списък с всички налични курсове, които могат да бъдат записани.

        public Form1()
        {
            InitializeComponent();

            
            student = new Student  // Създавам студент
            {
                FullName = "Мартин Бисеров Божански",
                FacultyNumber = "F113190"
            };

            
            allCourses = new List<Course> // Създавам курсове
            {
                new Course("CSCB579", "Програмиране на приложения с Microsoft Visual C# .NET", 6),
                new ElectiveCourse("CSCB520", "JavaScript и NodeJS", 4),
                new Course("CSCB688", "Скриптови езици за Интернет (PHP)", 5)
            };

            
            lstAllCourses.DataSource = allCourses;  // Зареждам наличните курсове
            RefreshStudentInfo(); // Обновявам визуалната информация за студента.
        }

        private void btnEnroll_Click(object sender, EventArgs e) // Бутона "Запиши".
        {
            if (lstAllCourses.SelectedItem is Course course)
            {
                student.Enroll(course);
                RefreshStudentInfo();
            }
        }

        private void btnUnenroll_Click(object sender, EventArgs e) // Бутона "Отпиши".
        {
            if (lstEnrolled.SelectedItem is Course course)
            {
                student.Unenroll(course.Code);
                RefreshStudentInfo();
            }
        }

        private void RefreshStudentInfo()
        {
            lstEnrolled.DataSource = student.GetCourses().ToList();
            lblName.Text = $"Име: {student.FullName}";
            lblFaculty.Text = $"Фак. номер: {student.FacultyNumber}";
            lblCredits.Text = $"Общо кредити: {student.TotalCredits}";
        }

        private void lstAllCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCredits_Click(object sender, EventArgs e)
        {

        }
    }
}