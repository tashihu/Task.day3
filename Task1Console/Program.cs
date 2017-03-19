using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ar = new int[4][];
            ar[0] = new int[] { 1, 2, 5 };
            ar[1] = new int[] { 9 };
            ar[2] = new int[] { 4, 4, 4 };
            ar[3] = new int[] { 3, 3 };
            Task1Logic.ArrayTool tool = new Task1Logic.ArrayTool();

            
            ArrayPrint(ar);

            Console.WriteLine("sort by summ");
            tool.SortBySum(ar,direction.Ascending);
            ArrayPrint(ar);

            Console.WriteLine("sort by max");            
            tool.SortByMax(ar, direction.Ascending);
            ArrayPrint(ar);

            Console.WriteLine("sort by min");            
            tool.SortByMin(ar, direction.Ascending);
            ArrayPrint(ar);
            Console.ReadKey();
        }
        public static void ArrayPrint(int[][] array)
        {
            foreach(var line in array)
            {
                foreach(var item in line)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        
    }

}
