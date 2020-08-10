using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
   public class MaximumSlice
    {
        /// <summary>
        /// {23171, 21011, 21123, 21366, 21013, 21367}
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int MaxProfit(int[] A) {

            int globalMax = 0;
            int localMax = 0;

            for (int i = 1; i < A.Length; i++) {
                int d = A[i] - A[i - 1];
                localMax = Math.Max(d, d + localMax);
                globalMax = Math.Max(globalMax,localMax);
            }
            return globalMax;
        }
    }
}
