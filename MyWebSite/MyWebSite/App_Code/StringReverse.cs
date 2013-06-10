using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite.App_Code
{
    public class StringReverse
    {
        public StringReverse() { }

        public string Process(string input)
        {
            char[] Reverse = input.ToCharArray();
            Array.Reverse(Reverse);
            return String.Join("", Reverse);
        }
    }
}