using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
	public class Driver
	{
		public static void Main(string[] args)
		{
			string InputString = "banana";

			Console.WriteLine("Reversed string:"+ InputString.Reverse());
			Console.WriteLine("changes case:" + InputString.ChangeCaseOfFirstCharacter());

			Console.WriteLine("Reversed string Using Recursion:" + InputString.ReverseStringUsingRecursion());
		}
	}
}
