using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Entities;

/// <summary>
/// Представляет маршрут в системе управления автопарком.
/// </summary>
[Table("Routes")]
public class Route
{
    /// <summary>
    /// Уникальный идентификатор маршрута.
    /// </summary>
    [Key]
    [DisplayName("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Название маршрута.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Название")]
    public string? Name { get; set; }

    /// <summary>
    /// Начальное местоположение маршрута.
    /// </summary>
    [Required]
    [MaxLength(255)]
    [DisplayName("Стартовая точка")]
    public string? StartLocation { get; set; }

    /// <summary>
    /// Конечное местоположение маршрута.
    /// </summary>
    [Required]
    [MaxLength(255)]
    [DisplayName("Конечная точка")]
    public string? EndLocation { get; set; }

    /// <summary>
    /// Длина маршрута в километрах.
    /// </summary>
    [Required]
    [Range(0, int.MaxValue)]
    [DisplayName("Длина маршрута")]
    public int Distance { get; set; }

    /// <summary>
    /// Время начала движения по маршруту.
    /// </summary>
    [Required]
    [DisplayName("Начало движения")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// Время окончания движения по маршруту.
    /// </summary>
    [Required]
    [DisplayName("Конец движения")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// Коллекция транспортных средств, которые могут обслуживать данный маршрут.
    /// </summary>
    [DisplayName("Транспорт")]
    public List<Transport?> Transports { get; set; } = new();

    /// <summary>
    /// Коллекция водителей, которые могут обслуживать данный маршрут.
    /// </summary>
    [DisplayName("Водители")]
    public List<Driver?> Drivers { get; set; } = new();

    /// <summary>
    /// Возвращает строковое представление объекта маршрута, содержащее его идентификатор, название, начальное и конечное местоположение, длину, время начала и окончания движения по маршруту.
    /// </summary>
    /// <returns>Строковое представление объекта маршрута.</returns>
    public override string ToString()
        => $"Название: {Name}, Нач. точка: {StartLocation}, Конеч. точка: {EndLocation}, Расстояние: {Distance}, Время начала: {StartTime}, Время конца: {EndTime}";
}
