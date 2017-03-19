using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool
{
    public static class MathTool
    {
        #region public method

        /// <summary>
        /// Recurtion search of maximum element in array
        /// </summary>
        /// <param name="array">any array</param>
        /// <returns>maximum element</returns>
        public static T Maximum<T>(this T[] array) where T : IComparable<T>
        {
            if (array == null) throw new ArgumentNullException("array is null");
            if (array.Length == 0) return default(T);

            return array[Search(array, 0, 0)];
        }
        public static T Minimum<T>(this T[] array) where T : IComparable<T>
        {
            if (array == null) throw new ArgumentNullException("array is null");
            if (array.Length == 0) return default(T);

            return array[Search(array, 0, 0, -1)];
        }
        #endregion

        #region private method
        /// <summary>
        /// Reqursion sersh index of maximum element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="maxIndex"></param>
        /// <param name="currentIndex"></param>
        /// <returns>index</returns>
        private static int Search<T>(T[] array, int maxIndex, int currentIndex, int asc = 1) where T : IComparable<T>
        {
            if (currentIndex < array.Length)
            {
                //move maximum index to next step 
                if (array[maxIndex].CompareTo(array[currentIndex])*asc > 0)
                {
                    maxIndex = Search(array, maxIndex, currentIndex + 1,asc);
                }
                else
                {
                    maxIndex = Search(array, currentIndex, currentIndex + 1,asc);
                }
            }
            return maxIndex;
        }
        #endregion
    }

}
