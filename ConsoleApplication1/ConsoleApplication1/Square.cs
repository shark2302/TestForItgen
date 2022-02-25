using System.Data.SqlClient;

namespace ConsoleApplication1
{
	public class Square
	{
		protected int side;

		public Square(int side)
		{
			this.side = side;
		}

		public Square()
		{
			
		}

		public virtual int CalcSquare()
		{
			return side * side;
		}

		public virtual int CalcPerimeter()
		{
			return 4 * side;
		}
	}
}