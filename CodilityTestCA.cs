using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class CodilityTestCA
    {
        public String solution(String s)
        {
            if (String.IsNullOrEmpty(s)) return "other";
            char c = s[0];
            if (Char.IsUpper(c))
            {
                return "upper";
            }
            else if (Char.IsLower(c))
            {
                return "lower";
            }
            else if (Char.IsDigit(c))
            {
                return "digit";
            }
            else
            {
                return "other";
            }
        }

        /// <summary>
        /// 123456
        /// 162534
        /// 130
        /// 103
        /// 
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Task2(int A)
        {
            StringBuilder str = new StringBuilder();
            Char[] inputArrary = A.ToString().ToCharArray();
            Char[] resultArrary = new Char[inputArrary.Length];

            int resultIndex = 0;
            int count =  (int) Math.Ceiling( Convert.ToDecimal( inputArrary.Length / (decimal)2));

            for (int i = 0; i < count; i++) 
            {
                resultArrary [resultIndex] = inputArrary[i];
                if (resultIndex + 1 >= inputArrary.Length) { break; }
                resultArrary[resultIndex+1] = inputArrary[inputArrary.Length -1 - i];
                resultIndex += 2;
            }

            foreach (Char c in resultArrary)
            {
                str.Append(c);
            }
            return Convert.ToInt32( str.ToString());
        }

    }
}
