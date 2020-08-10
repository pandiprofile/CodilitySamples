using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilitySamples
{
    public class Leader
    {
        /// <summary>
        /// {3,4,3,2,3,-1,3,3}
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Dominator(int[] A)
        {
            if (A.Length == 0) return -1;

            int n = Math.Abs(A.Length / 2);
            Dictionary<int, int> hashLeader = new Dictionary<int, int>();
            foreach (int i in A)
            {
                if (hashLeader.ContainsKey(i)) { hashLeader[i] = (int)hashLeader[i] + 1; }
                else { hashLeader.Add(i, 1); }
            }

            int maxValue = hashLeader.Values.Max();

            int k = hashLeader.FirstOrDefault(x => x.Value == maxValue).Key;
            int leaderIndex = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == k)
                {
                    leaderIndex = i;
                }
            }
            return (maxValue > n) ? leaderIndex : -1;
        }

        /// <summary>
        /// {3,4,3,2,3,-1,3,3}
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int DominatorByJames(int[] A)
        {
            int candidate = 0;
            int consecutiveSize = 0;

            foreach (int item in A)
            {
                if (consecutiveSize == 0)
                {
                    candidate = item;
                    consecutiveSize += 1;
                }
                else if (candidate == item)
                {
                    consecutiveSize += 1;
                }
                else
                {
                    consecutiveSize -= 1;
                }
            }
            int returnIndex = -1;
            int occurance = 0;

            if (consecutiveSize > 1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == candidate)
                    {
                        returnIndex = i;
                        occurance++;
                    }
                }
            }

            return (occurance > (A.Length / 2)) ? returnIndex : -1;

        }
    }
}
