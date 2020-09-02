using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibo = new List<int> { 1, 1 };
            while (fibo.Count<20)
            {
                var x = fibo[fibo.Count - 1];
                var y = fibo[fibo.Count - 2];

                fibo.Add(x + y);

            }
            foreach (var item in fibo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
