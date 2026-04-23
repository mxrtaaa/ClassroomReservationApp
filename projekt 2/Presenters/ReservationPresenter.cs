using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomReservationApp.Views;
using System.Windows.Forms;
using ClassroomReservationApp.Models;
using ClassroomReservationApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ReservationReservationApp.Presenters
{
    internal class ReservationPresenter
    {
        private readonly IReservationsView _view;
        private readonly AllReservations _allReservations;
        private readonly AllEmployees _allEmployees;
        private readonly AllClassrooms _allClassrooms;

        public ReservationPresenter(IReservationsView view, AllReservations allReservations, AllEmployees allEmployees, AllClassrooms allClassrooms)
        {
            _view = view;
            _allReservations = allReservations;

            _allEmployees = allEmployees;
            _allClassrooms = allClassrooms;

            _view.AvailableClassrooms = _allClassrooms.ClassroomList;
            _view.AvailableEmployees = _allEmployees.EmployeeList;


            _view.AddReservationClicked += OnAddReservation;
            _view.EditReservationClicked += OnEditReservation;
            _view.RemoveReservationClicked += OnRemoveReservation;
            _view.ChosenReservationChanged += OnChosenReservationChanged;

            RefreshReservationList();
        }

        private void OnAddReservation(object sender, EventArgs e)
        {
            Classroom classroom = _view.SelectedClassroom as Classroom;
            Employee employee = _view.SelectedEmployee as Employee;
            DateTime date = _view.Date;
            DateTime[] time = _view.Time;


            if (classroom == null)
            {
                _view.ShowMessage("Proszę wybrać salę!");
                return;
            }

            if (employee == null)
            {
                _view.ShowMessage("Proszę wybrać prowadzącego!");
                return;
            }

            if (IsReservationTimeValid(date, time, classroom) == false)
                return;


            Reservation newReservation = new Reservation()
            {
                Classroom = classroom,
                Date = date,
                Time = time,
                Employee = employee
            };

            _allReservations.AddReservation(newReservation);
            RefreshReservationList();
            _view.ClearForm();
        }

        private void OnEditReservation(object sender, EventArgs e)
        {
            Classroom classroom = _view.SelectedClassroom as Classroom;
            Employee employee = _view.SelectedEmployee as Employee;
            DateTime date = _view.Date;
            DateTime[] time = _view.Time;


            if (classroom == null)
            {
                _view.ShowMessage("Proszę wybrać salę!");
                return;
            }

            if (employee == null)
            {
                _view.ShowMessage("Proszę wybrać prowadzącego!");
                return;
            }
            if (IsReservationTimeValid(date, time, classroom) == false)
                return;
                       

            if (_view.ChosenReservation is Reservation chosenReservation)
            {
                chosenReservation.Classroom = classroom;
                chosenReservation.Date = date;
                chosenReservation.Time = time;
                chosenReservation.Employee = employee;

                RefreshReservationList();
            }
            _view.ClearForm();
        }

        private void OnRemoveReservation(object sender, EventArgs e)
        {
            if (_view.ChosenReservation is Reservation chosenReservation)
            {
                _allReservations.RemoveReservation(chosenReservation);
                RefreshReservationList();
            }
        }

        private void OnChosenReservationChanged(object sender, EventArgs e)
        {
            if (_view.ChosenReservation is Reservation chosenReservation)
            {
                _view.SelectedClassroom = chosenReservation.Classroom;
                _view.SelectedEmployee = chosenReservation.Employee;
                _view.Date = chosenReservation.Date;
                _view.Time = chosenReservation.Time;
            }
        }

        private void RefreshReservationList()
        {
            _view.ReservationList = _allReservations.ReservationList
                                    .Where(reservation =>
                                    reservation.Date >= DateTime.Today)
                                    .OrderBy(reservation => reservation.Date.Date.Add(reservation.Time[0].TimeOfDay))
                                    .ToList();
        }

        private bool IsReservationTimeValid(DateTime _date, DateTime[] _time, Classroom classroom)
        {
            if (_time == null || _time.Length < 2 || _time[0] >= _time[1])
            {
                _view.ShowMessage("Proszę podać poprawny czas rezerwacji!");
                return false;
            }
            if (_date < DateTime.Today || (_date == DateTime.Today && _time[1].TimeOfDay < DateTime.Now.TimeOfDay))
            {
                _view.ShowMessage("Nie można utworzyć rezerwacji w przeszłości!");
                return false;
            }

            bool isOverlapping = _allReservations.ReservationList.Any(r =>
                r.Classroom == classroom &&
                r.Date.Date == _date.Date &&
                r != _view.ChosenReservation &&
                _time[0] < r.Time[1] && _time[1] > r.Time[0]

            );
            if (isOverlapping)
            {
                _view.ShowMessage("Nie można zarezerwować: sala jest zajęta. Proszę wybrać inne godziny!");
                return false;
            }

            return true;
        }
    }
}
