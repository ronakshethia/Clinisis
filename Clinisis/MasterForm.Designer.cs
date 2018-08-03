namespace Clinisis
{
    partial class MasterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quickAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consolidatedPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOutStandingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(20, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 26);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickAppointmentToolStripMenuItem,
            this.patientBookToolStripMenuItem,
            this.toolStripMenuItem1,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quickAppointmentToolStripMenuItem
            // 
            this.quickAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickAppointmentToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quickAppointmentToolStripMenuItem.Name = "quickAppointmentToolStripMenuItem";
            this.quickAppointmentToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.quickAppointmentToolStripMenuItem.Text = "Quick Appointment";
            this.quickAppointmentToolStripMenuItem.Click += new System.EventHandler(this.quickAppointmentToolStripMenuItem_Click);
            // 
            // patientBookToolStripMenuItem
            // 
            this.patientBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBookToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.patientBookToolStripMenuItem.Name = "patientBookToolStripMenuItem";
            this.patientBookToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.patientBookToolStripMenuItem.Text = "Patient Book";
            this.patientBookToolStripMenuItem.Click += new System.EventHandler(this.patientBookToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consolidatedPaymentsToolStripMenuItem,
            this.allOutStandingsToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.toolStripMenuItem1.Text = "Journal Reports";
            // 
            // consolidatedPaymentsToolStripMenuItem
            // 
            this.consolidatedPaymentsToolStripMenuItem.Name = "consolidatedPaymentsToolStripMenuItem";
            this.consolidatedPaymentsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.consolidatedPaymentsToolStripMenuItem.Text = "Consolidated Payments";
            this.consolidatedPaymentsToolStripMenuItem.Click += new System.EventHandler(this.consolidatedPaymentsToolStripMenuItem_Click);
            // 
            // allOutStandingsToolStripMenuItem
            // 
            this.allOutStandingsToolStripMenuItem.Name = "allOutStandingsToolStripMenuItem";
            this.allOutStandingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.allOutStandingsToolStripMenuItem.Text = "All Outstandings";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 405);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MasterForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "MasterForm";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quickAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolidatedPaymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOutStandingsToolStripMenuItem;
    }
}