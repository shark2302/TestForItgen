using System.Collections.Generic;

namespace ConsoleApplication2
{
	public class ListClass
	{
		private HashSet<string> _set;

		public ListClass(HashSet<string> set)
		{
			_set = set;
		}

		public void AddString(string a)
		{
			AddString(a, _set);
		}

		private void AddString(string a, HashSet<string> set)
		{
			set.Add(a);
		}
	}
}