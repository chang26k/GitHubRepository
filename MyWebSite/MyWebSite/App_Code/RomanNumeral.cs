using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebSite.App_Code
{
    class RomanNumeral
    {

        public string ProcessNumber(int input)
        {
            return SubtrackUntilZero(input);

        }

        private string SubtrackUntilZero(int input)
        {
            StringBuilder sb = new StringBuilder();
            while (input > 0)
            {
                if (input - 1000 >= 0)
                {
                    input = input - 1000;
                    sb.Append("M");
                }
                else if (input - 900 >= 0)
                {
                    input = input - 900;
                    sb.Append("CM");
                }
                else if (input - 500 >= 0)
                {
                    input = input - 500;
                    sb.Append("D");
                }
                else if (input - 400 >= 0)
                {
                    input = input - 400;
                    sb.Append("CD");
                }
                else if (input - 100 >= 0)
                {
                    input = input - 100;
                    sb.Append("C"); 
                }
                else if (input - 90 >= 0)
                {
                    input = input - 90;
                    sb.Append("XC");
                }
                else if (input - 50 >= 0)
                {
                    input = input - 50;
                    sb.Append("L"); 
                }
                else if (input - 40 >= 0)
                {
                    input = input - 40;
                    sb.Append("XL");
                }
                else if (input - 10 >= 0)
                {
                    input = input - 10;
                    sb.Append("X"); 
                }
                else if (input - 9 >= 0)
                {
                    input = input - 9;
                    sb.Append("IX");
                }
                else if (input - 5 >= 0)
                {
                    input = input - 5;
                    sb.Append("V"); 
                }
                else if (input - 4 >= 0)
                {
                    input = input - 4;
                    sb.Append("IV");
                }
                else if (input - 1 >= 0)
                {
                    input = input - 1;
                    sb.Append("I");
                }
                else
                {
                    break;
                }
            }
            return sb.ToString();
        }
    }
}
