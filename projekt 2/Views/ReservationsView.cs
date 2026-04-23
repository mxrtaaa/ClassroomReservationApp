using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassroomReservationApp;
using ClassroomReservationApp.Views;
using ClassroomReservationApp;

namespace ReservationReservationApp
{
    public partial class ReservationsView : UserControl, IReservationsView
    {
        public ReservationsView()
        {
            InitializeComponent();

            btnAddReservation.Click += (sender, e) => AddReservationClicked?.Invoke(this, EventArgs.Empty);
            btnEditReservation.Click += (sender, e) => EditReservationClicked?.Invoke(this, EventArgs.Empty);
            btnRemoveReservation.Click += (sender, e) => RemoveReservationClicked?.Invoke(this, EventArgs.Empty);

            listBoxReservationList.SelectedIndexChanged += (sender, e) => ChosenReservationChanged?.Invoke(this, EventArgs.Empty);

        }

        public event EventHandler AddReservationClicked;
        public event EventHandler EditReservationClicked;
        public event EventHandler RemoveReservationClicked;
        public event EventHandler ChosenReservationChanged;

        public Classroom SelectedClassroom
        {
            get { return cmbReservationClassroom.SelectedItem as Classroom; }
            set { cmbReservationClassroom.SelectedItem = value; }
        }

        public Employee SelectedEmployee
        {
            get { return cmbReservationEmployee.SelectedItem as Employee; }
            set { cmbReservationEmployee.SelectedItem = value; }
        }

        public DateTime Date
        {
            get { return dateTimePickerReservationDate.Value; }
            set { dateTimePickerReservationDate.Value = value; }
        }

        public DateTime[] Time
        {
            get { return new DateTime[] { dateTimePickerReservationFrom.Value, dateTimePickerReservationTo.Value }; }
            set
            {
                if (value != null && value.Length == 2)
                {
                    dateTimePickerReservationFrom.Value = value[0];
                    dateTimePickerReservationTo.Value = value[1];
                }
            }
        }
        public object ChosenReservation
        {
            get { return listBoxReservationList.SelectedItem; }
        }

        public IEnumerable<object> ReservationList
        {
            set
            {
                listBoxReservationList.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                        listBoxReservationList.Items.Add(item);
                }
            }
        }

        public IEnumerable<object> AvailableClassrooms
        {
            set 
            { 
                cmbReservationClassroom.DataSource = value;
                cmbReservationClassroom.SelectedIndex = -1;
            }
        }

        public IEnumerable<object> AvailableEmployees
        {
            set 
            { 
                cmbReservationEmployee.DataSource = value;
                cmbReservationEmployee.SelectedIndex = -1;
            }
        }
        public void ClearForm()
        {
            cmbReservationClassroom.SelectedIndex = -1;
            cmbReservationEmployee.SelectedIndex = -1;
            dateTimePickerReservationDate.Value = DateTime.Now;
            dateTimePickerReservationFrom.Value = new DateTime(2000, 1, 1, 8, 0, 0);
            dateTimePickerReservationTo.Value = new DateTime(2000, 1, 1, 9, 0, 0);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
