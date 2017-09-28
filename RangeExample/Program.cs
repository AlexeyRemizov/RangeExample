using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            foreach (var item in container)
            {
                Console.WriteLine("Show me");
            }
            Console.ReadKey();
        }
    }

    public class Container
    {
        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }
    }

    public class Enumerator
    {
        public bool MoveNext()
        {
            return false;
        }

        public object Current
        {
            get{ return null; }
        }
    }
}
