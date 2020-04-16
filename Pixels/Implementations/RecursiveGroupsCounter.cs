namespace Pixels
{
	public class RecursiveGroupsCounter : IGroupsCounter
	{
        private const char DEAD_PIXEL = '1';

		// to prevent backward side check
		private enum Side
		{
			none = 0,
			left = 1,
			top = 2,
			right = 3,
			bottom = 4
		}

		public int CountGroups(char[][] monitor)
		{
			int groupsCounter = 1;
			byte[][] markedPixels = new byte[monitor.Length][];
			for (short i = 0; i < monitor.Length; i++)
			{
				markedPixels[i] = new byte[monitor[0].Length];
			}

			for (short i = 0; i < monitor.Length; i++)
			{
				for (short j = 0; j < monitor[i].Length; j++)
				{
					if (monitor[i][j] == DEAD_PIXEL)
					{
						if (DFS(monitor, i, j, markedPixels, Side.none))
						{
							groupsCounter++;
						}
					}
				}
			}

			return groupsCounter - 1;
		}

		private static bool DFS(char[][] monitor, int i, int j, byte[][] deadPixels, Side sideCameFrom)
		{
			// boundaries check
			if (i < 0 || i >= monitor.Length) return false;
			if (j < 0 || j >= monitor[0].Length) return false;

			if (monitor[i][j] == DEAD_PIXEL && deadPixels[i][j] == 0)
			{
				deadPixels[i][j] = 1;
				if (sideCameFrom != Side.left) DFS(monitor, i, j - 1, deadPixels, Side.right);
				if (sideCameFrom != Side.bottom) DFS(monitor, i - 1, j, deadPixels, Side.top);
				if (sideCameFrom != Side.right) DFS(monitor, i, j + 1, deadPixels, Side.left);
				if (sideCameFrom != Side.top) DFS(monitor, i + 1, j, deadPixels, Side.bottom);
				return true;
			}

			return false;
		}
	}
}
