using System;
using System.Collections.Generic;
using System.Text;

namespace CodilitySamples
{
    public class PrimeAndCompositeNumbers
    {

        /// <summary>
        /// {1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2}
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int Flags(int[] A)
        {
            int flags = 0;
            int nextpeak = A.Length;
            int[] peaks = new int[A.Length];

            peaks[A.Length-1] = nextpeak;


            for (int i = A.Length - 2; i > 0; i--) 
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                {
                    nextpeak = i;
                }              
                peaks[i] = nextpeak;
            }
            peaks[0] = nextpeak;



            return flags;
        }

        public int FlagssolutionByJames(int[] A)
        {
            int nextPeak = A.Length;
            int[] peaks = new int[A.Length];
            peaks[A.Length - 1] = nextPeak;
            for (int i = A.Length - 2; i > 0; i--)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                    nextPeak = i;
                peaks[i] = nextPeak;
            }
            peaks[0] = nextPeak;

            int current_guess = 0;
            int next_guess = 0;
            while (canPlaceFlags(peaks, next_guess))
            {
                current_guess = next_guess;
                next_guess += 1;
            }

            return current_guess;
        }
        private Boolean canPlaceFlags(int[] peaks, int flagsToPlace)
        {
            int currentPosition = 1 - flagsToPlace;
            for (int i = 0; i < flagsToPlace; i++)
            {
                if (currentPosition + flagsToPlace > peaks.Length - 1)
                    return false;
                currentPosition = peaks[currentPosition + flagsToPlace];
            }
            return currentPosition < peaks.Length;
        }
    }
}
