using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public static class Hex
    {
        /// <summary>
        /// convert int digit to hex digit
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static char HexDigit(int num)
        {
            return num < 10 ? (char)(num + 48) : (char)(num + 55);
        }
        /// <summary>
        /// convert hex digit to int digit
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int ConvertHexDigit(char val)
        {
            if ((int)val <= 57 && (int)val >= 48)
                return (int)val - 48;
            if ((int)val >= 97 && (int)val <= 102)
                return (int)val - 97 + 10;
            if ((int)val >= 65 && (int)val <= 70)
                return (int)val - 65 + 10;
            throw new ArgumentException("Argument out of range");
        }
        /// <summary>
        /// convert int number to hex number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string HexNumber(this int num)
        {
            string hex = "";
            do
            {
                hex = HexDigit(num % 16) + hex;
                num = (int)(num / 16);
            }
            while (num != 0);
            return hex;
        }
        /// <summary>
        /// convert hex number to int number
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int ConvertHexNumber(this string val)
        {
            if (val == null) throw new ArgumentNullException("Null argument");
            int num = 0;
            for (int i = 0; i < val.Length; i++)
            {
                num = num * 16 + ConvertHexDigit(val[i]);
            }
            return num;
        }
    }
}