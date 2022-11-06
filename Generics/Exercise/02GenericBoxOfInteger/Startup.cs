using System;

namespace _02GenericBoxOfInteger
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

            Console.WriteLine(box.ToString());
        }
    }
}
