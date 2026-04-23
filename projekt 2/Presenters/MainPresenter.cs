using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassroomReservationApp;
using ClassroomReservationApp.Models;
using ClassroomReservationApp.Views;
using ReservationReservationApp;
using ReservationReservationApp.Presenters;

namespace ClassroomReservationApp.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView _view; 
        private readonly AllClassrooms _allClassrooms;
        private readonly AllFaculties _allFaculties;
        private readonly AllEmployees _allEmployees;
        private readonly AllReservations _allReservations;

        private readonly FileDataManager _fileManager = new FileDataManager();

        public MainPresenter(IMainView view, AllClassrooms allClassrooms, AllFaculties allFaculties, AllEmployees allEmployees, AllReservations allReservations)
        {
            _view = view;

            _allClassrooms = allClassrooms;
            _allFaculties = allFaculties;
            _allEmployees = allEmployees;
            _allReservations = allReservations;

            _view.ManageClassroomsClicked += OnManageClassrooms;
            _view.ManageEmployeesClicked += OnManageEmployees;
            _view.ManageFacultiesClicked += OnManageFaculties;
            _view.ManageReservationsClicked += OnManageReservations;

            _view.SaveDataClicked += OnSaveData;
            _view.LoadDataClicked += OnLoadData;

            _view.SetMainContent(new StartView());
        }

        private void OnManageClassrooms(object sender, EventArgs e)
        {
            var classroomsView = new ClassroomsView();

            var classroomPresenter = new ClassroomPresenter(classroomsView, _allClassrooms, _allFaculties, _allReservations);

            _view.SetMainContent(classroomsView);
        }

        private void OnManageEmployees(object sender, EventArgs e)
        {
            var employeesView = new EmployeesView();

            var employeePresenter = new EmployeePresenter(employeesView, _allEmployees, _allReservations);

            _view.SetMainContent(employeesView);
        }
        private void OnManageFaculties(object sender, EventArgs e)
        {
            var facultiesView = new FacultiesView();

            var facultyPresenter = new FacultyPresenter(facultiesView, _allFaculties, _allClassrooms);

            _view.SetMainContent(facultiesView);
        }
        private void OnManageReservations(object sender, EventArgs e)
        {
            var reservationsView = new ReservationsView();

            var reservationPresenter = new ReservationPresenter(reservationsView, _allReservations, _allEmployees, _allClassrooms);

            _view.SetMainContent(reservationsView);
        }
        private void OnSaveData(object sender, EventArgs e)
        {
            string path = _view.GetSaveFilePath();

            if (string.IsNullOrEmpty(path)) return;

            AppData dataToSave = new AppData()
            {
                Faculties = _allFaculties.FacultyList.ToList(),
                Classrooms = _allClassrooms.ClassroomList.ToList(),
                Employees = _allEmployees.EmployeeList.ToList(),
                Reservations = _allReservations.ReservationList.ToList()
            };

            _fileManager.Save(dataToSave, path);
            _view.ShowMessage("Dane zostały pomyślnie zapisane!");
        }

        private void OnLoadData(object sender, EventArgs e)
        {
            string path = _view.GetLoadFilePath();

            if (string.IsNullOrEmpty(path)) return;

            AppData loadedData = _fileManager.Load(path);

            if (loadedData == null)
            {
                _view.ShowMessage("Nie udało się wczytać pliku.");
                return;
            }

            _allFaculties.FacultyList = loadedData.Faculties;
            _allClassrooms.ClassroomList = loadedData.Classrooms;
            _allEmployees.EmployeeList = loadedData.Employees;
            _allReservations.ReservationList = loadedData.Reservations;

            _view.ShowMessage("Dane wczytane pomyślnie! Przejdź do zakładek, aby je zobaczyć.");
        }
    }

}
