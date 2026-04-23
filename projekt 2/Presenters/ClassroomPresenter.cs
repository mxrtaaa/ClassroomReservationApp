using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomReservationApp;
using System.Windows.Forms;
using ClassroomReservationApp.Views;
using System.Xml.Linq;
using ClassroomReservationApp.Models;

namespace ClassroomReservationApp.Presenters
{
    internal class ClassroomPresenter
    {
        private readonly IClassroomsView _view;
        private readonly AllClassrooms _repository;
        private readonly AllFaculties _allFaculties;
        private readonly AllReservations _allReservations;

        public ClassroomPresenter(IClassroomsView view, AllClassrooms repository, AllFaculties allFaculties, AllReservations allReservations)
        {
            _view = view;
            _repository = repository;
            _allFaculties = allFaculties;
            _allReservations = allReservations;

            _view.AvailableTypes = Enum.GetValues(typeof(ClassroomType)).Cast<object>().ToList();
            _view.AvailableFaculties = _allFaculties.FacultyList;

            _view.AddClassroomClicked += OnAddClassroom;
            _view.EditClassroomClicked += OnEditClassroom;
            _view.RemoveClassroomClicked += OnRemoveClassroom;
            _view.ChosenClassroomChanged += OnChosenClassroomChanged;
            
            RefreshClassroomList();
        }

        private void OnAddClassroom(object sender, EventArgs e)
        {
            int number = _view.Number;
            int capacity = _view.Capacity;
            ClassroomType? type = _view.SelectedType;
            Faculty faculty = _view.SelectedFaculty;

            if (number <= 0 || number > 9999)
            {
                _view.ShowMessage("Proszę podać prawidłowy numer sali!");
                return;
            }

            if (capacity <= 0 || capacity > 500)
            {
                _view.ShowMessage("Proszę podać prawidłową pojemność sali!");
                return;
            }

            if (type == null)
            {
                _view.ShowMessage("Proszę wybrać typ sali!");
                return;
            }
            
            if (faculty == null)
            {
                _view.ShowMessage("Proszę wybrać wydział!");
                return;
            }

            Classroom newClassroom = new Classroom()
            {
                Number = number,
                Capacity = capacity,
                Type = type.Value,
                Faculty = faculty
            };

            _repository.AddClassroom(newClassroom);

            RefreshClassroomList();

            _view.ClearForm();
        }

        private void OnEditClassroom(object sender, EventArgs e)
        {
            int number = _view.Number;
            int capacity = _view.Capacity;
            ClassroomType? type = _view.SelectedType;
            Faculty faculty = _view.SelectedFaculty;

            if (number <= 0 || number > 9999)
            {
                _view.ShowMessage("Proszę podać prawidłowy numer sali!");
                return;
            }

            if (capacity <= 0 || capacity > 500)
            {
                _view.ShowMessage("Proszę podać prawidłową pojemność sali!");
                return;
            }

            if (type == null)
            {
                _view.ShowMessage("Proszę wybrać typ sali!");
                return;
            }

            if (faculty == null)
            {
                _view.ShowMessage("Proszę wybrać wydział!");
                return;
            }


            if (_view.ChosenClassroom is Classroom chosenClassroom)
            {
                chosenClassroom.Number = number;
                chosenClassroom.Capacity = capacity;
                chosenClassroom.Type = type.Value;
                chosenClassroom.Faculty = faculty;

                RefreshClassroomList();
            }

            _view.ClearForm();
        }

        private void OnRemoveClassroom(object sender, EventArgs e)
        {
            if (_view.ChosenClassroom is Classroom chosenClassroom)
            {
                _repository.RemoveClassroom(chosenClassroom);
                RefreshClassroomList();
            }
        }

        private void OnChosenClassroomChanged(object sender, EventArgs e)
        {
            if (_view.ChosenClassroom is Classroom chosenClassroom)
            {
                _view.Number = chosenClassroom.Number;
                _view.Capacity = chosenClassroom.Capacity;
                _view.SelectedType = chosenClassroom.Type;
                _view.SelectedFaculty = chosenClassroom.Faculty;

                var reservationsForClassroom = _allReservations.ReservationList
                                        .Where(reservation => 
                                        reservation.Classroom != null 
                                        && reservation.Classroom == chosenClassroom
                                        && reservation.Date >= DateTime.Today)
                                        .OrderBy(reservation => reservation.Date.Date.Add(reservation.Time[0].TimeOfDay))
                                        .ToList();

                _view.ReservationsForClassroom = reservationsForClassroom;
            }
        }

        private void RefreshClassroomList()
        {
            _view.ClassroomList = _repository.ClassroomList.ToList();
        }
    }
}
