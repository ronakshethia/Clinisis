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
using System.Data.SQLite;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace Clinisis
{
    public partial class DiagnosticBox : Syncfusion.Windows.Forms.MetroForm
    {
        private String connectionString1;
        private SQLiteConnection connection1;
   
      
        public DiagnosticBox()
        {
            InitializeComponent();
            


        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            connection1.Open();
            SQLiteCommand smd = new SQLiteCommand("insert into DiagnoTable(DTitle,Description) values('" + DTitleBox.Text + "','" + DescriptionBox.Text + "')", connection1);
            //  SQLiteCommand smd = new SQLiteCommand("insert into PatientEntryTable(Name,Age,) values('jjfj','55')", connection)
            smd.ExecuteNonQuery();
            MessageBox.Show("Record Added");
            connection1.Close();
        }

        private void gradientPanelExt1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
