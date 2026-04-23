using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomReservationApp;

namespace ClassroomReservationApp
{
    internal class AllClassrooms
    {
        public List<Classroom> ClassroomList { get; set; } = new List<Classroom>();
        public void AddClassroom(Classroom classroom)
        {
            ClassroomList.Add(classroom);
        }
        public void RemoveClassroom(Classroom classroom)
        {
            ClassroomList.Remove(classroom);
        }
        public AllClassrooms() { }

    }
}
