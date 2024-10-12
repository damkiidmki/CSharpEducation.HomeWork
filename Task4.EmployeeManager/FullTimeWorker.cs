namespace Task4.EmployeeManager;

/// <summary>
/// Рабочий на полную ставку.
/// </summary>
public class FullTimeWorker(string name) : Worker(name)
{
    /// <summary>
    /// Зарплата.
    /// </summary>
    private decimal FullTimeSalary { get; set; }
    
    public override decimal Salary()
    {
        return FullTimeSalary;
    }

    public override void SetInformationSalary()
    {
        Console.Write("Зарплата сотрудника?");
        FullTimeSalary = decimal.Parse(Console.ReadLine() ?? string.Empty);
    }

    public override string ToString()
    {
        return $"Id: {Id} Name: {Name}";
    }
}