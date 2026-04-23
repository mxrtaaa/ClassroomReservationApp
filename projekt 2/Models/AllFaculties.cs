using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomReservationApp;

namespace ClassroomReservationApp
{
    internal class AllFaculties
    {
        public List<Faculty> FacultyList { get; set; } = new List<Faculty>();
        public void AddFaculty(Faculty faculty)
        {
            FacultyList.Add(faculty);
        }
        public void RemoveFaculty(Faculty faculty)
        {
            FacultyList.Remove(faculty);
        }
        public AllFaculties() { }
    }
}
