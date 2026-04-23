using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomReservationApp.Views
{
    internal interface IReservationsView
    {
        Classroom SelectedClassroom { get; set; }
        Employee SelectedEmployee { get; set; }
        DateTime Date { get; set; }
        DateTime[] Time { get; set; }

        IEnumerable<object> ReservationList { set; }

        IEnumerable<object> AvailableClassrooms { set; }
        IEnumerable<object> AvailableEmployees { set; }
        object ChosenReservation { get; }

        event EventHandler AddReservationClicked;
        event EventHandler EditReservationClicked;
        event EventHandler RemoveReservationClicked;

        event EventHandler ChosenReservationChanged;

        void ClearForm();
        void ShowMessage(string message);

    }
}
