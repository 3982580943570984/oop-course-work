using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Entities;

/// <summary>
/// Представляет транспортное средство в системе управления автопарком.
/// </summary>
[Table("Transportes")]
public class Transport
{
    /// <summary>
    /// Уникальный идентификатор транспортного средства.
    /// </summary>
    [Key]
    [DisplayName("ID")]
    public int Id { get; set; }

    /// <summary>
    /// Модель транспортного средства.
    /// </summary>
    [Required]
    [MaxLength(50)]
    [DisplayName("Модель")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Государственный регистрационный номер транспортного средства.
    /// </summary>
    [Required]
    [MaxLength(6)]
    [DisplayName("Номерной знак")]
    public string LicensePlate { get; set; } = string.Empty;

    /// <summary>
    /// Вместимость транспортного средства.
    /// </summary>
    [Required]
    [Range(2, int.MaxValue)]
    [DisplayName("Кол-во мест")]
    public int Capacity { get; set; }

    /// <summary>
    /// Дата последнего технического обслуживания транспортного средства.
    /// </summary>
    [Required]
    [DisplayName("Дата тех. обслуживания")]
    public DateTime LastMaintenanceDate { get; set; }

    /// <summary>
    /// Текущий пробег транспортного средства.
    /// </summary>
    [Required]
    [Range(0, double.MaxValue)]
    [DisplayName("Пробег")]
    public double Mileage { get; set; }

    /// <summary>
    /// Идентификатор маршрута, на котором работает транспортное средство.
    /// </summary>
    [DisplayName("ID Маршрута")]
    public int? RouteId { get; set; }

    /// <summary>
    /// Маршрут, на котором работает транспортное средство.
    /// </summary>
    [DisplayName("Маршрут")]
    public Route? Route { get; set; }

    /// <summary>
    /// Идентификатор водителя, который управляет транспортным средством.
    /// </summary>
    [DisplayName("ID Водителя")]
    public int? DriverId { get; set; }

    /// <summary>
    /// Водитель, который управляет транспортным средством.
    /// </summary>
    [DisplayName("Водитель")]
    public Driver? Driver { get; set; }

    /// <summary>
    /// Возвращает строковое представление объекта транспортного средства, содержащее его идентификатор, модель, государственный регистрационный номер и вместимость.
    /// </summary>
    /// <returns>Строковое представление объекта транспортного средства.</returns>
    public override string ToString()
        => $"Бренд: {Model}, Номер. знак: {LicensePlate}, Вместимость: {Capacity}";
}
