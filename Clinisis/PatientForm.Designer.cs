#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Clinisis
{
    partial class PatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ShowData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEntryTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientDBDataSet = new Clinisis.PatientDBDataSet();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.PatientNameSearchBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutStandingLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.History = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.HistoryTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ShowHistoryVisit = new MetroFramework.Controls.MetroGrid();
            this.ReportTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.Add = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SelectedReportShowLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Addpatient = new System.Windows.Forms.PictureBox();
            this.DTitleBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.ActionTab = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.patientEntryTableTableAdapter = new Clinisis.PatientDBDataSetTableAdapters.PatientEntryTableTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.HistoryBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.genderla = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.patientEntryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientEntryTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientNameSearchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).BeginInit();
            this.gradientPanelExt1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.History)).BeginInit();
            this.History.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHistoryVisit)).BeginInit();
            this.ReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addpatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTitleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientEntryTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowData
            // 
            this.ShowData.AllowUserToAddRows = false;
            this.ShowData.AllowUserToDeleteRows = false;
            this.ShowData.AllowUserToOrderColumns = true;
            this.ShowData.AllowUserToResizeColumns = false;
            this.ShowData.AllowUserToResizeRows = false;
            this.ShowData.AutoGenerateColumns = false;
            this.ShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn});
            this.ShowData.DataSource = this.patientEntryTableBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowData.DefaultCellStyle = dataGridViewCellStyle2;
            this.ShowData.Location = new System.Drawing.Point(13, 64);
            this.ShowData.MultiSelect = false;
            this.ShowData.Name = "ShowData";
            this.ShowData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ShowData.RowHeadersWidth = 25;
            this.ShowData.RowTemplate.Height = 20;
            this.ShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowData.Size = new System.Drawing.Size(426, 409);
            this.ShowData.TabIndex = 9;
            this.ShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowData_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 30.45685F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 123.181F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.FillWeight = 123.181F;
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.FillWeight = 123.181F;
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "Phone No";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientEntryTableBindingSource1
            // 
            this.patientEntryTableBindingSource1.DataMember = "PatientEntryTable";
            this.patientEntryTableBindingSource1.DataSource = this.patientDBDataSet;
            // 
            // patientDBDataSet
            // 
            this.patientDBDataSet.DataSetName = "PatientDBDataSet";
            this.patientDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.Location = new System.Drawing.Point(13, -1);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(167, 25);
            this.autoLabel1.TabIndex = 7;
            this.autoLabel1.Text = "Patient Search";
            // 
            // PatientNameSearchBox
            // 
            this.PatientNameSearchBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatientNameSearchBox.BeforeTouchSize = new System.Drawing.Size(267, 61);
            this.PatientNameSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PatientNameSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatientNameSearchBox.CornerRadius = 5;
            this.PatientNameSearchBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PatientNameSearchBox.FarImage = global::Clinisis.Properties.Resources.if_search_173095;
            this.PatientNameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameSearchBox.Location = new System.Drawing.Point(13, 27);
            this.PatientNameSearchBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.PatientNameSearchBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.PatientNameSearchBox.Name = "PatientNameSearchBox";
            this.PatientNameSearchBox.Size = new System.Drawing.Size(230, 31);
            this.PatientNameSearchBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.PatientNameSearchBox.TabIndex = 6;
            this.PatientNameSearchBox.TextChanged += new System.EventHandler(this.PatientNameSearchBox_TextChanged);
            // 
            // gradientPanelExt1
            // 
            this.gradientPanelExt1.BackColor = System.Drawing.Color.Beige;
            this.gradientPanelExt1.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt1.Controls.Add(this.panel1);
            this.gradientPanelExt1.Controls.Add(this.History);
            this.gradientPanelExt1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanelExt1.Location = new System.Drawing.Point(642, 0);
            this.gradientPanelExt1.Name = "gradientPanelExt1";
            this.gradientPanelExt1.Padding = new System.Windows.Forms.Padding(15, 15, 15, 22);
            this.gradientPanelExt1.Size = new System.Drawing.Size(468, 485);
            this.gradientPanelExt1.TabIndex = 10;
            this.gradientPanelExt1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanelExt1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HistoryBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.WeightLabel);
            this.panel1.Controls.Add(this.OutStandingLabel);
            this.panel1.Controls.Add(this.genderla);
            this.panel1.Controls.Add(this.AgeLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(17, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 99);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "OutStanding :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // OutStandingLabel
            // 
            this.OutStandingLabel.AutoSize = true;
            this.OutStandingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutStandingLabel.Location = new System.Drawing.Point(96, 80);
            this.OutStandingLabel.Name = "OutStandingLabel";
            this.OutStandingLabel.Size = new System.Drawing.Size(41, 13);
            this.OutStandingLabel.TabIndex = 0;
            this.OutStandingLabel.Text = "label1";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(96, 26);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(41, 13);
            this.AgeLabel.TabIndex = 0;
            this.AgeLabel.Text = "label1";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(96, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "label1";
            // 
            // History
            // 
            this.History.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.History.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.History.BeforeTouchSize = new System.Drawing.Size(431, 338);
            this.History.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.History.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.History.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.History.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.History.Controls.Add(this.HistoryTab);
            this.History.Controls.Add(this.ReportTab);
            this.History.Controls.Add(this.ActionTab);
            this.History.FocusOnTabClick = false;
            this.History.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.History.Location = new System.Drawing.Point(19, 125);
            this.History.Name = "History";
            this.History.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.History.ShowSeparator = false;
            this.History.Size = new System.Drawing.Size(431, 338);
            this.History.TabIndex = 0;
            this.History.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode);
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.ShowHistoryVisit);
            this.HistoryTab.Image = null;
            this.HistoryTab.ImageSize = new System.Drawing.Size(16, 16);
            this.HistoryTab.Location = new System.Drawing.Point(0, 24);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.ShowCloseButton = true;
            this.HistoryTab.Size = new System.Drawing.Size(431, 314);
            this.HistoryTab.TabIndex = 1;
            this.HistoryTab.Text = "History";
            this.HistoryTab.ThemesEnabled = false;
            // 
            // ShowHistoryVisit
            // 
            this.ShowHistoryVisit.AllowUserToResizeColumns = false;
            this.ShowHistoryVisit.AllowUserToResizeRows = false;
            this.ShowHistoryVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShowHistoryVisit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ShowHistoryVisit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ShowHistoryVisit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowHistoryVisit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowHistoryVisit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ShowHistoryVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ShowHistoryVisit.DefaultCellStyle = dataGridViewCellStyle5;
            this.ShowHistoryVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowHistoryVisit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ShowHistoryVisit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ShowHistoryVisit.Location = new System.Drawing.Point(0, 0);
            this.ShowHistoryVisit.Name = "ShowHistoryVisit";
            this.ShowHistoryVisit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ShowHistoryVisit.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ShowHistoryVisit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ShowHistoryVisit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowHistoryVisit.Size = new System.Drawing.Size(431, 314);
            this.ShowHistoryVisit.TabIndex = 0;
            // 
            // ReportTab
            // 
            this.ReportTab.Controls.Add(this.Add);
            this.ReportTab.Controls.Add(this.SelectedReportShowLabel);
            this.ReportTab.Controls.Add(this.label6);
            this.ReportTab.Controls.Add(this.Addpatient);
            this.ReportTab.Controls.Add(this.DTitleBox);
            this.ReportTab.Controls.Add(this.label5);
            this.ReportTab.Image = null;
            this.ReportTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ReportTab.Location = new System.Drawing.Point(0, -1);
            this.ReportTab.Name = "ReportTab";
            this.ReportTab.ShowCloseButton = true;
            this.ReportTab.Size = new System.Drawing.Size(431, 339);
            this.ReportTab.TabIndex = 2;
            this.ReportTab.Text = "Report";
            this.ReportTab.ThemesEnabled = false;
            this.ReportTab.Click += new System.EventHandler(this.ReportTab_Click);
            // 
            // Add
            // 
            this.Add.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Add.BackColor = System.Drawing.Color.Black;
            this.Add.BeforeTouchSize = new System.Drawing.Size(148, 38);
            this.Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.IsBackStageButton = false;
            this.Add.Location = new System.Drawing.Point(151, 271);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(148, 38);
            this.Add.TabIndex = 7;
            this.Add.Text = "Upload Reports";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectedReportShowLabel
            // 
            this.SelectedReportShowLabel.AutoSize = true;
            this.SelectedReportShowLabel.Location = new System.Drawing.Point(18, 126);
            this.SelectedReportShowLabel.Name = "SelectedReportShowLabel";
            this.SelectedReportShowLabel.Size = new System.Drawing.Size(0, 13);
            this.SelectedReportShowLabel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Selected Reports  :";
            // 
            // Addpatient
            // 
            //this.Addpatient.Image = global::Clinisis.Properties.Resources.if_icon_person_add_211872;
            this.Addpatient.Location = new System.Drawing.Point(298, 216);
            this.Addpatient.Name = "Addpatient";
            this.Addpatient.Size = new System.Drawing.Size(35, 31);
            this.Addpatient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Addpatient.TabIndex = 4;
            this.Addpatient.TabStop = false;
            this.Addpatient.Click += new System.EventHandler(this.Addpatient_Click);
            // 
            // DTitleBox
            // 
            this.DTitleBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DTitleBox.BeforeTouchSize = new System.Drawing.Size(267, 61);
            this.DTitleBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DTitleBox.CornerRadius = 5;
            this.DTitleBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DTitleBox.FarImage = global::Clinisis.Properties.Resources.if_address4_216563;
            this.DTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTitleBox.Location = new System.Drawing.Point(44, 221);
            this.DTitleBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.DTitleBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.DTitleBox.Name = "DTitleBox";
            this.DTitleBox.Size = new System.Drawing.Size(245, 20);
            this.DTitleBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.DTitleBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description";
            // 
            // ActionTab
            // 
            this.ActionTab.Image = null;
            this.ActionTab.ImageSize = new System.Drawing.Size(16, 16);
            this.ActionTab.Location = new System.Drawing.Point(0, -1);
            this.ActionTab.Name = "ActionTab";
            this.ActionTab.ShowCloseButton = true;
            this.ActionTab.Size = new System.Drawing.Size(431, 339);
            this.ActionTab.TabIndex = 3;
            this.ActionTab.Text = "Action";
            this.ActionTab.ThemesEnabled = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // patientEntryTableTableAdapter
            // 
            this.patientEntryTableTableAdapter.ClearBeforeFill = true;
            // 
            // HistoryBox
            // 
            this.HistoryBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.HistoryBox.BeforeTouchSize = new System.Drawing.Size(267, 61);
            this.HistoryBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.HistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryBox.CornerRadius = 5;
            this.HistoryBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HistoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBox.Location = new System.Drawing.Point(161, 29);
            this.HistoryBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.HistoryBox.MinimumSize = new System.Drawing.Size(14, 10);
            this.HistoryBox.Multiline = true;
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(267, 61);
            this.HistoryBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.HistoryBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "History :";
            // 
            // genderla
            // 
            this.genderla.AutoSize = true;
            this.genderla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderla.Location = new System.Drawing.Point(96, 44);
            this.genderla.Name = "genderla";
            this.genderla.Size = new System.Drawing.Size(41, 13);
            this.genderla.TabIndex = 0;
            this.genderla.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gender  :";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(96, 62);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 0;
            this.WeightLabel.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Weight :";
            // 
            // patientEntryTableBindingSource
            // 
            this.patientEntryTableBindingSource.DataSource = typeof(Clinisis.PatientEntryTable);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 485);
            this.Controls.Add(this.gradientPanelExt1);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.PatientNameSearchBox);
            this.Controls.Add(this.autoLabel1);
            this.Name = "PatientForm";
            this.Text = "MetroForm1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientForm_FormClosed);
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientEntryTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientNameSearchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).EndInit();
            this.gradientPanelExt1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.History)).EndInit();
            this.History.ResumeLayout(false);
            this.HistoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowHistoryVisit)).EndInit();
            this.ReportTab.ResumeLayout(false);
            this.ReportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Addpatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTitleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientEntryTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowData;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PatientNameSearchBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OutStandingLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv History;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv HistoryTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv ReportTab;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv ActionTab;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DTitleBox;
        private System.Windows.Forms.Label SelectedReportShowLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Addpatient;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Syncfusion.Windows.Forms.ButtonAdv Add;
        private System.Windows.Forms.BindingSource patientEntryTableBindingSource;
        private PatientDBDataSet patientDBDataSet;
        private System.Windows.Forms.BindingSource patientEntryTableBindingSource1;
        private PatientDBDataSetTableAdapters.PatientEntryTableTableAdapter patientEntryTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private MetroFramework.Controls.MetroGrid ShowHistoryVisit;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt HistoryBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label genderla;
        private System.Windows.Forms.Label WeightLabel;
    }
}