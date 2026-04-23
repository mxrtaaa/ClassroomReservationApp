using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomReservationApp.Views
{
    internal interface IFacultiesView
    {
        string FacultyName { get; set; }
        string City { get; set; }
        string PostCode { get; set; }
        string Street { get; set; }
        int BuildingNumber { get; set; }

        IEnumerable<object> FacultyList { set; }
        IEnumerable<object> ClassroomsInFaculty { set; }

        object ChosenFaculty { get; }

        event EventHandler AddFacultyClicked;
        event EventHandler EditFacultyClicked;
        event EventHandler RemoveFacultyClicked;

        event EventHandler ChosenFacultyChanged;

        void ClearForm();
        void ShowMessage(string message);
        void FormatFacultyClassroom(object sender, ListControlConvertEventArgs e);
    }
}
