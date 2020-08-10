using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class Greedyalgorithm
    {
        /// <summary>
        /// 4, [1, 2, 3, 4, 1, 1, 3]
        /// </summary>
        /// <param name="K"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public int TieRopes(int K, int[] A)
        {
            int count = 0;
            int currentLength = 0;
            for (int i = 0; i < A.Length; i++)
            {
                currentLength += A[i];
                if (currentLength >= K)
                {
                    count++;
                    currentLength = 0;
                }
            }
            return count;
        }

        /// <summary>
        /// [1, 3, 7, 9, 9], [5, 6, 8, 9, 10]
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int MaxNonoverlappingSegments(int[] A, int[] B)
        {
            int count = 0;
            int endSegment = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > endSegment)
                {
                    count++;
                    endSegment = B[i];
                }
            }
            return count;

        }
    }
}
