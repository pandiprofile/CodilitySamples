using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
   public class StacksAndQueues
    {
        /// <summary>
        /// {4, 8, 2, 6, 7},{0, 1, 1, 0, 0}
        /// {4, 3, 2, 1, 5},{0, 1, 0, 0, 0}
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int Fish(int[] A, int[] B)
        {
            Stack<int> fishStack = new Stack<int>();
            int Surviour = 0;
            int weight = 0;
            for (int i = 0; i < A.Length; i++) {
                weight = A[i];
                if (B[i] == 1)
                {
                    fishStack.Push(A[i]);
                }
                else {
                    int weightDown = (fishStack.Count == 0) ? -1 : fishStack.Pop();

                    while (weightDown != -1 && weightDown < weight) {
                        weightDown = (fishStack.Count == 0) ? -1 : fishStack.Pop();
                    }
                    if (weightDown == -1)
                    {
                        Surviour += 1;
                    }
                    else {
                        fishStack.Push(weightDown);
                    }
                }
            }
            return Surviour + fishStack.Count;
        }


        /// <summary>
        /// {[()()]}
        /// ([)()]
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public int BracketsMine(string S) {

            Char[] str = S.ToCharArray();
            Stack<Char> bracketStack = new Stack<char>();
            int result = 0;

            for (int i = 0; i < str.Length; i++) {

                if (str[i] == '{' || str[i] == '[' || str[i] == '(')
                {
                    bracketStack.Push(str[i]);
                }
                else if (str[i] == '}') {
                    Char value = (bracketStack.Count == 0) ? '0' : bracketStack.Pop();
                    if (value != '{')
                    {
                        return 1;
                    }
                }
                else if (str[i] == ']')
                {
                    Char value = (bracketStack.Count == 0) ? '0' : bracketStack.Pop();
                    if (value != '[')
                    {
                        return 1;
                    }
                }
                else if (str[i] == ')')
                {
                    Char value = (bracketStack.Count == 0) ? '0' : bracketStack.Pop();
                    if (value != '(')
                    {
                        return 1;
                    }
                }
            }

            return result;
        }

        public int BracketsByJames(string S)
        {

            Stack<Char> stack = new Stack<Char>();
            foreach (char c in S.ToCharArray())
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else if (c == '}')
                {
                    if (stack.Count==0 || stack.Pop() != '{') return 0;
                }
                else if (c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[') return 0;
                }
                else if (c == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(') return 0;
                }
            }
            return (stack.Count == 0) ? 1 : 0;
        }


    }
}
