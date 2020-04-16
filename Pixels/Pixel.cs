namespace Pixels
{
	public class Pixel
	{
		public short x;
		public short y;

		public Pixel() { }

		public override int GetHashCode()
		{
			return x * y;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Pixel);
		}

		public bool Equals(Pixel vertex)
		{
			return vertex != null
				&& vertex.x == x
				&& vertex.y == y;
		}
	}
}
