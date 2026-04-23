using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp
{
    internal class AllEmployees
    {
        public List<Employee> EmployeeList { get; set; } = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            EmployeeList.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            EmployeeList.Remove(employee);
        }
        public AllEmployees() { }
    }
}
