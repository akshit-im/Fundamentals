using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Math
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			int b = 20;
			
			int c = a + b;
			Console.WriteLine(c);

			int x = a * b;
			Console.WriteLine(x);

			int y = a / b;
			Console.WriteLine(y);

			int z = 30;
			int w = a + b * z;		// w = (a+b)*z
			Console.WriteLine(w);

			int max = int.MaxValue; // property
			int min = int.MinValue;
			Console.WriteLine($"Integer mas value is {max} and min value is {min}");

			int m = max + 3;
			Console.WriteLine(m);

			double p = 7;
			double q = 10;
			double r = 15;
			double s = (p + q) / r;
			Console.WriteLine(s);

			double dmax = double.MaxValue;
			double dmin = double.MinValue;
			Console.WriteLine("Double max value is"+dmax+" and min value is "+dmin);

			decimal Dlmax = decimal.MaxValue;
			decimal Dlmin = decimal.MinValue;
			Console.WriteLine("Decimal max value is "+dmax+" and min value is "+dmin);
		}
	}
}
