using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
        public Employee() { }
        public Employee(string name, string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
        }
        public Employee(Guid id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}
