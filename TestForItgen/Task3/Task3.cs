using System;
using System.Linq;

namespace Task3
{
	internal class Task3
	{
		private static void PrintArray(int[][] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[0].Length; j++)
				{
					Console.Write(array[i][j] + " ");
				}
				Console.WriteLine();
			}
		}

		private static int[][] ReadArray(int rows, int cols)
		{
			var array = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				array[i] = new int[cols];
				for (int j = 0; j < cols; j++)
				{
					int num;
					Console.Write($"array[{i}][{j}] = ");
					if (Int32.TryParse(Console.ReadLine(), out num))
					{
						array[i][j] = num;
					}
				}
			}
			return array;
		}

		private static int FindMaxAndChangeArray(ref int[][] array)
		{
			int max = Int32.MinValue;
			int[] index = new []{-1, -1};
			
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[0].Length; j++)
				{
					if (max < array[i][j])
					{
						max = array[i][j];
						index[0] = i;
						index[1] = j;
					}
				}
			}

			if (index[0] >= 0 && index[1] >= 0)
			{
				array[index[0]][index[1]] = 0;
			}
			
			return max;
		}	
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Введите количесво рядов: ");
			var rows = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Введите количесво столбцов: ");
			var cols = Int32.Parse(Console.ReadLine());
			var arr = ReadArray(rows, cols);
			Console.WriteLine("Исходный массив: ");
			PrintArray(arr);
			Console.WriteLine("Максимальное число : " + FindMaxAndChangeArray(ref arr));
			Console.WriteLine("Массив после изменений: ");
			PrintArray(arr);
		}
	}
}