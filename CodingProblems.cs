using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodilitySamples
{
    public class CodingProblems
    {
        /// <summary>
        /// ['a', 'b', 'c', 'x'] , ['z', 'y', 'i']
        /// ['a', 'b', 'c', 'x'] , ['z', 'y', 'x']
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public bool containsCommonItem(char[] array1, char[] array2)
        {

            for (int i = 0; i < array1.Length; i++)
            {
                if (array2.Contains(array1[i])) { return true; }
            }

            return false;
        }


        
    }
}
