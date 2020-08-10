using System;

namespace CodilitySamples
{
    class Program
    {
        static void Main(string[] args)
        {
            CodingProblems Obj = new CodingProblems();
            Console.Write(Obj.containsCommonItem(new char[] { 'a', 'b', 'c', 'x' }, new char[] { 'z', 'y', 'x' }));

            //CaterpillarMethod Obj = new CaterpillarMethod();
            //Obj.CountDistinctSlices(3, new int[] { 2,1});
            //Obj.CountDistinctSlices(6, new int[] { 3, 4, 5, 5, 2 });


            Console.Read();
        }

        public void fn()
        {

            TestJPM obj = new TestJPM();
            Console.Write(obj.Solution("townoe"));

            //PrimeAndCompositeNumbers obj = new PrimeAndCompositeNumbers();
            //obj.FlagssolutionByJames(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 });

            //PrefixSums obj = new PrefixSums();
            ////Console.Write(obj.CountDiv(6, 11, 2));
            //Console.Write(obj.CountDiv(0,1, 11));
            //obj.PassingCars(new int[] { 0, 1, 0, 1, 1 });

            //MaximumSlice obj = new MaximumSlice();
            //Console.Write(obj.MaxProfit(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }));

            //Leader obj = new Leader();
            //Console.Write(obj.Dominator(new int[] { }));

            //StacksAndQueues obj = new StacksAndQueues();
            //Console.Write(obj.BracketsByJames("{[()()]}"));
            //Console.Write(obj.Fish(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }));

            //int[] arr = { 3, 4, 4, 6, 1, 4, 4 };
            //CountingElements obj = new CountingElements();
            //Console.Write(obj.MaxCounters(5,arr));

            //int[] A = { 3, 8, 9, 7, 6 };
            //FutureTraining obj = new FutureTraining();
            //Console.Write(obj.CyclicRotation(A, 3));

            //int[] arr = { 0, 1, 3, 4, 6, 7 };
            //CountingElements obj = new CountingElements();
            //Console.Write(obj.MissingIntegerMartinkysel(arr));

            //int[] arr = { 3, 1, 2, 4, 3 };
            //TimeComplexity obj = new TimeComplexity();
            //Console.Write(obj.Equilibrium(arr));
        }

    }
}
