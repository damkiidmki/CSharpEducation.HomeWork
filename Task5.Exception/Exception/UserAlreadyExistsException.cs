namespace Task5.Exception.MyException
{
	internal class UserAlreadyExistsException : System.Exception
	{
		/// <summary>
		/// Это исключение выбрасывается, если пользователь существует в списке сотрудников.
		/// </summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		public UserAlreadyExistsException(string message) : base(message) { }
	}
}
