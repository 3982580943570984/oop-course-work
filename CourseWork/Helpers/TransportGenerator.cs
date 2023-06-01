namespace CourseWork.Helpers;

public class TransportGenerator
{
    private static readonly string[] carBrands = { "Acura", "Alfa Romeo", "Aston Martin", "Audi", "Bentley", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroen", "Dodge", "Ferrari", "Fiat", "Ford", "Genesis", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Mazda", "McLaren", "Mercedes-Benz", "Mini", "Mitsubishi", "Nissan", "Pagani", "Peugeot", "Porsche", "Ram", "Renault", "Rolls-Royce", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo", "W Motors", "Zenvo", "Zotye" }; private static readonly string[] lastNames = { "Иванов", "Смирнов", "Кузнецов", "Попов", "Соколов", "Лебедев", "Козлов", "Новиков", "Морозов", "Петров", "Волков", "Соловьев", "Васильев", "Зайцев", "Павлов", "Семенов", "Голубев", "Виноградов", "Богданов", "Федоров", "Михайлов", "Беляев", "Тимофеев", "Крылов", "Никитин" };
    private static readonly string[] licensePlateLetters = { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" };

    public static (string, List<string>, ushort, DateTime, ushort) Generate()
    {
        Random random = new();

        string model = carBrands[random.Next(carBrands.Length)];
        List<string> licensePlate = new(){
            licensePlateLetters[random.Next(licensePlateLetters.Length)],
            $"{random.Next(1, 999):000}",
            licensePlateLetters[random.Next(licensePlateLetters.Length)],
            licensePlateLetters[random.Next(licensePlateLetters.Length)]
            };
        ushort capacity = (ushort)random.Next(10, 60);

        DateTime start = new(2000, 1, 1);
        int range = (DateTime.Today - start).Days;
        DateTime lastMaintenanceDate = start.AddDays(random.Next(range))
                                            .AddHours(random.Next(24))
                                            .AddMinutes(random.Next(60))
                                            .AddSeconds(random.Next(60))
                                            .AddMilliseconds(random.Next(1000));

        ushort mileage = (ushort)random.Next(0, 1_000_000);

        return (model, licensePlate, capacity, lastMaintenanceDate, mileage);
    }
}
