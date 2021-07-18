using System.Collections.Generic;

namespace Task6
{
	public class Aviary
	{
		private List<Animal> _animals;
		
		public Aviary(List<Animal> animals)
		{
			_animals = animals;
		}

		public int GetCount()
		{
			return _animals.Count;
		}

		public override string ToString()
		{
			return $"Вольер ({GetCount()} животных)";
		}

		public string GetInfo()
		{
			string res = string.Empty;
			res += "В этом вольере следующие животные: \n";
			for (int i = 0; i < _animals.Count; i++)
			{
				res += _animals[i] + "\n";
			}

			return res;
		}
	}
}