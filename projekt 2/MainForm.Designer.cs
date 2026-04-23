namespace ClassroomReservationApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemManage = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemManageReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemManageClassrooms = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemManageFaculties = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemManageEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemManage});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(913, 32);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLoad,
            this.toolStripMenuItemSave});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(53, 28);
            this.toolStripMenuItemFile.Text = "Plik";
            // 
            // toolStripMenuItemLoad
            // 
            this.toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
            this.toolStripMenuItemLoad.Size = new System.Drawing.Size(171, 34);
            this.toolStripMenuItemLoad.Text = "Wczytaj";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(171, 34);
            this.toolStripMenuItemSave.Text = "Zapisz";
            // 
            // toolStripMenuItemManage
            // 
            this.toolStripMenuItemManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuItemManageReservations,
            this.stripMenuItemManageClassrooms,
            this.stripMenuItemManageFaculties,
            this.stripMenuItemManageEmployees});
            this.toolStripMenuItemManage.Name = "toolStripMenuItemManage";
            this.toolStripMenuItemManage.Size = new System.Drawing.Size(101, 28);
            this.toolStripMenuItemManage.Text = "Zarządzaj";
            // 
            // stripMenuItemManageReservations
            // 
            this.stripMenuItemManageReservations.Name = "stripMenuItemManageReservations";
            this.stripMenuItemManageReservations.Size = new System.Drawing.Size(270, 34);
            this.stripMenuItemManageReservations.Text = "Rezerwacje";
            // 
            // stripMenuItemManageClassrooms
            // 
            this.stripMenuItemManageClassrooms.Name = "stripMenuItemManageClassrooms";
            this.stripMenuItemManageClassrooms.Size = new System.Drawing.Size(270, 34);
            this.stripMenuItemManageClassrooms.Text = "Sale";
            // 
            // stripMenuItemManageFaculties
            // 
            this.stripMenuItemManageFaculties.Name = "stripMenuItemManageFaculties";
            this.stripMenuItemManageFaculties.Size = new System.Drawing.Size(270, 34);
            this.stripMenuItemManageFaculties.Text = "Wydziały";
            // 
            // stripMenuItemManageEmployees
            // 
            this.stripMenuItemManageEmployees.Name = "stripMenuItemManageEmployees";
            this.stripMenuItemManageEmployees.Size = new System.Drawing.Size(270, 34);
            this.stripMenuItemManageEmployees.Text = "Pracownicy";
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(0, 32);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(913, 518);
            this.mainContentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 550);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Rezerwacja Sal";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemManage;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemManageReservations;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemManageClassrooms;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemManageFaculties;
        private System.Windows.Forms.ToolStripMenuItem stripMenuItemManageEmployees;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoad;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
    }
}

