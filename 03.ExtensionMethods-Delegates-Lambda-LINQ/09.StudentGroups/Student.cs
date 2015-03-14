namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fN;
        private string phoneNumber;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student()
        {
        }

        public Student(string firstName, string lastName, string fN,
            string phoneNumber, string email, List<int> marks, int groupNumber)
        //: this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FN
        {
            get { return this.fN; }
            set { this.fN = value; }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public Group Group { get; set; }
    }
}
