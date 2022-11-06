using System;
using System.Collections.Generic;
using System.Text;

namespace _05GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            (Items[firstIndex], Items[secondIndex]) = (Items[secondIndex], Items[firstIndex]);
        }

        public int Count(T elementToComparable)
        {
            int count = 0;

            foreach (var item in Items)
            {
                if (item.CompareTo(elementToComparable) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
