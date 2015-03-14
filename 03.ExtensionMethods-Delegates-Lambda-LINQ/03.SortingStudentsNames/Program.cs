/*
 * Problem 3: Write a method that from a given array of students finds all students whose first name is before
        its last name alphabetically.Use LINQ query operators.
 * Problem 4: Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 * Problem 5: Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name
        and last name in descending order.Rewrite the same with LINQ.
 */
namespace _03.SortingStudentsNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        //problem 3
        public static void SortByFirstName(Student[] studentsGroup)
        {
            //var sorted = studentGroup.Where(st => st.FirstName.CompareTo(st.LastName) < 0);       Using Lambda expression
            var sorted =
                from st in studentsGroup
                where st.FirstName.CompareTo(st.LastName) < 0
                orderby st.FirstName
                select st;

            Console.WriteLine("Students sorted by first name before last name alpabetically:");

            foreach (Student student in sorted)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        //problem 4
        public static void SortByAge(Student[] studentsGroup)
        {

            //var sorted = studentGroup.Where(st => st.Age >= 18 && st.Age <= 24);     Using Lambda expression
            var sorted =
                from st in studentsGroup
                where st.Age >= 18 && st.Age <= 24
                orderby st.Age
                select st;

            Console.WriteLine("Students ordered by age between 18 and 24:");

            foreach (Student student in sorted)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        //problem 5
        public static void SortNamesByDescending(Student[] studentsGroup)
        {
            //Using Lambda expression
            //var descendingSort = studentsGroup.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            //Using LINQ Query
            var descendingSort =
                from st in studentsGroup
                orderby st.FirstName descending, st.LastName descending
                select st;

            Console.WriteLine("Descending order of students' names:");

            foreach (Student student in descendingSort)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Student[] group10 = new Student[]
            {
                new Student("Pavel","Ivanov", 22),
                new Student("Miro","Kirov", 25),
                new Student("Aleks","Zelev", 30),
                new Student("Dwayne","Johnson", 21),
            };

            SortByFirstName(group10);
            
            SortByAge(group10);

            SortNamesByDescending(group10);
        }
    }
}
