namespace CourseWork.Helpers;

public class RouteGenerator
{
    private static readonly Random random = new();

    private static readonly string[] names = { "Маршрут 1", "Маршрут 2", "Маршрут 3", "Маршрут 4", "Маршрут 5", "Маршрут 6", "Маршрут 7", "Маршрут 8", "Маршрут 9", "Маршрут 10" };
    private static readonly string[] startLocations = { "Москва", "Санкт-Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казань", "Самара", "Омск", "Челябинск", "Ростов-на-Дону" };
    private static readonly string[] endLocations = { "Краснодар", "Волгоград", "Уфа", "Пермь", "Воронеж", "Саратов", "Красноярск", "Тольятти", "Ижевск", "Ульяновск" };

    public static (string, string, string, double) Generate()
    {
        int index = random.Next(0, names.Length);

        string name = names[index];
        string startLocation = startLocations[index];
        string endLocation = endLocations[index];
        double distance = random.Next(100, 999) + random.NextDouble();

        return (name, startLocation, endLocation, distance);
    }
}
