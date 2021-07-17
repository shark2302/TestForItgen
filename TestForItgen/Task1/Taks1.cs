using System;

namespace TestForItgen
{
	internal class Taks1
	{
		private const int WAITING_TIME = 10;
		private static string MinutesToStringFormat(int minutesCount)
		{
			return $"{minutesCount / 60} ч {minutesCount % 60} мин";
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Сколько человек в очереди?");
			var queueCount = int.Parse(Console.ReadLine());
			Console.WriteLine("Время ожидания: " + MinutesToStringFormat(queueCount * WAITING_TIME));
		}
	}
}