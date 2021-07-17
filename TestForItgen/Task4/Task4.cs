using System;

namespace Task4
{
	internal class Task4
	{

		private static int ReadInt()
		{
			int result;
			Console.WriteLine("Введите число: ");
			while (!Int32.TryParse(Console.ReadLine(), out result))
			{
				Console.WriteLine("Это не целое число! Попробуйте еще раз: ");
			}

			return result;
		}
		
		public static void Main(string[] args)
		{
			var r = ReadInt();
		}
	}
}