using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class ChangeCase
    {
        //public static string ChangeUpperCase(this string input)
        //{
        //    string ans = char.ToUpper(input[0]) + input.Substring(1);
        //    return ans;
        //}

        //public static string ChangeLowerCase(this string input)
        //{
        //    string ans = char.ToLower(input[0]) + input.Substring(1);
        //    return ans;
        //}

        public static string ChangeCaseOfFirstCharacter(this string givenString)
        {
            if (Char.IsUpper(givenString[0]))  //checks if first character is upper case or not
            {
                string stringInLowerCase=char.ToLower(givenString[0])+givenString.Substring(1);
                return stringInLowerCase;
            }
            else
            {
                string stringInUpperCase = char.ToUpper(givenString[0]) + givenString.Substring(1);
                return stringInUpperCase;
            }
           
        }
    }
}
