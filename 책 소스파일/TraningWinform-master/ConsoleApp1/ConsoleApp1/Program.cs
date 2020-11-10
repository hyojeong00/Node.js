using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class SimpleGeneric<T>
    {
        private T[] values;
        private int index;

        public SimpleGeneric(int len)
        {
            values = new T[len];
            index = 0;
        }
        public void Add(params T[] args)
        {
            foreach (T item in args)
            { values[index++] = item; }
        }
        public void print()
        {
            foreach (T item in values)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGeneric<int> gIntegers = new SimpleGeneric<int>(10);
            SimpleGeneric<double> gDoubles = new SimpleGeneric<double>(10);

            gIntegers.Add(1, 2);
            gIntegers.Add(1, 2, 3, 4, 5, 6, 7);
            gIntegers.Add(10);
            gDoubles.Add(10.0, 12.4, 37.5);
            gIntegers.print();
            gDoubles.print();
        }
    }
}
