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
			string inputString = "banana";

			Console.WriteLine("Reversed string:"+ inputString.Reverse());
			Console.WriteLine("changes case:" + inputString.ChangeCaseOfFirstCharacter());


		}
	}
}
