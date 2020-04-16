using System;
using System.Collections.Generic;

namespace Pixels
{
    public class IterativeGroupsCounter : IGroupsCounter
	{
		private const char DEAD_PIXEL = '1';

		/************************************************************************
		* Function to return count of dead pixels group
		* Time Complexity: O(N×M + 4×N×M), where N×M is number of pixels, and each from each of them we try to check 4 neighbours = 4×N×M 
		* Spatial complexity: O(3 × M × N). There we have to keep the monitor itself, visited pixels coordinates and stack
		************************************************************************/
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
					if (monitor[i][j] == DEAD_PIXEL && markedPixels[i][j] == 0)
					{
						MarkGroup(monitor, i, j, markedPixels);
						groupsCounter++;
					}
				}
			}

			return groupsCounter - 1;
		}


		private void MarkGroup(char[][] monitor, int i, int j, byte[][] markedPixels)
		{
			Stack<Pixel> deadPixelsStack = new Stack<Pixel>();
			deadPixelsStack.Push(new Pixel { x = (short)i, y = (short)j });
			markedPixels[i][j] = 1;
			while (deadPixelsStack.Count > 0)
			{
				Console.WriteLine($"Stack: {deadPixelsStack.Count}");
				var t = deadPixelsStack.Pop();
				TryMarkPixel(t.x, t.y - 1, monitor, markedPixels, deadPixelsStack);
				TryMarkPixel(t.x - 1, t.y, monitor, markedPixels, deadPixelsStack);
				TryMarkPixel(t.x, t.y + 1, monitor, markedPixels, deadPixelsStack);
				TryMarkPixel(t.x + 1, t.y, monitor, markedPixels, deadPixelsStack);
			}
		}

		private static bool TryMarkPixel(int i, int j, char[][] monitor, byte[][] visitedPixels, Stack<Pixel> deadPixelsStack)
		{
			if (i < 0 || i >= monitor.Length) return false;
			if (j < 0 || j >= monitor[0].Length) return false;

			if (monitor[i][j] == DEAD_PIXEL && visitedPixels[i][j] == 0)
			{
				deadPixelsStack.Push(new Pixel { x = (short)i, y = (short)j });
				visitedPixels[i][j] = 1;
				return true;
			}

			return false;
		}
	}
}
