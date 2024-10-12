using Task5.Exception.MyException;

namespace Task5.Exception
{
	internal class UserManager
	{
		#region Поля и свойства

		/// <summary>
		/// Список пользователей.
		/// </summary>
		private List<User> users = new List<User>();
		#endregion

		#region Методы

		/// <summary>
		/// Добавляет пользователя в список.
		/// </summary>
		/// <param name="newUser">Добавляемый пользователь.</param>
		public void AddUser(User newUser)
		{
            ArgumentNullException.ThrowIfNull(newUser);
            var user =  users.FirstOrDefault(x => x.Id == newUser.Id);
            
            if (user != null)
			{
				throw new UserAlreadyExistsException("Пользователь уже существует");
			} 
			users.Add(newUser);
		}

		/// <summary>
		/// Удаляет пользователя из списка по Id.
		/// </summary>
		/// <param name="id">Id пользователя которого нужно удалить из списка.</param>
		public void RemoveUser(Guid id)
		{
			var success = users.Remove(GetUser(id));
			if(!success)
				throw new UserNotFoundException("Пользователь не существует");
		}

		/// <summary>
		/// Возвращает пользователя по Id.
		/// </summary>
		/// <param name="id">Id пользователя которого нужно найти.</param>
		/// <returns>Найденный пользователь.</returns>
		public User GetUser(Guid id)
		{
			var user = users.FirstOrDefault(x => x.Id == id);
			return user ?? throw new UserNotFoundException("Пользователь не существует");
		}

		/// <summary>
		/// Вывести всех пользователей в консоль.
		/// </summary>
		public void ListUsers()
		{
			foreach (var usery in users)
			{
				Console.WriteLine($"ID: {usery.Id}\nName: {usery.Name}\nEmail: {usery.Email}\n");
			}
		}
		#endregion
	}
}
