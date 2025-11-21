// Име: Мартин Бисеров Божански
// Факултетен номер: F113190

namespace StudentApp.classes
{
    public interface ICreditBearing // Интерфейс, който определя, че даден обект има кредити.
    {
        int Credits { get; }
    }

    public class Course : ICreditBearing
    {
        public string Code { get; } // Кода на курса
        public string Name { get; } // Име на курса.
        public virtual int Credits { get; } // Брой кредити на курса, използвам "virtual", за да мога да го променям в наследени класове например.

        public Course(string code, string name, int credits) // Конструктор за създаване на курс с код, име и кредити.
        {
            Code = code;
            Name = name;
            Credits = credits;
        }

        public override string ToString() => $"{Code} - {Name} ({Credits} кредита)"; // Връща текстово описание на курса в удобен за показване формат.
    }
}