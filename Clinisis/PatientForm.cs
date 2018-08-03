#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinisis
{
    public partial class PatientForm : Syncfusion.Windows.Forms.MetroForm
    {
        public static bool isOpen = false;
        PatientDBEntities PDE;
        PatientEntryTable PET;


        public PatientForm()
        {
            InitializeComponent();
            isOpen = true;



        }

        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void Addpatient_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            SelectedReportShowLabel.Text = openFileDialog1.SafeFileName;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDBDataSet.PatientEntryTable' table. You can move, or remove it, as needed.
            this.patientEntryTableTableAdapter.Fill(this.patientDBDataSet.PatientEntryTable);

        }

        
        private void PatientNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            PDE = new PatientDBEntities();
            PET = new PatientEntryTable();
         
            if (PatientNameSearchBox.Text != "")
            {
                var sele = PDE.PatientEntryTable.Where(x => x.Name.ToUpper().Contains(PatientNameSearchBox.Text.ToUpper())).OrderBy(a=>a.Name);
                ShowData.DataSource = sele.ToList();
            }
            else
            {
                var dd = PDE.PatientEntryTable.Select(a => new { id = a.id, Name = a.Name, Gender = a.Gender, PhoneNo = a.PhoneNo });
                ShowData.DataSource = dd.ToList();

            }


        }

        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PDE = new PatientDBEntities();
            PET = new PatientEntryTable();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ShowData.Rows[e.RowIndex];
                string t = row.Cells[0].Value.ToString();
                int z = int.Parse(t);
                string r = row.Cells[3].Value.ToString();
                var getdetails = PDE.PatientEntryTable.FirstOrDefault(x=>x.id==z);
                bindingSource1.DataSource = getdetails;
                //     ShowHistoryGrid.DataSource = bindingSource1[4];

                // var dd = PDE.PatientEntryTable.Where(a=>a.id ==z).Select(a => new { History = a.History }).ToList();
                long balance=0;
                var dd = PDE.PatientEntryTable.Where(a => a.id == z).Select(a=>new { Name=a.Name,a.Age,a.History,a.Gender,a.Address }).FirstOrDefault();
                NameLabel.Text = dd.Name;
                AgeLabel.Text = dd.Age;
                genderla.Text = dd.Gender;
                WeightLabel.Text = dd.Address;
                HistoryBox.Text = dd.History;
            

                var dk = PDE.CollectionTable.Where(a => a.id == z).Select(a=>new { Outstanding = a.Outstanding }).ToList();
                foreach(var bal in dk)
                {
                    balance = balance + bal.Outstanding;
                    if(balance<=0)
                    {
                        OutStandingLabel.Text = balance.ToString();
                    }
                    else
                    {
                        OutStandingLabel.Text = "0";

                    }
                }
                var de = PDE.CollectionTable.Where(a => a.id == z).Select(a=>new {Date=a.Date , Rx=a.Rx, Treatment=a.Treatment }).ToList();
               
                // bindingSource1.DataSource = dd;
                //  ShowHistoryGrid.DataSource = bindingSource1;
                //  ShowHistoryGrid.DataSource = dd;
                
                ShowHistoryVisit.DataSource = de;
            }

            

        }

        private void ShowHistoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gradientPanelExt1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReportTab_Click(object sender, EventArgs e)
        {

        }
    }
}
