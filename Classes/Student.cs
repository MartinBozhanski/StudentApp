// Име: Мартин Бисеров Божански
// Факултетен номер: F113190

namespace StudentApp.classes
{
    public class Student
    {
        public string FullName { get; set; } // Пълно име на студента.
        public string FacultyNumber { get; set; } // Факултетен номер на студента.

        private List<Course> enrolled = new(); // Частен списък от записани курсове, използвам "private", за да не може да се промени извън класа.

        public int TotalCredits => enrolled.Sum(c => c.Credits); // Изчислява общия брой кредити.

        public bool Enroll(Course course) // Записва студента в даден курс.
        {
            if (enrolled.Any(c => c.Code == course.Code)) return false; // Проверява дали курсът вече е записан, за да избегне дублиране.
            enrolled.Add(course); 
            return true;
        }

        public bool Unenroll(string code) // Отписва студент от курс.
        {
            return enrolled.RemoveAll(c => c.Code == code) > 0;
        }

        public IReadOnlyList<Course> GetCourses() => enrolled.AsReadOnly(); // Връща списък от всички записани курсове
    }
}