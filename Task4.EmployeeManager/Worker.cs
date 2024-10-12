namespace Task4.EmployeeManager;

/// <summary>
/// Класс рабочего.
/// </summary>
public abstract class Worker : Person
{
    /// <summary>
    /// Зарплата.
    /// </summary>
    public abstract decimal Salary();

    /// <summary>
    /// Заполнить данные о зарплате.
    /// </summary>
    public abstract void SetInformationSalary ();

    protected Worker(string name) : base(name)
    {
    }
}