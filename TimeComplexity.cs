using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodilitySamples
{
    public class TimeComplexity
    {
        /// <summary>
        /// int[] arr = { 3,1,2,4,3};
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Equilibrium(int[] A)
        {
            int leftSum = A[0];
            int rightSum = A.Sum() -leftSum;
            int diff = Math.Abs(leftSum - rightSum);
            for (int i = 1; i < A.Length - 1; i++)
            {
                leftSum += A[i];
                rightSum -= A[i];

                int currentDiff = Math.Abs(leftSum - rightSum);
                if (diff > currentDiff) diff = currentDiff;
            }

            return diff;
        }
    }
}


//Stack<int> stack = new Stack<int>();
//int survivors = 0;
//            for (int i = 0; i<A.Length; i++)
//            {
//                int weight = A[i];
//                if (B[i] == 1)
//                {
//                    stack.Push(weight);
//                }
//                else
//                {
//                    int weightDown = (stack.Count == 0) ? -1 : stack.Pop();
//                    while (weightDown != -1 && weightDown<weight)
//                        weightDown = (stack.Count == 0) ? -1 : stack.Pop();
//                    if (weightDown == -1)
//                        survivors += 1;
//                    else
//                        stack.Push(weightDown);
//                }
//            }
//            return survivors + stack.Count;