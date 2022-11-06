using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _07Tuple
{
    public class Tuple<T1, T2>
    {
        public T1 items1;
        public T2 items2;

        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
