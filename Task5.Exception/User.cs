namespace Task5.Exception
{
	/// <summary>
	/// Пользователь.
	/// </summary>
	internal class User
	{
		#region Поля и свойства
		
		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Почтовый адрес.
		/// </summary>
		public string Email { get; set; }

		#endregion

		#region Конструкторы

		/// <summary>
		/// Создать, пользователя.
		/// </summary>
		/// <param name="id">Id пользователя.</param>
		/// <param name="name">Имя пользователя.</param>
		/// <param name="email">Адресс пользователя.</param>
		public User(Guid id, string name, string email)
		{
			Id = id;
			Name = name;
			Email = email;
		}
		#endregion
	}
}
