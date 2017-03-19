using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathTool;
/*
 Задание 1. 
Дан непрямоугольный целочисленный массив (jagged array). Реализовать метод "пузырьковой" сортировки (метод класса Array не использовать!), таким образом, чтобы была возможность упорядочить строки матрицы
•	в порядке возрастания(убывания) сумм элементов строк матрицы;
•	в порядке возрастания(убывания) максимальных элементов строк матрицы;
•	в порядке возрастания(убывания) минимальных элементов строк матрицы.
 */
namespace Task1Logic
{
    #region fields
    public enum direction { Ascending = 1, descending = 0 }

    delegate int action(int[] array);
    #endregion

    #region public method
    public class ArrayTool
    {
        private int[] _array;
        /// <summary>
        /// sort arraylines by sum of line`s elements
        /// </summary>
        /// <param name="array"></param>
        /// <param name="direction"></param>
        public void SortBySum(int[][] array, direction direction = direction.Ascending)
        {
            if (null == array) throw new ArgumentNullException();
            _array = new int[array.Length];
            Sort(array, direction, (int[] arr) =>
            {
                int sum = 0;
                foreach (int item in arr) { sum += item; }
                return sum;
            }
                                     );
        }
        /// <summary>
        /// sort arraylines by maximal element in line
        /// </summary>
        /// <param name="array"></param>
        /// <param name="direction"></param>
        public void SortByMax(int[][] array, direction direction = direction.Ascending)
        {
            if (null == array) throw new ArgumentNullException();
            _array = new int[array.Length];
            Sort(array, direction, (int[] arr) => { return arr.Maximum<int>(); });
        }
        /// <summary>
        /// sort arraylines by minimal element in line
        /// </summary>
        /// <param name="array"></param>
        /// <param name="direction"></param>
        public void SortByMin(int[][] array, direction direction = direction.Ascending)
        {
            if (null == array) throw new ArgumentNullException();
            _array = new int[array.Length];
            Sort(array, direction, (int[] arr) => { return arr.Minimum<int>(); });
        }
    #endregion

        #region private method
        /// <summary>
        /// sort array`s lines
        /// </summary>
        /// <param name="array"></param>
        /// <param name="asc"></param>
        private void sort(int[][] array, bool asc)
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                for (int j = 0; j < _array.Length - 1 - i; j++)
                {
                    if ((_array[j] < _array[j + 1]) ^ asc)
                    {
                        swap(_array, j);
                        swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }
        /// <summary>
        /// preparation for sort array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="direction"></param>
        /// <param name="act"></param>
        private void Sort(int[][] array, direction direction, action act)
        {
            bool asc = direction == direction.Ascending;
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = act(array[i]);
            }
            sort(array, asc);
        }
        /// <summary>
        /// swap array lines
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void swap(ref int[] a, ref int[] b)
        {
            int[] tmp = a;
            a = b;
            b = tmp;
        }
        /// <summary>
        /// swap elements in array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        private void swap(int[] array, int index)
        {
            int tmp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = tmp;
        }
        #endregion
    }
}
