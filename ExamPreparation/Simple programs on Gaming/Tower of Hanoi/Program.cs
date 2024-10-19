
namespace Tower_of_Hanoi
{
	public class Program
	{
		static void Main(string[] args)
		{
			char startPeg = 'A';
			char ednPeg = 'C';
			char tempPeg = 'B';
			int totalDisks = 3;

			solveTowers(totalDisks, startPeg, ednPeg, tempPeg);

		}

		private static void solveTowers(int n, char startPeg, char ednPeg, char tempPeg)
		{
			if (n > 0)
			{
				solveTowers(n - 1, startPeg, tempPeg, ednPeg);
                Console.WriteLine("Move disk from " + startPeg + " " + ednPeg);
				solveTowers(n - 1, tempPeg, ednPeg, startPeg);
            }
		}
	}
}
