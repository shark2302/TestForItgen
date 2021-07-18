using System;
using System.Collections.Generic;

namespace Task6
{
	internal class Task6
	{
		public static void Main(string[] args)
		{
			List<Aviary> aviaries = new List<Aviary>(4);
			aviaries.Add(new Aviary(new List<Animal>(new []{new Animal("Лев", "ррр", Animal.Sex.MAN),
				new Animal("Лев", "рррр", Animal.Sex.WOMEN)})));
			
			aviaries.Add(new Aviary(new List<Animal>(new []{new Animal("Волк", "ауф", Animal.Sex.MAN), 
				new Animal("Волк", "ауф", Animal.Sex.WOMEN), new Animal("Гиена", "фффф", Animal.Sex.MAN)})));
			
			aviaries.Add(new Aviary(new List<Animal>(new []{new Animal("Попугай", "Привет", Animal.Sex.MAN), 
				new Animal("Павлин", "ааа", Animal.Sex.WOMEN), new Animal("Курица", "ко-ко", Animal.Sex.MAN)})));
			
			aviaries.Add(new Aviary(new List<Animal>(new []{new Animal("Крокодил", "агрррр", Animal.Sex.MAN), 
				new Animal("Аллигатор", "агррр", Animal.Sex.WOMEN)})));
			
			while (true)
			{
				Console.WriteLine("Выберете к какому вольеру подойти : ");
				for (int i = 0; i < aviaries.Count; i++)
				{
					Console.WriteLine($"{i + 1}) {aviaries[i]}");
				}
				Console.WriteLine("Нажмите 0, чтобы завершить программу\n");
				
				int choice = Int32.Parse(Console.ReadLine());
				if(choice == 0) 
					break;
					
				Console.WriteLine($"Подбробная информация о вольере №{choice}:\n{aviaries[choice - 1].GetInfo()}");
			}
			
			
		}
	}
}