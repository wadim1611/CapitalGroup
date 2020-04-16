using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pixels.Tests
{
    [TestClass]
    public class DeadPixelsTests
    {
        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(4320, 1)]
        [DataRow(1, 7680)]
        [DataRow(4320, 7680)]
        public void CountGroups_RandomMonitor_NoExceptions(int width, int height)
        {
            try
            {
                DeadPixels deadPixels = new DeadPixels();
                var monitor = Monitor.GenerateMonitorPixels(width, height);
                deadPixels.CountGroups(monitor);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void CountGroups_MonitorExampleOne_FiveGroups()
        {
            DeadPixels deadPixels = new DeadPixels();
            char[][] monitor = new char[3][];
            monitor[0] = new char[3] { '1', '0', '1'};
            monitor[1] = new char[3] { '0', '1', '0'};
            monitor[2] = new char[3] { '1', '0', '1' };

            int groupsCount = deadPixels.CountGroups(monitor);
            Assert.AreEqual(5, groupsCount);
        }

        [TestMethod]
        public void CountGroups_MonitorExampleTwo_TwoGroups()
        {
            DeadPixels deadPixels = new DeadPixels();
            char[][] monitor = new char[3][];
            monitor[0] = new char[3] { '1', '1', '1' };
            monitor[1] = new char[3] { '1', '0', '0' };
            monitor[2] = new char[3] { '1', '0', '1' };

            int groupsCount = deadPixels.CountGroups(monitor);
            Assert.AreEqual(2, groupsCount);
        }

        [TestMethod]
        public void CountGroups_NoDeadPixels_ZeroGroups()
        {
            DeadPixels deadPixels = new DeadPixels();
            char[][] monitor = new char[3][];
            monitor[0] = new char[3] { '0', '0', '0' };
            monitor[1] = new char[3] { '0', '0', '0' };
            monitor[2] = new char[3] { '0', '0', '0' };

            int groupsCount = deadPixels.CountGroups(monitor);
            Assert.AreEqual(0, groupsCount);
        }

        [TestMethod]
        public void CountGroups_AllPixelsDead_OneGroup()
        {
            DeadPixels deadPixels = new DeadPixels();
            char[][] monitor = new char[3][];
            monitor[0] = new char[3] { '1', '1', '1' };
            monitor[1] = new char[3] { '1', '1', '1' };
            monitor[2] = new char[3] { '1', '1', '1' };

            int groupsCount = deadPixels.CountGroups(monitor);
            Assert.AreEqual(1, groupsCount);
        }

        [TestMethod]
        public void CountGroups_OnePixelMonitor_OneGroup()
        {
            DeadPixels deadPixels = new DeadPixels();
            char[][] monitor = new char[1][];
            monitor[0] = new char[1] { '1' };

            int groupsCount = deadPixels.CountGroups(monitor);
            Assert.AreEqual(1, groupsCount);
        }
    }
}
