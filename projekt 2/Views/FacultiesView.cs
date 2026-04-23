using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassroomReservationApp.Views;
using ClassroomReservationApp;

namespace ClassroomReservationApp
{
    public partial class FacultiesView : UserControl, IFacultiesView
    {
        public FacultiesView()
        {
            InitializeComponent();

            textBoxFacultyName.KeyPress += InputValidator.ValidateLetters_KeyPress;
            textBoxFacultyCity.KeyPress += InputValidator.ValidateLetters_KeyPress;
            maskedTextBoxFacultyPostCode.KeyPress += InputValidator.ValidateDigits_KeyPress;
            // ulica nie ma walidacji bo moze byc np. ul. 3-ego Maja
            textBoxFacultyBuildingNumber.KeyPress += InputValidator.ValidateDigits_KeyPress;

            btnAddFaculty.Click += (sender, e) => AddFacultyClicked?.Invoke(this, EventArgs.Empty);
            btnEditFaculty.Click += (sender, e) => EditFacultyClicked?.Invoke(this, EventArgs.Empty);
            btnRemoveFaculty.Click += (sender, e) => RemoveFacultyClicked?.Invoke(this, EventArgs.Empty);

            listBoxFacultyList.SelectedIndexChanged += (sender, e) => ChosenFacultyChanged?.Invoke(this, EventArgs.Empty);
            listBoxClassroomsInFaculty.Format += FormatFacultyClassroom;

        }

        public event EventHandler AddFacultyClicked;
        public event EventHandler EditFacultyClicked;
        public event EventHandler RemoveFacultyClicked;
        public event EventHandler ChosenFacultyChanged;
        public string FacultyName
        {
            get
            {
                return textBoxFacultyName.Text;
            }
            set
            {
                textBoxFacultyName.Text = value;
            }
        }

        public string City
        {
            get
            {
                return textBoxFacultyCity.Text;
            }
            set
            {
                textBoxFacultyCity.Text = value;
            }
        }

        public string PostCode
        {
            get
            {
                return maskedTextBoxFacultyPostCode.Text;
            }
            set
            {
                maskedTextBoxFacultyPostCode.Text = value;
            }
        }

        public string Street
        {
            get
            {
                return textBoxFacultyStreet.Text;
            }
            set
            {
                textBoxFacultyStreet.Text = value;
            }
        }
        public int BuildingNumber
        {
            get
            {
                if (int.TryParse(textBoxFacultyBuildingNumber.Text, out int result))
                {
                    return result;
                }
                return 0;
            }
            set
            {
                textBoxFacultyBuildingNumber.Text = value.ToString();
            }
        }

        public object ChosenFaculty => listBoxFacultyList.SelectedItem;

        public IEnumerable<object> FacultyList
        {
            set
            {
                listBoxFacultyList.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                        listBoxFacultyList.Items.Add(item);
                }
            }
        }

        public IEnumerable<object> ClassroomsInFaculty
        {
            set
            {
                listBoxClassroomsInFaculty.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                        listBoxClassroomsInFaculty.Items.Add(item);
                }
            }
        }
        public void ClearForm()
        {
            textBoxFacultyName.Clear();
            textBoxFacultyCity.Clear();
            maskedTextBoxFacultyPostCode.Clear();
            textBoxFacultyStreet.Clear();
            textBoxFacultyBuildingNumber.Clear();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void FormatFacultyClassroom(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Classroom cla)
            {
                e.Value = $"Sala {cla.Type} {cla.Number}, {cla.Capacity} osób";
            }
        }
    }
}
