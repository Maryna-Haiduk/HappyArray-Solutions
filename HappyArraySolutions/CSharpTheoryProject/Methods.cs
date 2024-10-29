using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class Methods
    {
        public static bool IsStringPalindrome(string str)
        {
            bool result = true;

            if(str == null || str.Length == 0) 
            {
                result = false;
            }

            for (int i = 0, j = str.Length - 1; i < str.Length / 2 & j >= str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    result = false; 
                    break;
                }
            }
            return result;
        }
    }
}
