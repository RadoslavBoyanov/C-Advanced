using System;

namespace _06GenericCountMethodDouble
{
    public class Startup
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                double item = double.Parse(Console.ReadLine());

                box.Items.Add(item);
            }

            double elementToCompare = double.Parse(Console.ReadLine());

            var result = box.Count(elementToCompare);

            Console.WriteLine(result);
        }
    }
}
