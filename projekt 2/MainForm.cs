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

namespace ClassroomReservationApp
{
    public partial class MainForm : Form, IMainView
    {
        public event EventHandler ManageClassroomsClicked;
        public event EventHandler ManageEmployeesClicked;
        public event EventHandler ManageReservationsClicked;
        public event EventHandler ManageFacultiesClicked;
        public event EventHandler SaveDataClicked;
        public event EventHandler LoadDataClicked;
        public MainForm()
        {
            InitializeComponent();

            stripMenuItemManageClassrooms.Click += (sender, e) => ManageClassroomsClicked?.Invoke(this, EventArgs.Empty);
            stripMenuItemManageEmployees.Click += (sender, e) => ManageEmployeesClicked?.Invoke(this, EventArgs.Empty);
            stripMenuItemManageReservations.Click += (sender, e) => ManageReservationsClicked?.Invoke(this, EventArgs.Empty);
            stripMenuItemManageFaculties.Click += (sender, e) => ManageFacultiesClicked?.Invoke(this, EventArgs.Empty);

            toolStripMenuItemSave.Click += (sender, e) => SaveDataClicked?.Invoke(this, EventArgs.Empty);
            toolStripMenuItemLoad.Click += (sender, e) => LoadDataClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetMainContent(UserControl content)
        {
            mainContentPanel.Controls.Clear();
            content.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(content);
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        public string GetSaveFilePath()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
                saveDialog.Title = "Wybierz miejsce zapisu bazy danych";
                saveDialog.FileName = "rezerwacje.json";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                    return saveDialog.FileName;

                return null;
            }
        }
        public string GetLoadFilePath()
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Pliki JSON (*.json)|*.json|Wszystkie pliki (*.*)|*.*";
                openDialog.Title = "Wybierz plik z bazą danych do wczytania";

                if (openDialog.ShowDialog() == DialogResult.OK)
                    return openDialog.FileName;

                return null;
            }
        }
    }
}
