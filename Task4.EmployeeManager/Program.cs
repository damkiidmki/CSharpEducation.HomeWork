namespace Task4.EmployeeManager
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var manager = new EmployeeManager();
      MainMenu(manager);
      Console.ReadLine();
    }
    
    /// <summary>
    /// Главное меню. 
    /// </summary>
    /// <param name="manager">Менеджер.</param>
    static void MainMenu(EmployeeManager manager)
    {
      try
      {
        Console.Write(
          '\n' +
          "1: Добавить сотрудника на полную ставку\n" +
          "2: Добавить сотрудника c почасовой ставкой\n" +
          "3: Получить информацию о сотруднике по id\n" +
          "4: Обновить данные сотрудника по id\n" +
          "5: Получить всех сотрудников\n" +
          "Выберите действие: ");
        if (int.TryParse(Console.ReadLine(), out int request))
        {
          Worker worker;
          switch (request)
          {
            case 1:
              Console.Write("Введите имя сотрудника: ");
              var fullTimeWorker = new FullTimeWorker(Console.ReadLine());
              manager.Add(fullTimeWorker);
              fullTimeWorker.SetInformationSalary();
              Console.WriteLine("Cотрудник добавлен.");
              break;
            case 2:
              Console.Write("Введите имя сотрудника: ");
              var hurlyWorker = new HourlyWorker(Console.ReadLine());
              manager.Add(hurlyWorker);
              hurlyWorker.SetInformationSalary();
              Console.WriteLine("Cотрудник добавлен.");
              break;
            case 3:
              Console.Write("Введите id сотрудника: ");
              worker = manager.GetWorkersById(Guid.Parse(Console.ReadLine()));
              Console.Write($"Имя: {worker.Name}\nЗарплата: {worker.Salary()}\n");
              break;
            case 4:
              Console.Write("Введите id сотрудника: ");
              worker = manager.GetWorkersById(Guid.Parse(Console.ReadLine()));
              if (worker != null)
              {
                Console.Write(
                  "Какие данные поменять\n" +
                  "1. Изменить имя сотрудника\n" +
                  "2. Изменить зарплату сотруднику\n" +
                  "Выберите действие: ");
                if (int.TryParse(Console.ReadLine(), out int requesting))
                {
                  switch (requesting)
                  {
                    case 1:
                      Console.Write("Введите имя сотрудника: ");
                      worker.Name = Console.ReadLine();
                      break;
                    case 2:
                      worker.SetInformationSalary();
                      break;
                  }
                }
              }
              else 
                Console.WriteLine("Сотрудник не найден.");
              break;
            case 5:
              Console.Write(string.Join('\n', manager.GetWorkers()));
              break;
          }
        }
        else
          throw new ArgumentException("Bad request");
        MainMenu(manager);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
