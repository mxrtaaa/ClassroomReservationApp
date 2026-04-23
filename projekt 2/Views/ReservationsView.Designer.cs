namespace ReservationReservationApp
{
    partial class ReservationsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReservationList = new System.Windows.Forms.Label();
            this.listBoxReservationList = new System.Windows.Forms.ListBox();
            this.panelAllReservations = new System.Windows.Forms.Panel();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnEditReservation = new System.Windows.Forms.Button();
            this.btnRemoveReservation = new System.Windows.Forms.Button();
            this.labelManageReservation = new System.Windows.Forms.Label();
            this.panelReservationForm = new System.Windows.Forms.Panel();
            this.labelReservationDate = new System.Windows.Forms.Label();
            this.dateTimePickerReservationDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReservationTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReservationFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbReservationEmployee = new System.Windows.Forms.ComboBox();
            this.cmbReservationClassroom = new System.Windows.Forms.ComboBox();
            this.labelReservationTo = new System.Windows.Forms.Label();
            this.labelReservationFrom = new System.Windows.Forms.Label();
            this.labelReservationEmployee = new System.Windows.Forms.Label();
            this.labelReservationClassroom = new System.Windows.Forms.Label();
            this.panelManageReservation = new System.Windows.Forms.Panel();
            this.panelAllReservations.SuspendLayout();
            this.panelReservationForm.SuspendLayout();
            this.panelManageReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelReservationList
            // 
            this.labelReservationList.AutoSize = true;
            this.labelReservationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReservationList.Location = new System.Drawing.Point(2, 8);
            this.labelReservationList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationList.Name = "labelReservationList";
            this.labelReservationList.Size = new System.Drawing.Size(133, 20);
            this.labelReservationList.TabIndex = 0;
            this.labelReservationList.Text = "Lista rezerwacji";
            // 
            // listBoxReservationList
            // 
            this.listBoxReservationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxReservationList.FormattingEnabled = true;
            this.listBoxReservationList.Location = new System.Drawing.Point(5, 37);
            this.listBoxReservationList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxReservationList.Name = "listBoxReservationList";
            this.listBoxReservationList.Size = new System.Drawing.Size(313, 316);
            this.listBoxReservationList.TabIndex = 1;
            // 
            // panelAllReservations
            // 
            this.panelAllReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAllReservations.Controls.Add(this.listBoxReservationList);
            this.panelAllReservations.Controls.Add(this.labelReservationList);
            this.panelAllReservations.Location = new System.Drawing.Point(221, 1);
            this.panelAllReservations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAllReservations.Name = "panelAllReservations";
            this.panelAllReservations.Size = new System.Drawing.Size(326, 363);
            this.panelAllReservations.TabIndex = 4;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddReservation.Location = new System.Drawing.Point(49, 172);
            this.btnAddReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(117, 23);
            this.btnAddReservation.TabIndex = 0;
            this.btnAddReservation.Text = "Dodaj rezerwację";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            // 
            // btnEditReservation
            // 
            this.btnEditReservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditReservation.Location = new System.Drawing.Point(49, 199);
            this.btnEditReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditReservation.Name = "btnEditReservation";
            this.btnEditReservation.Size = new System.Drawing.Size(117, 23);
            this.btnEditReservation.TabIndex = 1;
            this.btnEditReservation.Text = "Edytuj rezerwację";
            this.btnEditReservation.UseVisualStyleBackColor = false;
            // 
            // btnRemoveReservation
            // 
            this.btnRemoveReservation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveReservation.Location = new System.Drawing.Point(49, 226);
            this.btnRemoveReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveReservation.Name = "btnRemoveReservation";
            this.btnRemoveReservation.Size = new System.Drawing.Size(117, 23);
            this.btnRemoveReservation.TabIndex = 2;
            this.btnRemoveReservation.Text = "Usuń rezerwację";
            this.btnRemoveReservation.UseVisualStyleBackColor = false;
            // 
            // labelManageReservation
            // 
            this.labelManageReservation.AutoSize = true;
            this.labelManageReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManageReservation.Location = new System.Drawing.Point(10, 8);
            this.labelManageReservation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManageReservation.Name = "labelManageReservation";
            this.labelManageReservation.Size = new System.Drawing.Size(179, 20);
            this.labelManageReservation.TabIndex = 3;
            this.labelManageReservation.Text = "Zarządzaj rezerwacją";
            // 
            // panelReservationForm
            // 
            this.panelReservationForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReservationForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelReservationForm.Controls.Add(this.labelReservationDate);
            this.panelReservationForm.Controls.Add(this.dateTimePickerReservationDate);
            this.panelReservationForm.Controls.Add(this.dateTimePickerReservationTo);
            this.panelReservationForm.Controls.Add(this.dateTimePickerReservationFrom);
            this.panelReservationForm.Controls.Add(this.cmbReservationEmployee);
            this.panelReservationForm.Controls.Add(this.cmbReservationClassroom);
            this.panelReservationForm.Controls.Add(this.labelReservationTo);
            this.panelReservationForm.Controls.Add(this.labelReservationFrom);
            this.panelReservationForm.Controls.Add(this.labelReservationEmployee);
            this.panelReservationForm.Controls.Add(this.labelReservationClassroom);
            this.panelReservationForm.Location = new System.Drawing.Point(13, 36);
            this.panelReservationForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelReservationForm.Name = "panelReservationForm";
            this.panelReservationForm.Size = new System.Drawing.Size(199, 120);
            this.panelReservationForm.TabIndex = 4;
            // 
            // labelReservationDate
            // 
            this.labelReservationDate.AutoSize = true;
            this.labelReservationDate.Location = new System.Drawing.Point(5, 55);
            this.labelReservationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationDate.Name = "labelReservationDate";
            this.labelReservationDate.Size = new System.Drawing.Size(30, 13);
            this.labelReservationDate.TabIndex = 11;
            this.labelReservationDate.Text = "Data";
            // 
            // dateTimePickerReservationDate
            // 
            this.dateTimePickerReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReservationDate.Location = new System.Drawing.Point(73, 52);
            this.dateTimePickerReservationDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerReservationDate.Name = "dateTimePickerReservationDate";
            this.dateTimePickerReservationDate.Size = new System.Drawing.Size(80, 20);
            this.dateTimePickerReservationDate.TabIndex = 10;
            // 
            // dateTimePickerReservationTo
            // 
            this.dateTimePickerReservationTo.CustomFormat = "HH\':\'mm";
            this.dateTimePickerReservationTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReservationTo.Location = new System.Drawing.Point(73, 93);
            this.dateTimePickerReservationTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerReservationTo.Name = "dateTimePickerReservationTo";
            this.dateTimePickerReservationTo.ShowUpDown = true;
            this.dateTimePickerReservationTo.Size = new System.Drawing.Size(54, 20);
            this.dateTimePickerReservationTo.TabIndex = 9;
            this.dateTimePickerReservationTo.Value = new System.DateTime(2000, 1, 1, 9, 0, 0, 0);
            // 
            // dateTimePickerReservationFrom
            // 
            this.dateTimePickerReservationFrom.CustomFormat = "HH\':\'mm";
            this.dateTimePickerReservationFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReservationFrom.Location = new System.Drawing.Point(73, 73);
            this.dateTimePickerReservationFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerReservationFrom.Name = "dateTimePickerReservationFrom";
            this.dateTimePickerReservationFrom.ShowUpDown = true;
            this.dateTimePickerReservationFrom.Size = new System.Drawing.Size(54, 20);
            this.dateTimePickerReservationFrom.TabIndex = 8;
            this.dateTimePickerReservationFrom.Value = new System.DateTime(2000, 1, 1, 8, 0, 0, 0);
            // 
            // cmbReservationEmployee
            // 
            this.cmbReservationEmployee.AutoCompleteCustomSource.AddRange(new string[] {
            "komputerowa",
            "ćwiczeniowa",
            "wykładowa"});
            this.cmbReservationEmployee.FormattingEnabled = true;
            this.cmbReservationEmployee.Items.AddRange(new object[] {
            "computer",
            "exercise",
            "lecture"});
            this.cmbReservationEmployee.Location = new System.Drawing.Point(73, 30);
            this.cmbReservationEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbReservationEmployee.Name = "cmbReservationEmployee";
            this.cmbReservationEmployee.Size = new System.Drawing.Size(112, 21);
            this.cmbReservationEmployee.TabIndex = 7;
            // 
            // cmbReservationClassroom
            // 
            this.cmbReservationClassroom.FormattingEnabled = true;
            this.cmbReservationClassroom.Location = new System.Drawing.Point(45, 8);
            this.cmbReservationClassroom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbReservationClassroom.Name = "cmbReservationClassroom";
            this.cmbReservationClassroom.Size = new System.Drawing.Size(140, 21);
            this.cmbReservationClassroom.TabIndex = 6;
            // 
            // labelReservationTo
            // 
            this.labelReservationTo.AutoSize = true;
            this.labelReservationTo.Location = new System.Drawing.Point(5, 97);
            this.labelReservationTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationTo.Name = "labelReservationTo";
            this.labelReservationTo.Size = new System.Drawing.Size(24, 13);
            this.labelReservationTo.TabIndex = 3;
            this.labelReservationTo.Text = "Do:";
            // 
            // labelReservationFrom
            // 
            this.labelReservationFrom.AutoSize = true;
            this.labelReservationFrom.Location = new System.Drawing.Point(5, 76);
            this.labelReservationFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationFrom.Name = "labelReservationFrom";
            this.labelReservationFrom.Size = new System.Drawing.Size(24, 13);
            this.labelReservationFrom.TabIndex = 2;
            this.labelReservationFrom.Text = "Od:";
            // 
            // labelReservationEmployee
            // 
            this.labelReservationEmployee.AutoSize = true;
            this.labelReservationEmployee.Location = new System.Drawing.Point(5, 32);
            this.labelReservationEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationEmployee.Name = "labelReservationEmployee";
            this.labelReservationEmployee.Size = new System.Drawing.Size(57, 13);
            this.labelReservationEmployee.TabIndex = 1;
            this.labelReservationEmployee.Text = "Pracownik";
            // 
            // labelReservationClassroom
            // 
            this.labelReservationClassroom.AutoSize = true;
            this.labelReservationClassroom.Location = new System.Drawing.Point(5, 10);
            this.labelReservationClassroom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationClassroom.Name = "labelReservationClassroom";
            this.labelReservationClassroom.Size = new System.Drawing.Size(28, 13);
            this.labelReservationClassroom.TabIndex = 0;
            this.labelReservationClassroom.Text = "Sala";
            // 
            // panelManageReservation
            // 
            this.panelManageReservation.Controls.Add(this.panelReservationForm);
            this.panelManageReservation.Controls.Add(this.labelManageReservation);
            this.panelManageReservation.Controls.Add(this.btnRemoveReservation);
            this.panelManageReservation.Controls.Add(this.btnEditReservation);
            this.panelManageReservation.Controls.Add(this.btnAddReservation);
            this.panelManageReservation.Location = new System.Drawing.Point(2, 2);
            this.panelManageReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelManageReservation.Name = "panelManageReservation";
            this.panelManageReservation.Size = new System.Drawing.Size(215, 363);
            this.panelManageReservation.TabIndex = 5;
            // 
            // ReservationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManageReservation);
            this.Controls.Add(this.panelAllReservations);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReservationsView";
            this.Size = new System.Drawing.Size(549, 367);
            this.panelAllReservations.ResumeLayout(false);
            this.panelAllReservations.PerformLayout();
            this.panelReservationForm.ResumeLayout(false);
            this.panelReservationForm.PerformLayout();
            this.panelManageReservation.ResumeLayout(false);
            this.panelManageReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelReservationList;
        private System.Windows.Forms.ListBox listBoxReservationList;
        private System.Windows.Forms.Panel panelAllReservations;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnEditReservation;
        private System.Windows.Forms.Button btnRemoveReservation;
        private System.Windows.Forms.Label labelManageReservation;
        private System.Windows.Forms.Panel panelReservationForm;
        private System.Windows.Forms.ComboBox cmbReservationEmployee;
        private System.Windows.Forms.ComboBox cmbReservationClassroom;
        private System.Windows.Forms.Label labelReservationTo;
        private System.Windows.Forms.Label labelReservationFrom;
        private System.Windows.Forms.Label labelReservationEmployee;
        private System.Windows.Forms.Label labelReservationClassroom;
        private System.Windows.Forms.Panel panelManageReservation;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservationTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservationFrom;
        private System.Windows.Forms.Label labelReservationDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservationDate;
    }
}
