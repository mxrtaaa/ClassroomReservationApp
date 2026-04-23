using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomReservationApp;
using ClassroomReservationApp.Views;
using System.Windows.Forms;

namespace ClassroomReservationApp.Presenters
{
    internal class FacultyPresenter
    {
        private readonly IFacultiesView _view;
        private readonly AllFaculties _repository;
        private readonly AllClassrooms _allClassrooms;

        public FacultyPresenter(IFacultiesView view, AllFaculties repository, AllClassrooms allClassrooms)
        {
            _view = view;
            _repository = repository;
            _allClassrooms = allClassrooms;

            _view.AddFacultyClicked += OnAddFaculty;
            _view.EditFacultyClicked += OnEditFaculty;
            _view.RemoveFacultyClicked += OnRemoveFaculty;
            _view.ChosenFacultyChanged += OnChosenFacultyChanged;

            RefreshFacultyList();
        }

        private void OnAddFaculty(object sender, EventArgs e)
        {
            string facultyName = _view.FacultyName;
            string city = _view.City;
            string postCode = _view.PostCode;
            string street = _view.Street;
            int buildingNumber = _view.BuildingNumber;


            if (facultyName == "")
            {
                _view.ShowMessage("Proszę podać nazwę wydziału!");
                return;
            }

            if (city == "")
            {
                _view.ShowMessage("Proszę podać miasto!");
                return;
            }

            if (postCode == "" || postCode.Length != 5 || postCode.Contains(" "))
            {
                _view.ShowMessage("Proszę podać prawidłowy kod pocztowy!");
                return;
            }

            if (street == "")
            {
                _view.ShowMessage("Proszę podać nazwę ulicy!");
                return;
            }

            if (buildingNumber <= 0 || buildingNumber > 10000)
            {
                _view.ShowMessage("Proszę podać prawidłowy numer budynku!");
                return;
            }

            Faculty newFaculty = new Faculty()
            {
                Name = facultyName,
                Address = new Address()
                {
                    City = city,
                    PostCode = postCode,
                    Street = street,
                    BuildingNumber = buildingNumber
                }
            };

            _repository.AddFaculty(newFaculty);

            RefreshFacultyList();
            _view.ClearForm();
        }

        private void OnEditFaculty(object sender, EventArgs e)
        {
            string name = _view.FacultyName;
            string city = _view.City;
            string postCode = _view.PostCode;
            string street = _view.Street;
            int buildingNumber = _view.BuildingNumber;


            if (name == "")
            {
                _view.ShowMessage("Proszę podać nazwę wydziału!");
                return;
            }

            if (city == "")
            {
                _view.ShowMessage("Proszę podać miasto!");
                return;
            }

            if (postCode == "")
            {
                _view.ShowMessage("Proszę podać kod pocztowy!");
                return;
            }

            if (street == "")
            {
                _view.ShowMessage("Proszę podać nazwę ulicy!");
                return;
            }

            if (buildingNumber <= 0)
            {
                _view.ShowMessage("Proszę podać numer budynku!");
                return;
            }


            if (_view.ChosenFaculty is Faculty chosenFaculty)
            {
                chosenFaculty.Name = name;
                chosenFaculty.Address.City = city;
                chosenFaculty.Address.PostCode = postCode;
                chosenFaculty.Address.Street = street;
                chosenFaculty.Address.BuildingNumber = buildingNumber;

                RefreshFacultyList();
            }

            _view.ClearForm();
        }

        private void OnRemoveFaculty(object sender, EventArgs e)
        {
            if (_view.ChosenFaculty is Faculty chosenFaculty)
            {
                //if ()
                _repository.RemoveFaculty(chosenFaculty);
                RefreshFacultyList();
            }
        }

        private void OnChosenFacultyChanged(object sender, EventArgs e)
        {
            if (_view.ChosenFaculty is Faculty chosenFaculty)
            {
                _view.FacultyName = chosenFaculty.Name;
                _view.City = chosenFaculty.Address.City;
                _view.PostCode = chosenFaculty.Address.PostCode;
                _view.Street = chosenFaculty.Address.Street;
                _view.BuildingNumber = chosenFaculty.Address.BuildingNumber;

                var classroomsInFaculty = _allClassrooms.ClassroomList
                                        .Where(classroom => classroom.Faculty != null && classroom.Faculty == chosenFaculty)
                                        .ToList();

                _view.ClassroomsInFaculty = classroomsInFaculty;
            }
        }

        private void RefreshFacultyList()
        {
            _view.FacultyList = _repository.FacultyList.ToList();
        }
    }
}
