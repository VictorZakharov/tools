using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using ExpandableObjectDemo.Model;

namespace ExpandableObjectDemo
{
    public partial class MainForm : Form
    {
        private readonly Department _department;

        public MainForm()
        {
            InitializeComponent();

            ExpandableObjectManager.TypeDescriptors.Add(Assembly.GetExecutingAssembly());
            ExpandableObjectManager.TypeDescriptors.Add(typeof(List<Employee>));
            
            _department = CreateDepartment();
        }

        private Department CreateDepartment()
        {
            Employee employee1 = new Employee("John", "Developer", new DateTime(1980, 1, 1));
            Employee employee2 = new Employee("Peter", "Tester", new DateTime(1970, 1, 1));

            var employeeList = new EmployeeList();
            employeeList.AddRange(new[] {employee1, employee2});

            var department = new Department("Technology", employeeList);
            return department;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = _department.Employees[0];
        }

        private void btnListOfEmployee_Click(object sender, EventArgs e)
        {
            var employeeList = new List<Employee>(_department.Employees);
            this.propertyGrid1.SelectedObject = employeeList;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = _department;
        }
    }
}
