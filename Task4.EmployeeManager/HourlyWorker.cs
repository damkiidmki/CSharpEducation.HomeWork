namespace Task4.EmployeeManager;

/// <summary>
/// Почасовой рабочий.
/// </summary>
public class HourlyWorker(string name) : Worker(name)
{
    /// <summary>
    /// Почасовая ставка.
    /// </summary>
    private decimal HourlyRate { get; set; }

    /// <summary>
    /// Количество отработанных часов.
    /// </summary>
    private decimal HoursWorked { get; set; }
    
    public override decimal Salary()
    {
        return HoursWorked * HourlyRate;
    }
    
    public override void SetInformationSalary()
    {
        Console.Write("Почасовая ставка?");
        HourlyRate = decimal.Parse(Console.ReadLine() ?? string.Empty);
        Console.Write("Сколько отработал сотрудник?");
        HoursWorked = decimal.Parse(Console.ReadLine() ?? string.Empty);
    }
    
    public override string ToString()
    {
        return $"Id: {Id} Name: {Name}";
    }
}