using System.Collections.Generic;

namespace ExpandableObjectDemo.Model
{
    class Department
    {
        public string Name { get; set; }
        public EmployeeList Employees { get; set; }

        public Department(string name, EmployeeList employees)
        {
            this.Name = name;
            this.Employees = employees;
        }
    }
}
