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
    public partial class EmployeesView : UserControl, IEmployeesView
    {
        public EmployeesView()
        {
            InitializeComponent();

            textBoxEmployeeName.KeyPress += InputValidator.ValidateLetters_KeyPress;
            textBoxEmployeeSurname.KeyPress += InputValidator.ValidateLetters_KeyPress;

            btnAddEmployee.Click += (sender, e) => AddEmployeeClicked?.Invoke(this, EventArgs.Empty);
            btnEditEmployee.Click += (sender, e) => EditEmployeeClicked?.Invoke(this, EventArgs.Empty);
            btnRemoveEmployee.Click += (sender, e) => RemoveEmployeeClicked?.Invoke(this, EventArgs.Empty);

            listBoxEmployeeList.SelectedIndexChanged += (sender, e) => ChosenEmployeeChanged?.Invoke(this, EventArgs.Empty);
            listBoxReservationsForEmployee.Format += FormatEmployeeReservation;

        }
        public event EventHandler AddEmployeeClicked;
        public event EventHandler EditEmployeeClicked;
        public event EventHandler RemoveEmployeeClicked;
        public event EventHandler ChosenEmployeeChanged;

        public string EmployeeName
        {
            get
            {
                return textBoxEmployeeName.Text;
            }
            set
            {
                textBoxEmployeeName.Text = value;
            }
        }
        public string Surname
        {
            get
            {
                return textBoxEmployeeSurname.Text;
            }
            set
            {
                textBoxEmployeeSurname.Text = value;
            }
        }



        public object ChosenEmployee => listBoxEmployeeList.SelectedItem;

        public IEnumerable<object> EmployeeList
        {
            set
            {
                listBoxEmployeeList.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                        listBoxEmployeeList.Items.Add(item);
                }
            }
        }

        public IEnumerable<object> ReservationsForEmployee
        {
            set
            {
                listBoxReservationsForEmployee.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                        listBoxReservationsForEmployee.Items.Add(item);
                }
            }
        }
        public void ClearForm()
        {
            textBoxEmployeeName.Clear();
            textBoxEmployeeSurname.Clear();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public void FormatEmployeeReservation(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Reservation res)
            {
                e.Value = $"{res.Classroom}, {res.Date:d} {res.Time[0]:HH:mm}-{res.Time[1]:HH:mm}";
            }
        }
    }
}
