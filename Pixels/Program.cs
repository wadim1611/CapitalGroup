using System;

namespace Pixels
{
    class Program
    {
        static void Main()
        {
            int width = 1000; // 4320
            int height = 1000; // 7680
            DeadPixels deadPixels = new DeadPixels();
            var monitor = Monitor.GenerateMonitorPixels(width, height, 1f);
            int groupsCounts = deadPixels.CountGroups(monitor);
            Console.WriteLine($"Monitor has {groupsCounts} dead pixel groups");
        }
    }
}