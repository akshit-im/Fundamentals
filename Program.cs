using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Basic
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "Hello World";

			Console.WriteLine(s);

			Console.WriteLine(s+" You Are on Beautiful Planet");

			Console.WriteLine($"Welcome {s}");  //String Interpolation

			Console.WriteLine($"Hello world has {s.Length} letters"); // Length is a function

			string str = "	Hello Akshit	";
			string st = str;
			
			Console.WriteLine(str);

			Console.WriteLine(st.TrimStart()); // Trim Method
			Console.WriteLine(st.TrimEnd());
			Console.WriteLine(st.Trim());

			str = str.Replace("Akshit","World"); // Replace Method
			Console.WriteLine(str.Trim());

			Console.WriteLine(s.ToUpper()); // Changes All letters to upper Case
			Console.WriteLine(s.ToLower()); // Changes All letters to lower Case
			Console.WriteLine(s);           // Original State of the Variable is not changed

			string q = "Human beings are born on earth on to die here"; // Contains Function to check wheather a string is present in
			Console.WriteLine(q.Contains("born")); // can transfer the boolean value to a varibale also
			Console.WriteLine(q.Contains("abc"));	// var x=1=q.contains("born");

		}
	}
}
