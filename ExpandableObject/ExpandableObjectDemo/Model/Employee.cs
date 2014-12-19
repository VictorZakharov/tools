using System;

namespace ExpandableObjectDemo.Model
{
    class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee(string name, string title, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Title = title;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
