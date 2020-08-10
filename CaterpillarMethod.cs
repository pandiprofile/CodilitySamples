using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class CaterpillarMethod
    {
        /// <summary>
        /// 6, new int[]{3, 4, 5, 5, 2}
        /// 9, new int[]{2, 4, 1, 7, 4, 9, 7, 3, 5, 5, 8, 7, 1}
        /// </summary>
        /// <param name="M"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public int CountDistinctSlices(int M, int[] A)
        {
            int totalSlices = 0;
            bool[] inCurrentSlices = new bool[M + 1];

            Array.Fill(inCurrentSlices, false);
            int head = 0;

            for (int tail = 0; tail < A.Length; tail++)
            {
                while (head < A.Length && !inCurrentSlices[A[head]])
                {
                    inCurrentSlices[A[head]] = true;
                    totalSlices += (head - tail) + 1;
                    head += 1;
                    if (totalSlices > 1000000000) { totalSlices = 1000000000; }
                }
                inCurrentSlices[A[tail]] = false;
            }

            return totalSlices;

        }
    }
}
