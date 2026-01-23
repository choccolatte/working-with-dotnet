using System;
using System.Linq;

namespace MyAp
{
	class Program{
		static void Main(string[] args)
		{
			int[] num = {1, 2, 3, 4, 5, 6, 7, 8, 9};

			Console.WriteLine(num.Max()); // gives max value
			Console.WriteLine(num.Min()); // gives min value
			Console.WriteLine(num.Sum()); // gives sum total
		}
	}
	
}
