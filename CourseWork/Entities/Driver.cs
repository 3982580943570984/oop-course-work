using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Entities;

/// <summary>
/// Представляет водителя в системе управления автопарком.
/// </summary>
[Table("Drivers")]
public class Driver
{
    /// <summary>
    /// Уникальный идентификатор водителя.
    /// </summary>
    [Key]
    [DisplayName("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Имя водителя.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Имя")]
    public string? FirstName { get; set; }

    /// <summary>
    /// Фамилия водителя.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Фамилия")]
    public string? LastName { get; set; }

    /// <summary>
    /// Возраст водителя.
    /// </summary>
    [Required]
    [DisplayName("Возраст")]
    public int Age { get; set; }

    /// <summary>
    /// Опыт вождения водителя в годах.
    /// </summary>
    [Required]
    [Range(0, int.MaxValue)]
    [DisplayName("Опыт вождения в годах")]
    public int DrivingExperience { get; set; }

    /// <summary>
    /// Внешний ключ, связывающий водителя с транспортным средством.
    /// </summary>
    [DisplayName("ID Транспорта")]
    public int? TransportId { get; set; }

    /// <summary>
    /// Навигационное свойство, которое позволяет получить объект транспортного средства, связанный с данным водителем.
    /// </summary>
    [DisplayName("Транспорт")]
    public Transport? Transport { get; set; }

    /// <summary>
    /// Внешний ключ, связывающий водителя с маршрутом.
    /// </summary>
    [DisplayName("ID Маршрута")]
    public int? RouteId { get; set; }

    /// <summary>
    /// Коллекция маршрутов, которые может обслуживать данный водитель.
    /// </summary>
    [DisplayName("Маршрут")]
    public Route? Route { get; set; }

    /// <summary>
    /// Возвращает строковое представление объекта водителя, содержащее его идентификатор, имя, фамилию, возраст и опыт вождения.
    /// </summary>
    /// <returns>Строковое представление объекта водителя.</returns>
    public override string ToString()
        => $"{FirstName} {LastName}, возраст: {Age}, стаж: {DrivingExperience}";
}