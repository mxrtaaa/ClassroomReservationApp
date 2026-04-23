using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomReservationApp;

namespace ClassroomReservationApp
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public Classroom Classroom { get; set; }
        public DateTime Date { get; set; }
        public DateTime[] Time { get; set; }
        public Employee Employee { get; set; }
        public override string ToString()
        {
            return $"{Classroom}, {Date:d} {Time[0]:HH:mm}-{Time[1]:HH:mm}, {Employee}";
        }
        public Reservation() { }
        public Reservation(Classroom classroom, DateTime date, DateTime[] time, Employee employee)
        {
            Id = Guid.NewGuid();
            Classroom = classroom;
            Date = date;
            Time = time;
            Employee = employee;
        }
        public Reservation(Guid id, Classroom classroom, DateTime date, DateTime[] time, Employee employee)
        {
            Id = id;
            Classroom = classroom;
            Date = date;
            Time = time;
            Employee = employee;
        }
    }
}
