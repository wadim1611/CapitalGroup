using System;

namespace Pixels
{
    public static class Monitor
    {
		public static char[][] GenerateMonitorPixels(int width, int height, float deadProbability = 0.2f)
		{
			Random rnd = new Random();
			char[][] monitor = new char[height][];

			for (short i = 0; i < height; i++)
			{
				monitor[i] = new char[width];
				for (short j = 0; j < width; j++)
				{
					monitor[i][j] = rnd.NextDouble() <= deadProbability ? '1' : '0';
				}
			}

			return monitor;
		}

		private static void DisplayPixels(char[][] monitor)
		{
			for (short i = 0; i < monitor.Length; i++)
			{
				for (short j = 0; j < monitor[i].Length; j++)
				{
					Console.Write(monitor[i][j]);
				}
				Console.WriteLine();
			}
		}
	}
}
