using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomReservationApp.Views
{
    internal interface IClassroomsView
    {
        int Number { get; set; }
        int Capacity { get; set; }
        ClassroomType? SelectedType { get; set; }
        Faculty SelectedFaculty { get; set; }

        IEnumerable<object> ClassroomList { set; }
        IEnumerable<object> ReservationsForClassroom { set; }
        IEnumerable<object> AvailableTypes { set; }
        IEnumerable<object> AvailableFaculties { set; }

        object ChosenClassroom { get; }

        event EventHandler AddClassroomClicked;
        event EventHandler EditClassroomClicked;
        event EventHandler RemoveClassroomClicked;

        event EventHandler ChosenClassroomChanged;

        void ClearForm();
        void ShowMessage(string message);
        void FormatClassroomReservations(object sender, ListControlConvertEventArgs e);
    }
}
