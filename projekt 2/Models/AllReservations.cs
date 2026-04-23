using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp.Models
{
    internal class AllReservations
    {
        public List<Reservation> ReservationList { get; set; } = new List<Reservation>();
        public void AddReservation(Reservation reservation)
        {
            ReservationList.Add(reservation);
        }
        public void RemoveReservation(Reservation reservation)
        {
            ReservationList.Remove(reservation);
        }
        public AllReservations() { }
    }
}
