namespace ClassroomReservationApp
{
    partial class EmployeesView
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
            this.panelManageEmployee = new System.Windows.Forms.Panel();
            this.panelEmployeeForm = new System.Windows.Forms.Panel();
            this.textBoxEmployeeSurname = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.labelEmployeeSurname = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelManageEmployee = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.panelAllEmployees = new System.Windows.Forms.Panel();
            this.listBoxEmployeeList = new System.Windows.Forms.ListBox();
            this.labelEmployeeList = new System.Windows.Forms.Label();
            this.panelReservationsForEmployee = new System.Windows.Forms.Panel();
            this.listBoxReservationsForEmployee = new System.Windows.Forms.ListBox();
            this.labelReservationsForEmployee = new System.Windows.Forms.Label();
            this.panelManageEmployee.SuspendLayout();
            this.panelEmployeeForm.SuspendLayout();
            this.panelAllEmployees.SuspendLayout();
            this.panelReservationsForEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageEmployee
            // 
            this.panelManageEmployee.Controls.Add(this.panelEmployeeForm);
            this.panelManageEmployee.Controls.Add(this.labelManageEmployee);
            this.panelManageEmployee.Controls.Add(this.btnRemoveEmployee);
            this.panelManageEmployee.Controls.Add(this.btnEditEmployee);
            this.panelManageEmployee.Controls.Add(this.btnAddEmployee);
            this.panelManageEmployee.Location = new System.Drawing.Point(2, 2);
            this.panelManageEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelManageEmployee.Name = "panelManageEmployee";
            this.panelManageEmployee.Size = new System.Drawing.Size(215, 358);
            this.panelManageEmployee.TabIndex = 5;
            // 
            // panelEmployeeForm
            // 
            this.panelEmployeeForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmployeeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelEmployeeForm.Controls.Add(this.textBoxEmployeeSurname);
            this.panelEmployeeForm.Controls.Add(this.textBoxEmployeeName);
            this.panelEmployeeForm.Controls.Add(this.labelEmployeeSurname);
            this.panelEmployeeForm.Controls.Add(this.labelEmployeeName);
            this.panelEmployeeForm.Location = new System.Drawing.Point(13, 36);
            this.panelEmployeeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEmployeeForm.Name = "panelEmployeeForm";
            this.panelEmployeeForm.Size = new System.Drawing.Size(199, 57);
            this.panelEmployeeForm.TabIndex = 4;
            // 
            // textBoxEmployeeSurname
            // 
            this.textBoxEmployeeSurname.Location = new System.Drawing.Point(70, 29);
            this.textBoxEmployeeSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmployeeSurname.Name = "textBoxEmployeeSurname";
            this.textBoxEmployeeSurname.Size = new System.Drawing.Size(124, 20);
            this.textBoxEmployeeSurname.TabIndex = 5;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(70, 8);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(124, 20);
            this.textBoxEmployeeName.TabIndex = 4;
            // 
            // labelEmployeeSurname
            // 
            this.labelEmployeeSurname.AutoSize = true;
            this.labelEmployeeSurname.Location = new System.Drawing.Point(5, 31);
            this.labelEmployeeSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeSurname.Name = "labelEmployeeSurname";
            this.labelEmployeeSurname.Size = new System.Drawing.Size(53, 13);
            this.labelEmployeeSurname.TabIndex = 1;
            this.labelEmployeeSurname.Text = "Nazwisko";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(5, 10);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(26, 13);
            this.labelEmployeeName.TabIndex = 0;
            this.labelEmployeeName.Text = "Imię";
            // 
            // labelManageEmployee
            // 
            this.labelManageEmployee.AutoSize = true;
            this.labelManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelManageEmployee.Location = new System.Drawing.Point(10, 8);
            this.labelManageEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelManageEmployee.Name = "labelManageEmployee";
            this.labelManageEmployee.Size = new System.Drawing.Size(201, 20);
            this.labelManageEmployee.TabIndex = 3;
            this.labelManageEmployee.Text = "Zarządzaj pracownikiem";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(53, 166);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(117, 23);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Usuń pracownika";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditEmployee.Location = new System.Drawing.Point(53, 139);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(117, 23);
            this.btnEditEmployee.TabIndex = 1;
            this.btnEditEmployee.Text = "Edytuj pracownika";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(53, 112);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(117, 23);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Dodaj pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // panelAllEmployees
            // 
            this.panelAllEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAllEmployees.Controls.Add(this.listBoxEmployeeList);
            this.panelAllEmployees.Controls.Add(this.labelEmployeeList);
            this.panelAllEmployees.Location = new System.Drawing.Point(221, 1);
            this.panelAllEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAllEmployees.Name = "panelAllEmployees";
            this.panelAllEmployees.Size = new System.Drawing.Size(198, 359);
            this.panelAllEmployees.TabIndex = 4;
            // 
            // listBoxEmployeeList
            // 
            this.listBoxEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEmployeeList.FormattingEnabled = true;
            this.listBoxEmployeeList.Location = new System.Drawing.Point(5, 37);
            this.listBoxEmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxEmployeeList.Name = "listBoxEmployeeList";
            this.listBoxEmployeeList.Size = new System.Drawing.Size(192, 303);
            this.listBoxEmployeeList.TabIndex = 1;
            // 
            // labelEmployeeList
            // 
            this.labelEmployeeList.AutoSize = true;
            this.labelEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEmployeeList.Location = new System.Drawing.Point(2, 8);
            this.labelEmployeeList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmployeeList.Name = "labelEmployeeList";
            this.labelEmployeeList.Size = new System.Drawing.Size(155, 20);
            this.labelEmployeeList.TabIndex = 0;
            this.labelEmployeeList.Text = "Lista pracowników";
            // 
            // panelReservationsForEmployee
            // 
            this.panelReservationsForEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReservationsForEmployee.Controls.Add(this.listBoxReservationsForEmployee);
            this.panelReservationsForEmployee.Controls.Add(this.labelReservationsForEmployee);
            this.panelReservationsForEmployee.Location = new System.Drawing.Point(423, 1);
            this.panelReservationsForEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelReservationsForEmployee.Name = "panelReservationsForEmployee";
            this.panelReservationsForEmployee.Size = new System.Drawing.Size(207, 359);
            this.panelReservationsForEmployee.TabIndex = 3;
            // 
            // listBoxReservationsForEmployee
            // 
            this.listBoxReservationsForEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxReservationsForEmployee.FormattingEnabled = true;
            this.listBoxReservationsForEmployee.Location = new System.Drawing.Point(5, 37);
            this.listBoxReservationsForEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxReservationsForEmployee.Name = "listBoxReservationsForEmployee";
            this.listBoxReservationsForEmployee.Size = new System.Drawing.Size(191, 303);
            this.listBoxReservationsForEmployee.TabIndex = 1;
            // 
            // labelReservationsForEmployee
            // 
            this.labelReservationsForEmployee.AutoSize = true;
            this.labelReservationsForEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReservationsForEmployee.Location = new System.Drawing.Point(2, 8);
            this.labelReservationsForEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReservationsForEmployee.Name = "labelReservationsForEmployee";
            this.labelReservationsForEmployee.Size = new System.Drawing.Size(197, 20);
            this.labelReservationsForEmployee.TabIndex = 0;
            this.labelReservationsForEmployee.Text = "Rezerwacje pracownika";
            // 
            // EmployeesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelManageEmployee);
            this.Controls.Add(this.panelAllEmployees);
            this.Controls.Add(this.panelReservationsForEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeesView";
            this.Size = new System.Drawing.Size(631, 362);
            this.panelManageEmployee.ResumeLayout(false);
            this.panelManageEmployee.PerformLayout();
            this.panelEmployeeForm.ResumeLayout(false);
            this.panelEmployeeForm.PerformLayout();
            this.panelAllEmployees.ResumeLayout(false);
            this.panelAllEmployees.PerformLayout();
            this.panelReservationsForEmployee.ResumeLayout(false);
            this.panelReservationsForEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageEmployee;
        private System.Windows.Forms.Panel panelEmployeeForm;
        private System.Windows.Forms.TextBox textBoxEmployeeSurname;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label labelEmployeeSurname;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelManageEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Panel panelAllEmployees;
        private System.Windows.Forms.ListBox listBoxEmployeeList;
        private System.Windows.Forms.Label labelEmployeeList;
        private System.Windows.Forms.Panel panelReservationsForEmployee;
        private System.Windows.Forms.ListBox listBoxReservationsForEmployee;
        private System.Windows.Forms.Label labelReservationsForEmployee;
    }
}
