namespace RLee.Core.Frontend.Property
{
	public class Color
	{
		public int Value;
		public int Alphal;
		public double Opacity;
		public int Red;
		public int Green;
		public int Blue;

		public Color(int alpha, double opacity, int red, int green, int blue)
		{
			Alphal = alpha;
			Red = red;
			Green = green;
			Blue = blue;
			Opacity = opacity;
		}
	}
}

