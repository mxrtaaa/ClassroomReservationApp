using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp
{
    public class Classroom
    {
        public int Number { get; set; }
        public int Capacity { get; set; }
        public Faculty Faculty { get; set; }
        public ClassroomType Type { get; set; }
        public override string ToString()
        {
            return $"Sala {Type} {Number}, {Faculty}, {Capacity} osób";
        }
        public Classroom() { }
        public Classroom(int number, int capacity, Faculty faculty, ClassroomType type)
        {
            Number = number;
            Capacity = capacity;
            Faculty = faculty;
            Type = type;
        }
    }
}
