namespace ConsoleApplication1
{
	public class Rectangle : Square
	{
		private int side2;
		
		public Rectangle(int side, int side2) : base(side)
		{
			this.side2 = side2;
		}

		public override int CalcPerimeter()
		{
			return (side + side2) * 2;
		}

		public override int CalcSquare()
		{
			return side * side2;
		}
	}
}