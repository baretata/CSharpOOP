/*
 Problem 19: Rewrite the previous using extension methods.
 */

namespace _18.StudentsByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionMethodGrouping
    {
        public static IEnumerable<Student> ExtensionGrouping(this List<Student> groups)
        {
            var grouped = groups.OrderBy(x => x.Group);

            return grouped;
        }

    }
}
