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

//using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Clinisis
{
    public partial class MetroForm1 : Syncfusion.Windows.Forms.MetroForm
    {
        public static bool isOpen = false;
        private String connectionString;
        private String connectionString1;
        private SQLiteConnection connection;
        private SQLiteConnection connection1;
        DataTable dt;
        SQLiteDataReader reader;
        SQLiteConnection mConn;

        public MetroForm1()
        {
            InitializeComponent();

            isOpen = true;
            string folderName = @"E:\Database";
            System.IO.Directory.CreateDirectory(folderName);
            //     var pathArray = path.Split(new[] { "\\" }, StringSplitOptions.None);
            //     var a = System.IO.Path.Combine(pathArray);
            //     a = System.IO.Path.Combine(a, "PatientDB.db3");

            //System.Data.SQLite.SQLiteConnection.CreateFile(a);  //"'" + path + "'/PatientDB.db3"



            System.Data.SQLite.SQLiteConnection.CreateFile("entDB.db3");
            System.Data.SQLite.SQLiteConnection.CreateFile("E:/Database/PatientDB.db3");
            System.Data.SQLite.SQLiteConnection.CreateFile("E:/Database/DiagnosticData.db3");//"'" + path + "' /PatientDB.db3"

            connectionString = "Data Source=E:\\Database\\PatientDB.db;New=False;Compress=True;";
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            using (SQLiteCommand mCmd = new SQLiteCommand("create table if not exists [PatientEntryTable](id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 'Name' Text, 'Age' Text,'Address' Text,'PhoneNo' Text,'Gender' Text,'History' Text);", connection))
            {
                mCmd.ExecuteNonQuery();
            }
            connection.Close();

            connectionString1 = "Data Source=E:\\Database\\DiagnosticData.db;New=False;Compress=True;";
            connection1 = new SQLiteConnection(connectionString1);
            connection1.Open();
            using (SQLiteCommand mmCmd = new SQLiteCommand("create table if not exists [DiagnoTable](Did INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 'DTitle' Text, 'Description' Text);", connection1))
            {
                mmCmd.ExecuteNonQuery();
            }
            connection1.Close();


        }

        private void MetroForm1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void MetroForm1_Load(object sender, EventArgs e)
        {

            LoadRecords();

        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Addpatient_Click(object sender, EventArgs e)
        {
            if (AddPatientsPanel.Visible == false)
            {
                AddPatientsPanel.Visible = true;
            }
            else
            {
                AddPatientsPanel.Visible = false;

            }

        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            PatientDBEntities pd = new PatientDBEntities();     
            PatientEntryTable pe = new PatientEntryTable();
            if (NameTextBox.Text!="" && PhoneTextBox.Text!="" && AgeTextBox.Text!="" && HistoryTextBox.Text!="" && AddressTextBox.Text!="")
            {
                pe.Name = NameTextBox.Text;
                pe.PhoneNo = PhoneTextBox.Text;
                pe.Age = AgeTextBox.Text;
                pe.Gender = "Male";
                pe.History = HistoryTextBox.Text;
                pe.Address = AddressTextBox.Text;
                pd.PatientEntryTable.Add(pe);
                pd.SaveChanges();
                MessageBox.Show("Saved");
                AddPatientsPanel.Visible = false;

                var dd = pd.PatientEntryTable.Select(a => new { Name = a.Name, PhoneNo = a.PhoneNo, History = a.History, id = a.id, });
                ShowData.DataSource = dd.ToList();
            }
         else
            {
                MessageBox.Show("No Data To Save..","Alert");
            }

            //LoadRecords();

        }


        void ClearMethod()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            AddressTextBox.Clear();
            PhoneTextBox.Clear();
            HistoryTextBox.Clear();

        }

        void LoadRecords()
        {

            connection.Open();
            SQLiteCommand smd = new SQLiteCommand("select Name,PhoneNo,History,id from PatientEntryTable", connection);
            SQLiteDataAdapter read = new SQLiteDataAdapter(smd);
            reader = smd.ExecuteReader();
            if (reader.HasRows)
            {

                dt = new DataTable();
                dt.Load(reader);
                ShowData.DataSource = dt;
            }
            connection.Close();

        }

        private void ShowData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddPatientsPanel.Visible = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ShowData.Rows[e.RowIndex];
                string t = row.Cells[0].Value.ToString();
                string r = row.Cells[3].Value.ToString();
                AppointMentEntry pe = new AppointMentEntry(t,r);
                pe.Location = new Point(720,0);
                pe.ShowDialog();

            }
            

        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppointMentEntry d = new AppointMentEntry();
            d.NumbericMethod(sender,e);
        }

        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppointMentEntry d = new AppointMentEntry();
            d.NumbericMethod(sender, e);
        }

        private void MetroForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }
    }
}
