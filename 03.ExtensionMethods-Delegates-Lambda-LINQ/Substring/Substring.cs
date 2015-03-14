/*
 * Problem 1: Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
                new StringBuilder and has the same functionality as Substring in the class String.
*/
namespace Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Substring
    {
        public static StringBuilder SubstringBuilder(this StringBuilder sb, int position)
        {
            string result = sb.ToString().Substring(position, sb.Length - position);
            StringBuilder resultSb = new StringBuilder(result);
            return resultSb;
        }

        public static StringBuilder SubstringBuilder(this StringBuilder sb, int position, int length)
        {
            string result = sb.ToString().Substring(position, length);
            StringBuilder resultSb = new StringBuilder(result);
            return resultSb;
        }

        public class Test
        {
            static void Main()
            {
                string test = "WTF am I doing here";
                var sb = new StringBuilder();
                sb.Append(test);

                Console.WriteLine(sb.SubstringBuilder(0,3));
                Console.WriteLine(sb.SubstringBuilder(4));
            }
        }
    }
}
