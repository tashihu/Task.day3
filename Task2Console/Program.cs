using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 16;
            try
            {
                Console.WriteLine("16 D = {0} hex, 10 hex = {1} D, 1324 D = {2} hex, 4D2 hex = {3} D",
                                num.HexNumber(), "10".ConvertHexNumber().ToString(),
                                (1234).HexNumber(), "4d2".ConvertHexNumber().ToString());
            }
            catch (Exception e) { Console.WriteLine("convertion error"); }

            Console.ReadKey();
        }
    }
}
