using System;

namespace _01BoxOfString
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

            Console.WriteLine(box.ToString());
        }
    }
}
