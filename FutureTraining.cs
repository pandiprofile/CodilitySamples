using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class FutureTraining
    {
        /// <summary>
        /// ([3, 8, 9, 7, 6], 3)
        /// ([0, 0, 0], 1)
        /// ([1, 2, 3, 4], 4)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int[] CyclicRotation(int[] A, int K)
        {
            int[] result = new int[A.Length];
            int sizeArray = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                result[(i + K) % sizeArray] = A[i];
            }

            return result;
        }
    }
}
