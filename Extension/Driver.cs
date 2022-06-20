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
			string str = "Banan";

			Console.WriteLine("Reversed string:"+str.Reverse());
			Console.WriteLine("changes case:" + str.ChangeUpperCase());
			Console.WriteLine("changes case:" + str.ChangeLowerCase());
		}
	}
}
