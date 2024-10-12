namespace Task5.Exception
{
  internal class Program
  {
    static void Main(string[] args)
    {
      UserManager userManager = new UserManager();
      MainMenu(userManager);
    }
    
    /// <summary>
    /// Вызов главного меню.
    /// </summary>
    static void MainMenu(UserManager userManager)
    {
      Console.Write(
        "1. Добавить пользователя\n" +
        "2. Удаление пользователя\n" +
        "3. Найти пользователя\n" +
        "4. Получить информацию о всех пользователях\n" +
        "5. Выйти\n" +
        "Выберите действие: ");
      if (int.TryParse(Console.ReadLine(), out int request))
      {
        Guid id;
        switch (request)
        {
          case 1:
            Console.WriteLine("Введите id: ");
            id = Guid.Parse(Console.ReadLine());
            Console.WriteLine("Введите Имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите почту: ");
            var email = Console.ReadLine();
            var user = new User(id, name, email);
            userManager.AddUser(user);
            Console.WriteLine("Пользователь добавлен успешно!");
            break;
          case 2:
            Console.WriteLine("Введите id: ");
            id = Guid.Parse(Console.ReadLine());
            userManager.RemoveUser(id);
            Console.WriteLine("Пользователь удален успешно!\n");
            break;
          case 3:
            Console.WriteLine("Введите id искомого сотрудника: ");
            id = Guid.Parse(Console.ReadLine());
            var userGet = userManager.GetUser(id);
            Console.WriteLine($"id: {userGet.Id}\n" +
                              $"name: {userGet.Name}\n" +
                              $"email: {userGet.Email}\n");
            break;
          case 4:
            userManager.ListUsers();
            break;
          case 5:
            return;
        }
        MainMenu(userManager);
      }
    }
  }
}
