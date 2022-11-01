using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace _07_Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            var parking = new HashSet<string>();

            while (command != "END")
            {
                string[] tokens = Regex.Split(command, ", ");

                string direction = tokens[0];
                string carNumber = tokens[1];

                switch (direction)
                {
                    case "IN":
                        parking.Add(carNumber);
                        break;
                    case "OUT":
                        parking.Remove(carNumber);
                        break;
                }

                command = Console.ReadLine();
            }

            if (parking.Count > 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
