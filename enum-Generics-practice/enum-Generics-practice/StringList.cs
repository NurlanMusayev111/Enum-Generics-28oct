using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace enum_Generics_practice
{
    internal static class StringList
    {
        public static bool CheckEmail(this string email)
        {
            int count = 0;
            foreach (var item in email) 
            {
                if(item == '0')
                {
                    count++;
                }

                if(count == 2)
                {
                    break;
                }
            }

            if(count == 1)
            {
                return true;
            }

            return false;
        }


        public static bool CheckTrimEmail(this string str,string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }


        public static int GetMultipyArray(this int[] arr)
        {
            int multipy = 1;

            foreach(var num in arr)
            {
                multipy *= num;
            }

            return multipy;
        }

    }
}
