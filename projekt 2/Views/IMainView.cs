using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomReservationApp.Views
{
    internal interface IMainView
    {
        event EventHandler ManageClassroomsClicked;
        event EventHandler ManageEmployeesClicked;
        event EventHandler ManageReservationsClicked;
        event EventHandler ManageFacultiesClicked;

        event EventHandler SaveDataClicked;
        event EventHandler LoadDataClicked;

        void SetMainContent(UserControl content);
        void ShowMessage(string message);
        string GetSaveFilePath();
        string GetLoadFilePath();
    }
}
