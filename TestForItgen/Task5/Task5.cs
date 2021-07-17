using System;
using System.Collections.Generic;

namespace Task5
{
	internal class Task5
	{
		public static void Main(string[] args)
		{
			var purchases = new int[]{1234, 5000, 600, 700};
			Queue<int> queue = new Queue<int>(purchases);
			int number = 1;
			int sum = 0;
			while (queue.Count > 0)
			{
				int check = queue.Dequeue();
				sum += check;
				Console.WriteLine($"Чек покупателя №{number} : {check}\nОбщая сумма выручки за сегодня:{sum}.\nНажмите ENTER, чтобы продолжить");
				Console.ReadLine();
				number++;
			}
		}
	}
}