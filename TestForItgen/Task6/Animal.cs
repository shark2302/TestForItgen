namespace Task6
{
	public class Animal
	{
		public enum Sex
		{
			MAN, 
			WOMEN
		}
		
		private string _name;
		private string _sound;
		private Sex _sex;

		public Animal(string name, string sound, Sex sex)
		{
			_name = name;
			_sound = sound;
			_sex = sex;
		}

		public override string ToString()
		{
			var sex = _sex == Sex.MAN ? "М" : "Ж";
			return $"Животное {_name}({sex}) может делать \"{_sound}\"";
		}
		
	}
}