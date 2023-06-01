using CourseWork.Contexts;
using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Services;

/// <summary>
/// Сервис для выполнения операций с транспортом в базе данных.
/// </summary>
public class TransportService
{
    private readonly AutoParkContext _dbContext;

    /// <summary>
    /// Инициализирует новый экземпляр класса TransportService.
    /// </summary>
    /// <param name="dbContext">Контекст базы данных.</param>
    public TransportService(AutoParkContext dbContext) => _dbContext = dbContext;

    /// <summary>
    /// Возвращает список всех транспортных средств в базе данных.
    /// </summary>
    /// <returns>Список всех транспортных средств в базе данных.</returns>
    public async Task<List<Transport>> GetAllTransportsAsync() => await _dbContext.Transports.ToListAsync();

    /// <summary>
    /// Возвращает транспортное средство по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор транспортного средства.</param>
    /// <returns>Транспортное средство с указанным идентификатором.</returns>
    public async Task<Transport?> GetTransportByIdAsync(int id) => await _dbContext.Transports.FindAsync(id);

    /// <summary>
    /// Добавляет новое транспортное средство в базу данных.
    /// </summary>
    /// <param name="transport">Новое транспортное средство.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task AddTransportAsync(Transport transport)
    {
        _dbContext.Transports.Add(transport);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Обновляет существующее транспортное средство в базе данных.
    /// </summary>
    /// <param name="transport">Транспортное средство для обновления.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task UpdateTransportAsync(Transport transport)
    {
        _dbContext.Update(transport);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Удаляет транспортное средство из базы данных по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор транспортного средства.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task DeleteTransportAsync(int id)
    {
        var transport = await GetTransportByIdAsync(id);
        if (transport != null)
        {
            _dbContext.Transports.Remove(transport);
            await _dbContext.SaveChangesAsync();
        }
    }
}
