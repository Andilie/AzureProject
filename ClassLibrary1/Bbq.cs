using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public static class Bbq
    {
        public static string ConvertString(char[] input)
        {
            string str = null;
            foreach (var item in input)
            {
                str = str + item;
            }
            return str;
         }
    }
}
