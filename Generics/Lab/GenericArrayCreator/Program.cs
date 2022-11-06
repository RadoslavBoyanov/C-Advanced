using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main()
        {
            string[] club = ArrayCreator.Create(10, "Grad Belogradchik");

            int[] integers = ArrayCreator.Create(10, 1);

            Console.WriteLine(string.Join(" ", integers));
            Console.WriteLine(string.Join(" ", club));

        }
    }
}
