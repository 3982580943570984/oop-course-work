using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Contexts;

/// <summary>
/// Контекст базы данных для приложения автопарк.
/// </summary>
public class AutoParkContext : DbContext
{
    /// <summary>
    /// Коллекция объектов транспортных средств в базе данных.
    /// </summary>
    public DbSet<Transport> Transports { get; set; }

    /// <summary>
    /// Коллекция объектов водителей в базе данных.
    /// </summary>
    public DbSet<Driver> Drivers { get; set; }

    /// <summary>
    /// Коллекция объектов маршрутов в базе данных.
    /// </summary>
    public DbSet<Route> Routes { get; set; }

    /// <summary>
    /// Путь к файлу базы данных.
    /// </summary>
    public string DbPath { get; }

    /// <summary>
    /// Инициализирует новый экземпляр класса AutoParkContext.
    /// </summary>
    public AutoParkContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "autopark.db");
    }

    /// <summary>
    /// Настраивает параметры подключения к базе данных.
    /// </summary>
    /// <param name="optionsBuilder">Строитель опций для контекста базы данных.</param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");

    /// <summary>
    /// Настраивает модель данных для базы данных.
    /// </summary>
    /// <param name="modelBuilder">Строитель модели для контекста базы данных.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Связь один-ко-многим между Route и Transport
        modelBuilder.Entity<Route>()
            .HasMany(r => r.Transports) // каждый Route может иметь множество связанных сущностей Transport
            .WithOne(t => t.Route) // каждая сущность Transport может быть связана только с одной сущностью Route
            .HasForeignKey(t => t.RouteId); // внешний ключ для связи находится в свойстве RouteId в сущности Transport

        // Связь один-к-одному между Transport и Driver
        modelBuilder.Entity<Transport>()
            .HasOne(t => t.Driver) // каждая сущность Transport может быть связана только с одной сущностью Driver
            .WithOne(d => d.Transport) // каждая сущность Driver может быть связана только с одной сущностью Transport
            .HasForeignKey<Driver>(d => d.TransportId); // внешний ключ для связи находится в свойстве TransportId в сущности Driver
    }
}