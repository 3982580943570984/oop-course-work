namespace CourseWork.Helpers;

public class DriverGenerator
{
    private static readonly string[] firstNames = { "Александр", "Алексей", "Анатолий", "Андрей", "Борис", "Вадим", "Валентин", "Валерий", "Василий", "Виктор", "Виталий", "Владимир", "Владислав", "Геннадий", "Георгий", "Григорий", "Даниил", "Денис", "Дмитрий", "Евгений", "Егор", "Иван", "Игорь", "Константин", "Леонид" };
    private static readonly string[] lastNames = { "Иванов", "Смирнов", "Кузнецов", "Попов", "Соколов", "Лебедев", "Козлов", "Новиков", "Морозов", "Петров", "Волков", "Соловьев", "Васильев", "Зайцев", "Павлов", "Семенов", "Голубев", "Виноградов", "Богданов", "Федоров", "Михайлов", "Беляев", "Тимофеев", "Крылов", "Никитин" };

    public static (string, string, ushort, ushort) Generate()
    {
        Random random = new();

        string firstName = firstNames[random.Next(firstNames.Length)];
        string lastName = lastNames[random.Next(lastNames.Length)];
        ushort age = (ushort)random.Next(18, 60);
        ushort drivingExperience = (ushort)random.Next(0, 50);

        return (firstName, lastName, age, drivingExperience);
    }
}