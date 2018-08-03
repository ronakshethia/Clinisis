#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Clinisis
{
    partial class MetroForm1
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
            this.components = new System.ComponentModel.Container();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.AddPatientsPanel = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.HistoryTextBox = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.MaleCombo = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.FemaleCombo = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowData = new System.Windows.Forms.DataGridView();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.AgeTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PhoneTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.AddressTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Addpatient = new System.Windows.Forms.PictureBox();
            this.PatientNameSearchBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientsPanel)).BeginInit();
            this.AddPatientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaleCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemaleCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addpatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientNameSearchBox)).BeginInit();
            this.SuspendLayout();
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(111, 11);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(191, 25);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "Patient Selection";
            this.autoLabel1.Click += new System.EventHandler(this.autoLabel1_Click);
            // 
            // AddPatientsPanel
            // 
            this.AddPatientsPanel.BackColor = System.Drawing.Color.Snow;
            this.AddPatientsPanel.Border = new System.Windows.Forms.Padding(5);
            this.AddPatientsPanel.BorderGap = 5;
            this.AddPatientsPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddPatientsPanel.Controls.Add(this.buttonAdv1);
            this.AddPatientsPanel.Controls.Add(this.HistoryTextBox);
            this.AddPatientsPanel.Controls.Add(this.MaleCombo);
            this.AddPatientsPanel.Controls.Add(this.FemaleCombo);
            this.AddPatientsPanel.Controls.Add(this.AgeTextBox);
            this.AddPatientsPanel.Controls.Add(this.PhoneTextBox);
            this.AddPatientsPanel.Controls.Add(this.AddressTextBox);
            this.AddPatientsPanel.Controls.Add(this.NameTextBox);
            this.AddPatientsPanel.Controls.Add(this.label2);
            this.AddPatientsPanel.Controls.Add(this.label6);
            this.AddPatientsPanel.Controls.Add(this.label5);
            this.AddPatientsPanel.Controls.Add(this.label4);
            this.AddPatientsPanel.Controls.Add(this.label3);
            this.AddPatientsPanel.Controls.Add(this.label1);
            this.AddPatientsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddPatientsPanel.Location = new System.Drawing.Point(625, 0);
            this.AddPatientsPanel.Name = "AddPatientsPanel";
            this.AddPatientsPanel.Size = new System.Drawing.Size(401, 387);
            this.AddPatientsPanel.TabIndex = 4;
            this.AddPatientsPanel.Visible = false;
            // 
            // HistoryTextBox
            // 
            this.HistoryTextBox.AutoSuggestFormula = false;
            this.HistoryTextBox.DisabledBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.HistoryTextBox.EnabledBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HistoryTextBox.Location = new System.Drawing.Point(115, 220);
            this.HistoryTextBox.Multiline = true;
            this.HistoryTextBox.Name = "HistoryTextBox";
            this.HistoryTextBox.Size = new System.Drawing.Size(262, 77);
            this.HistoryTextBox.TabIndex = 6;
            // 
            // MaleCombo
            // 
            this.MaleCombo.BeforeTouchSize = new System.Drawing.Size(73, 31);
            this.MaleCombo.Location = new System.Drawing.Point(217, 170);
            this.MaleCombo.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.MaleCombo.Name = "MaleCombo";
            this.MaleCombo.Size = new System.Drawing.Size(73, 31);
            this.MaleCombo.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.MaleCombo.TabIndex = 4;
            this.MaleCombo.Text = "Male";
            this.MaleCombo.ThemesEnabled = true;
            // 
            // FemaleCombo
            // 
            this.FemaleCombo.BeforeTouchSize = new System.Drawing.Size(70, 39);
            this.FemaleCombo.Location = new System.Drawing.Point(289, 165);
            this.FemaleCombo.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.FemaleCombo.Name = "FemaleCombo";
            this.FemaleCombo.Size = new System.Drawing.Size(70, 39);
            this.FemaleCombo.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.FemaleCombo.TabIndex = 5;
            this.FemaleCombo.Text = "Female";
            this.FemaleCombo.ThemesEnabled = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "History :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // ShowData
            // 
            this.ShowData.AllowUserToAddRows = false;
            this.ShowData.AllowUserToOrderColumns = true;
            this.ShowData.AllowUserToResizeColumns = false;
            this.ShowData.AllowUserToResizeRows = false;
            this.ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowData.Location = new System.Drawing.Point(195, 45);
            this.ShowData.MultiSelect = false;
            this.ShowData.Name = "ShowData";
            this.ShowData.ReadOnly = true;
            this.ShowData.RowHeadersWidth = 55;
            this.ShowData.RowTemplate.Height = 25;
            this.ShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowData.Size = new System.Drawing.Size(376, 332);
            this.ShowData.TabIndex = 5;
            this.ShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowData_CellClick);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.AutoEllipsis = true;
            this.buttonAdv1.BackColor = System.Drawing.Color.Maroon;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(94, 43);
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Raised;
            this.buttonAdv1.EnableTouchMode = true;
            this.buttonAdv1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.buttonAdv1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Image = global::Clinisis.Properties.Resources.if_Green_pin_132084;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(164, 324);
            this.buttonAdv1.MetroColor = System.Drawing.Color.Blue;
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(169, 51);
            this.buttonAdv1.TabIndex = 7;
            this.buttonAdv1.Text = "Save Patient Details";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv1.UseVisualStyle = false;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AgeTextBox.BeforeTouchSize = new System.Drawing.Size(251, 20);
            this.AgeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.AgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeTextBox.CornerRadius = 5;
            this.AgeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AgeTextBox.FarImage = global::Clinisis.Properties.Resources.age;
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.Location = new System.Drawing.Point(116, 170);
            this.AgeTextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.AgeTextBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(89, 31);
            this.AgeTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.AgeTextBox.TabIndex = 3;
            this.AgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeTextBox_KeyPress);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PhoneTextBox.BeforeTouchSize = new System.Drawing.Size(251, 20);
            this.PhoneTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTextBox.CornerRadius = 5;
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PhoneTextBox.FarImage = global::Clinisis.Properties.Resources.if_device_iPhone_smartphone_vertical_glyph_763248;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(114, 122);
            this.PhoneTextBox.MaxLength = 10;
            this.PhoneTextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PhoneTextBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(263, 31);
            this.PhoneTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.PhoneTextBox.TabIndex = 2;
            this.PhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddressTextBox.BeforeTouchSize = new System.Drawing.Size(251, 20);
            this.AddressTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressTextBox.CornerRadius = 5;
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddressTextBox.FarImage = global::Clinisis.Properties.Resources.if_address4_216563;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(114, 76);
            this.AddressTextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.AddressTextBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(263, 31);
            this.AddressTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.AddressTextBox.TabIndex = 1;
            this.AddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NameTextBox.BeforeTouchSize = new System.Drawing.Size(251, 20);
            this.NameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.CornerRadius = 5;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameTextBox.FarImage = global::Clinisis.Properties.Resources.if_10_1173385;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(114, 31);
            this.NameTextBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.NameTextBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(263, 31);
            this.NameTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.NameTextBox.TabIndex = 0;
            // 
            // Addpatient
            // 
            this.Addpatient.Image = global::Clinisis.Properties.Resources.if_edit_add_1950;
            this.Addpatient.Location = new System.Drawing.Point(577, 8);
            this.Addpatient.Name = "Addpatient";
            this.Addpatient.Size = new System.Drawing.Size(35, 31);
            this.Addpatient.TabIndex = 3;
            this.Addpatient.TabStop = false;
            this.Addpatient.Click += new System.EventHandler(this.Addpatient_Click);
            // 
            // PatientNameSearchBox
            // 
            this.PatientNameSearchBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatientNameSearchBox.BeforeTouchSize = new System.Drawing.Size(251, 20);
            this.PatientNameSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PatientNameSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientNameSearchBox.CornerRadius = 5;
            this.PatientNameSearchBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PatientNameSearchBox.FarImage = global::Clinisis.Properties.Resources.if_search_173095;
            this.PatientNameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameSearchBox.Location = new System.Drawing.Point(308, 9);
            this.PatientNameSearchBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PatientNameSearchBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.PatientNameSearchBox.Name = "PatientNameSearchBox";
            this.PatientNameSearchBox.Size = new System.Drawing.Size(263, 31);
            this.PatientNameSearchBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.PatientNameSearchBox.TabIndex = 0;
            // 
            // MetroForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 387);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.AddPatientsPanel);
            this.Controls.Add(this.Addpatient);
            this.Controls.Add(this.PatientNameSearchBox);
            this.Controls.Add(this.autoLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MetroForm1";
            this.Text = "Add Patients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MetroForm1_FormClosed);
            this.Load += new System.EventHandler(this.MetroForm1_Load);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MetroForm1_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.AddPatientsPanel)).EndInit();
            this.AddPatientsPanel.ResumeLayout(false);
            this.AddPatientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaleCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemaleCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addpatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientNameSearchBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private System.Windows.Forms.PictureBox Addpatient;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PatientNameSearchBox;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt AddPatientsPanel;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox HistoryTextBox;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv MaleCombo;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv FemaleCombo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt AgeTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PhoneTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt AddressTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.DataGridView ShowData;
    }
}