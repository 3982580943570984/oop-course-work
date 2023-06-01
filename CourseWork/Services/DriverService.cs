using CourseWork.Contexts;
using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Services;

/// <summary>
/// Сервис для выполнения операций с водителями в базе данных.
/// </summary>
public class DriverService
{
    private readonly AutoParkContext _dbContext = new();

    /// <summary>
    /// Инициализирует новый экземпляр класса DriverService.
    /// </summary>
    /// <param name="dbContext">Контекст базы данных.</param>
    public DriverService(AutoParkContext dbContext) => _dbContext = dbContext;

    /// <summary>
    /// Возвращает список всех водителей в базе данных.
    /// </summary>
    /// <returns>Список всех водителей в базе данных.</returns>
    public async Task<List<Driver>> GetAllDriversAsync() => await _dbContext.Drivers.ToListAsync();

    /// <summary>
    /// Возвращает водителя по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор водителя.</param>
    /// <returns>Водитель с указанным идентификатором.</returns>
    public async Task<Driver?> GetDriverByIdAsync(int id) => await _dbContext.Drivers.FindAsync(id);

    /// <summary>
    /// Добавляет нового водителя в базу данных.
    /// </summary>
    /// <param name="driver">Новый водитель.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task AddDriverAsync(Driver driver)
    {
        _dbContext.Drivers.Add(driver);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Обновляет существующего водителя в базе данных.
    /// </summary>
    /// <param name="driver">Водитель для обновления.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task UpdateDriverAsync(Driver driver)
    {
        _dbContext.Update(driver);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Удаляет водителя из базы данных по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор водителя.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task DeleteDriverAsync(int id)
    {
        var driver = await GetDriverByIdAsync(id);
        if (driver != null)
        {
            _dbContext.Drivers.Remove(driver);
            await _dbContext.SaveChangesAsync();
        }
    }
}
