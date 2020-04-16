namespace Pixels
{
	public class DeadPixels
	{
		public int CountGroups(char[][] monitor)
		{
			IGroupsCounter groupsCounter = new IterativeGroupsCounter();
			return groupsCounter.CountGroups(monitor);
		}
	}
}