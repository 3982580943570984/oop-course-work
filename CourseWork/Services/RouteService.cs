using CourseWork.Contexts;
using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseWork.Services;

/// <summary>
/// Сервис для выполнения операций с маршрутами в базе данных.
/// </summary>
public class RouteService
{
    private readonly AutoParkContext _dbContext;

    /// <summary>
    /// Инициализирует новый экземпляр класса RouteService.
    /// </summary>
    /// <param name="dbContext">Контекст базы данных.</param>
    public RouteService(AutoParkContext dbContext) => _dbContext = dbContext;

    /// <summary>
    /// Возвращает список всех маршрутов в базе данных.
    /// </summary>
    /// <returns>Список всех маршрутов в базе данных.</returns>
    public async Task<List<Route>> GetAllRoutesAsync() => await _dbContext.Routes.ToListAsync();

    /// <summary>
    /// Возвращает маршрут по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор маршрута.</param>
    /// <returns>Маршрут с указанным идентификатором.</returns>
    public async Task<Route?> GetRouteByIdAsync(int id) => await _dbContext.Routes.FindAsync(id);

    /// <summary>
    /// Добавляет новый маршрут в базу данных.
    /// </summary>
    /// <param name="route">Новый маршрут.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task AddRouteAsync(Route route)
    {
        _dbContext.Routes.Add(route);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Обновляет существующий маршрут в базе данных.
    /// </summary>
    /// <param name="route">Маршрут для обновления.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task UpdateRouteAsync(Route route)
    {
        _dbContext.Update(route);
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Удаляет маршрут из базы данных по его идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор маршрута.</param>
    /// <returns>Асинхронная задача.</returns>
    public async Task DeleteRouteAsync(int id)
    {
        var route = await GetRouteByIdAsync(id);
        if (route != null)
        {
            _dbContext.Routes.Remove(route);
            await _dbContext.SaveChangesAsync();
        }
    }
}