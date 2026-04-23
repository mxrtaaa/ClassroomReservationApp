using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassroomReservationApp.Models;
using ClassroomReservationApp.Presenters;
using ClassroomReservationApp.Views;

namespace ClassroomReservationApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var allClassrooms = new AllClassrooms();
            var allFaculties = new AllFaculties();
            var allReservations = new AllReservations();
            var allEmployees = new AllEmployees();

            var mainView = new MainForm();

            var mainPresenter = new MainPresenter(mainView, allClassrooms, allFaculties, allEmployees, allReservations);

            Application.Run(mainView);
        }

    }
}
