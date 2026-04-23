using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomReservationApp.Views
{
    internal interface IEmployeesView
    {
        string EmployeeName { get; set; }
        string Surname { get; set; }

        IEnumerable<object> EmployeeList { set; }
        IEnumerable<object> ReservationsForEmployee { set; }

        object ChosenEmployee { get; }

        event EventHandler AddEmployeeClicked;
        event EventHandler EditEmployeeClicked;
        event EventHandler RemoveEmployeeClicked;

        event EventHandler ChosenEmployeeChanged;

        void ClearForm();
        void ShowMessage(string message);
        void FormatEmployeeReservation(object sender, ListControlConvertEventArgs e);
    }
}
