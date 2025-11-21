// Име: Мартин Бисеров Божански
// Факултетен номер: F113190

namespace StudentApp.classes
{
    public class ElectiveCourse : Course
    {
        public ElectiveCourse(string code, string name, int credits) // Конструкторът приема код, име и кредити
            : base(code, name, credits) { }

        public override int Credits => base.Credits + 1; // Презаписва "Credits" от базовия клас, като добавя 1 бонус кредит.

        public override string ToString() => base.ToString() + " + бонус"; // Презаписва "ToString()", за да добави текст, указващ бонус кредити.
    }
}