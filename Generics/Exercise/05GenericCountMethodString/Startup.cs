using System;

namespace _05GenericCountMethodString
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

            string elementToCompare = Console.ReadLine();

            var result = box.Count(elementToCompare);

            Console.WriteLine(result);
        }
    }
}
