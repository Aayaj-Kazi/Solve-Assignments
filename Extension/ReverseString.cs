using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
	

	public static class ReverseString
	{
		public static string Reverse(this string input)
		{
			char[] array = input.ToCharArray();
			Array.Reverse(array);
			
			string ans = new String(array);
			return ans;
		}

		
	}
}
