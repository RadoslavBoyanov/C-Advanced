using System;
using System.Linq;

namespace _04GenericSwapMethodInteger
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                int item = int.Parse(Console.ReadLine());

                box.Items.Add(item);
            }

            int[] indexSwap = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            box.Swap(indexSwap[0], indexSwap[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
