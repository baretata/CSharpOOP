namespace _09.StudentGroups
{
    using System;

    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group()
        { 
        }

        public Group(int groupNumber, string departmentName)
            :this()
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set { this.groupNumber = value; }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            set { this.departmentName = value; }
        }
    }
}
