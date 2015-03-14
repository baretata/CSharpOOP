namespace _18.StudentsByGroupName
{
    using System;

    public class Student
    {
        public Student(string name, string group)
        {
            this.Name = name;
            this.Group = group;
        }

        public string Name { get; set; }
        public string Group { get; set; }

    }
}
