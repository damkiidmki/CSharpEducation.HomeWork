namespace Task4.EmployeeManager;

/// <summary>
/// Класс Person.
/// </summary>
public class Person(string name)
{
    /// <summary>
    /// Имя сотрудника.
    /// </summary>
    public string Name { get; set; } = name;


    /// <summary>
    /// ID сотрудника.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
}