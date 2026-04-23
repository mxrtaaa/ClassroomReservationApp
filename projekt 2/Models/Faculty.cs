using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp
{
    public class Faculty
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public override string ToString()
        {
            return $"Wydział {Name} ({Address})";
        }
        public Faculty() { }
        public Faculty(string name, Address address)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
        }
    }
}
