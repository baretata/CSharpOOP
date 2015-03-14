namespace _06.DivisibleBySevenAndThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Division()
        {
        }

        static void Main()
        {
            int[] arr = new[] { 5, 3, 7, 15, 35, 45, 70, 140, 340, 459, 700, 1010, 66, 21, 63 };

            Console.WriteLine("Numbers divisible by 3 and 7 at the same time. \r\nLambda expression results: ");
            var lambdaResult = arr.Where(n => n % 3 == 0 && n % 7 == 0);

            foreach (int num in lambdaResult)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Linq query results: ");

            var linqQueryResult =
                from n in arr
                where n % 3 == 0 && n % 7 == 0
                select n;

            foreach (int num in linqQueryResult)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
