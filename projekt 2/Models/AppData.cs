using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp.Models
{
    public class AppData
    {
        public List<Faculty> Faculties { get; set; } = new List<Faculty>();
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
