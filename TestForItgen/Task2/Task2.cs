using System;
using System.Xml;

namespace Task2
{
	internal class Task2
	{
		private const string SECRET_MESSAGE = "Secret";
		private const string PASSWORD = "qw123";
		private const int ATTEMPT_LIMIT = 3;
		
		public static void Main(string[] args)
		{
			string password = string.Empty;
			for (int attempt = 1; attempt <= ATTEMPT_LIMIT ; attempt++)
			{
				Console.WriteLine("Введите пароль: ");
				password = Console.ReadLine();
				if (password == PASSWORD)
				{
					Console.WriteLine("Пароль верный. Секретное слово : " + SECRET_MESSAGE);
					break;
				}
				else
				{
					Console.WriteLine("Пароль неверный. Попыток осталось: " + (ATTEMPT_LIMIT - attempt ));
				}
			}
		}
	}
}