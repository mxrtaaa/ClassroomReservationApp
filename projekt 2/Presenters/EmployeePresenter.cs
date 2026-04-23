using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomReservationApp;
using ClassroomReservationApp.Views;
using System.Windows.Forms;
using ClassroomReservationApp.Models;
using ReservationReservationApp;

namespace ClassroomReservationApp.Presenters
{
    internal class EmployeePresenter
    {
        private readonly IEmployeesView _view;
        private readonly AllEmployees _repository;
        private readonly AllReservations _allReservations;

        public EmployeePresenter(IEmployeesView view, AllEmployees repository, AllReservations allReservations)
        {
            _view = view;
            _repository = repository;
            _allReservations = allReservations;

            _view.AddEmployeeClicked += OnAddEmployee;
            _view.EditEmployeeClicked += OnEditEmployee;
            _view.RemoveEmployeeClicked += OnRemoveEmployee;
            _view.ChosenEmployeeChanged += OnChosenEmployeeChanged;

            RefreshEmployeeList();
        }

        private void OnAddEmployee(object sender, EventArgs e)
        {
            string name = _view.EmployeeName;
            string surname = _view.Surname;


            if (name == "")
            {
                _view.ShowMessage("Proszę podać imię pracownika!");
                return;
            }

            if(surname == "")
            {
                _view.ShowMessage("Proszę podać nazwisko pracownika!");
                return;
            }


            Employee newEmployee = new Employee()
            {
                Name = name,
                Surname = surname
            };

            _repository.AddEmployee(newEmployee);

            RefreshEmployeeList();

            _view.ClearForm();
        }

        private void OnEditEmployee(object sender, EventArgs e)
        {
            string name = _view.EmployeeName;
            string surname = _view.Surname;


            if (name == "")
            {
                _view.ShowMessage("Proszę podać imię pracownika!");
                return;
            }

            if (surname == "")
            {
                _view.ShowMessage("Proszę podać nazwisko pracownika!");
                return;
            }


            if (_view.ChosenEmployee is Employee chosenEmployee)
            {
                chosenEmployee.Name = name;
                chosenEmployee.Surname = surname;

                RefreshEmployeeList();
            }

            _view.ClearForm();
        }

        private void OnRemoveEmployee(object sender, EventArgs e)
        {
            if (_view.ChosenEmployee is Employee chosenEmployee)
            {
                _repository.RemoveEmployee(chosenEmployee);
                RefreshEmployeeList();
            }
        }

        private void OnChosenEmployeeChanged(object sender, EventArgs e)
        {
            if (_view.ChosenEmployee is Employee chosenEmployee)
            {
                _view.EmployeeName = chosenEmployee.Name;
                _view.Surname = chosenEmployee.Surname;

                var reservationsForEmployee = _allReservations.ReservationList
                                        .Where(reservation => 
                                        reservation.Employee != null 
                                        && reservation.Employee == chosenEmployee
                                        && reservation.Date >= DateTime.Today)
                                        .OrderBy(reservation => reservation.Date.Date.Add(reservation.Time[0].TimeOfDay))
                                        .ToList();

                _view.ReservationsForEmployee = reservationsForEmployee;
            }
        }

        private void RefreshEmployeeList()
        {
            _view.EmployeeList = _repository.EmployeeList.ToList();
        }

    }
}
