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
    public partial class ClassroomsView : UserControl, IClassroomsView
    {
        public ClassroomsView()
        {
            InitializeComponent();

            textBoxClassroomNumber.KeyPress += InputValidator.ValidateDigits_KeyPress;
            textBoxClassroomCapacity.KeyPress += InputValidator.ValidateDigits_KeyPress;

            btnAddClassroom.Click += (sender, e) => AddClassroomClicked?.Invoke(this, EventArgs.Empty);
            btnEditClassroom.Click += (sender, e) => EditClassroomClicked?.Invoke(this, EventArgs.Empty);
            btnRemoveClassroom.Click += (sender, e) => RemoveClassroomClicked?.Invoke(this, EventArgs.Empty);

            listBoxClassroomList.SelectedIndexChanged += (sender, e) => ChosenClassroomChanged?.Invoke(this, EventArgs.Empty);
            listBoxReservationsForClassroom.Format += FormatClassroomReservations;
        }

        public event EventHandler AddClassroomClicked;
        public event EventHandler EditClassroomClicked;
        public event EventHandler RemoveClassroomClicked;
        public event EventHandler ChosenClassroomChanged;
        public int Number
        {
            get
            {
                if (int.TryParse(textBoxClassroomNumber.Text, out int result))
                {
                    return result;
                }
                return 0;
            }
            set { textBoxClassroomNumber.Text = value.ToString(); }
        }

        public int Capacity
        {
            get
            {
                if (int.TryParse(textBoxClassroomCapacity.Text, out int result))
                {
                    return result;
                }
                return 0;
            }
            set { textBoxClassroomCapacity.Text = value.ToString(); }
        }

        public ClassroomType? SelectedType
        {
            get 
            {
                if (cmbClassroomType.SelectedItem == null)
                    return null;

                return (ClassroomType)cmbClassroomType.SelectedItem;
            }
            set { cmbClassroomType.SelectedItem = value; }
        }

        public Faculty SelectedFaculty
        {
            get { return cmbClassroomFaculty.SelectedItem as Faculty; }
            set { cmbClassroomFaculty.SelectedItem = value; }
        }

        public object ChosenClassroom
        {
            get { return listBoxClassroomList.SelectedItem; }
        }

        public IEnumerable<object> ClassroomList
        {
            set
            {
                listBoxClassroomList.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                        listBoxClassroomList.Items.Add(item);
                }
            }
        }

        public IEnumerable<object> ReservationsForClassroom
        {
            set
            {
                listBoxReservationsForClassroom.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                        listBoxReservationsForClassroom.Items.Add(item);
                }
            }
        }
        public IEnumerable<object> AvailableTypes
        {
            set 
            { 
                cmbClassroomType.DataSource = value;
                cmbClassroomType.SelectedIndex = -1;
            }
        }

        public IEnumerable<object> AvailableFaculties
        {
            set 
            { 
                cmbClassroomFaculty.DataSource = value;
                cmbClassroomFaculty.SelectedIndex = -1;
            }
        }
        public void ClearForm()
        {
            textBoxClassroomNumber.Clear();
            textBoxClassroomCapacity.Clear();
            cmbClassroomType.SelectedIndex = -1;
            cmbClassroomFaculty.SelectedIndex = -1;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void FormatClassroomReservations(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Reservation res)
            {
                e.Value = $"{res.Date:d} {res.Time[0]:HH:mm}-{res.Time[1]:HH:mm}, {res.Employee}";
            }
        }
    }
}
