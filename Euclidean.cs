using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class Euclidean
    {
        /// <summary>
        /// 10,4
        /// 9,6
        /// </summary>
        /// <param name="N"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public int ChocolatesByNumbers(int N, int M)
        {
            if (N == 0) return N;
            int result = findGCD(N, M);
            return N / result;
        }

        private int findGCD(int a, int b)
        {
            if (b == 0)
            { return a; }
            else
            { return findGCD(b, a % b); }

        }
    }
}
