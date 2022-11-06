using System;
using System.Linq;

namespace _03GenericSwapMethodString
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string item = Console.ReadLine();

                box.Items.Add(item);
            }

            int[] indexSwap = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            box.Swap(indexSwap[0], indexSwap[1]);
            
            Console.WriteLine(box.ToString());
        }
    }
}
