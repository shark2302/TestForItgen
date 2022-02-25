using System;
using System.IO;

namespace InfBez
{
	public class Algorithm
	{
		public static void Main(string[] args)
		{
			Crypt c = new Crypt("test");
			c.CryptText("1124", 8);
			c.CryptText("1124", 8, true);
		}
	}
}