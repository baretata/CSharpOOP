namespace _03.SortingStudentsNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private byte age;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age 
        {
            get { return age; }
            set
            {
                if (age < 0 || age >= 125)
                {
                    throw new ArgumentOutOfRangeException("Index is not valid age");
                }
                this.age = value;
            }
        }

        public Student(string firstName,string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;

        }
    }
}
