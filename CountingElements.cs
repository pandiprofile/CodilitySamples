using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodilitySamples
{
    public class CountingElements
    {
        /// <summary>
        /// Input  int[] A = { 0, 1, 3, 4, 6, 7 };
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int MissingIntegerMine(int[] A)
        {

            int result = 1;
            Array.Sort(A);
            for (int i = 0; i < A.Length - 1; i++)
            {

                if (A[i + 1] - A[i] > 1)
                {
                    result = A[i] + 1;
                    break;
                }
            }
            return result;
        }

        public int MissingIntegerMartinkysel(int[] A)
        {
            HashSet<int> h = new HashSet<int>();

            foreach (int val in A)
                if (val > 0)
                    h.Add(val);

            int minpostive = 1;

            foreach (int val in h)
            {
                if (val == minpostive)
                    do
                    {
                        minpostive++;
                    }
                    while (h.Contains(minpostive));
            }

            return minpostive;
        }


        public int[] MaxCounters(int N, int[] A) {
            int[] counters = new int[N];
            Array.Fill(counters, 0);

            int start_line = 0;
            int current_max = 0;

            for (int i = 0; i < A.Length; i++) 
            {
                int x = A[i] - 1;
                if (x >= N) start_line = current_max;
                else if (counters[x] < start_line) counters[x] = start_line + 1;
                else counters[x] += 1;
                if (i <= N && counters[x] > current_max) current_max = counters[x];

            }
            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = Math.Max(counters[i], start_line);
            }

            return counters;        
        }

        /// <summary>
        /// 5,{ 3,4,4,6,1,4,4 };
        /// </summary>
        /// <param name="N"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] MaxCounterssolution(int N, int[] A)
        {
            int[] counter = new int[N];
            int baseMinimum = 0;
            int possibleMinimum = 0;
            int index = 0;

            for (int i = 0; i < A.Length; i++)
            {
                index = A[i] - 1;

                if (index == N)
                {
                    baseMinimum = possibleMinimum;
                }
                else
                {
                    counter[index] = Math.Max(counter[index], baseMinimum);
                    counter[index] += 1;

                    if (possibleMinimum < counter[index])
                    {
                        possibleMinimum = counter[index];
                    }
                }
            }

            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = Math.Max(counter[i], baseMinimum);
            }

            return counter;
        }
    }
}
