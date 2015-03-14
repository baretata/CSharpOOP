/*
 * Problem 17: Write a program to return the string with maximum length from an array of strings.Use LINQ.
 */

namespace _17.LongestString
{
    using System;
    using System.Linq;

    class LongestStringProgram
    {
        static string FindLongestString(string[] arr)
        {
            var longest = arr.OrderByDescending(x => x.Length).First();

            return longest;
        }

        static void Main()
        {
            string[] stringArray = new string[]
            {
                "Not longest string",
                "Probably the longest string",
                "Lorem ipsum",
                "This is the longest string in the array"
            };

            var longest = FindLongestString(stringArray);

            Console.WriteLine(longest);
        }
    }
}
