using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class PrefixSums
    {
        /// <summary>
        /// {0, 1, 0, 1, 1}
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int PassingCars(int[] A)
        {
            if (A.Length >= 1000000000) return -1;
            int[] suffixArray = new int[A.Length + 1];
            for (int i = A.Length - 1; i >= 0; i--)
            {
                suffixArray[i] = A[i] + suffixArray[i + 1];
            }
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] == 0)
                {
                    count += suffixArray[i];
                    if (count >= 1000000000) return -1;
                }
            }
            return count;
        }

        /// <summary>
        ///  [6, 11, 2]
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int CountDiv(int A, int B, int K)
        {
            int leftEnd = (int) Math.Ceiling(Convert.ToDecimal(A) / Convert.ToDecimal(K));
            int rightEnd = (int)Math.Floor(Convert.ToDecimal(B) / Convert.ToDecimal(K));
            int result =  rightEnd - leftEnd  + 1;
            return result;
        }

    }
}
