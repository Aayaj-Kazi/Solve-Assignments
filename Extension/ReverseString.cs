using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
	

	public static class ReverseString
	{
		public static string Reverse(this string inputString)
		{
			//char[] array = inputString.ToCharArray();
			//Array.Reverse(array);


			// without Reverse 
			string newString = "";
			for (int i= (inputString.Length-1); i>=0; i--)
            {
				newString = newString + inputString[i];
            }

			// and recursion too
			
			
			return newString;
		}

		static string newStringByRecursion = "";
		public static string ReverseStringUsingRecursion(this string inputString)
		{
			if ((inputString == null) || (inputString.Length < 1))
			{ return newStringByRecursion; }

			else { 
			newStringByRecursion = newStringByRecursion + inputString[inputString.Length - 1];

			return ReverseStringUsingRecursion(inputString.Substring(0, inputString.Length - 1));
			}
		}
		
	}
}
