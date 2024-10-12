namespace Task4.EmployeeManager;

/// <summary>
/// Менеджер сотрудников.
/// </summary>
public class EmployeeManager
{
    /// <summary>
    /// Список сотрудников.
    /// </summary>
    private List<Worker> _workers = new List<Worker>();
    
    /// <summary>
    /// Добавление сотрудника.
    /// </summary>
    /// <param name="worker"></param>
    public void Add(Worker worker)
    {
        _workers.Add(worker);
    }
    
    /// <summary>
    /// Получение сотрудника по id.
    /// </summary>
    /// <param name="id">Id сотрудника.</param>
    /// <returns>Список сотрудников с выбранным именем.</returns>
    public Worker GetWorkersById(Guid id)
    {
        return _workers.Find(x => x.Id == id);
    }

    /// <summary>
    /// Получить сотрудников.
    /// </summary>
    /// <returns></returns>
    public IList<Worker> GetWorkers()
    {
        return _workers;
    }
}