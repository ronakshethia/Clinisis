using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinisis
{
    public partial class AppointMentEntry : MetroForm
    {
       
        int id;



        public AppointMentEntry(string g,string t)
        {
            InitializeComponent();
            PName.Text = g;
            // connection1.Open();
            // showcombodetails();
            // connection1.Close();
           id = int.Parse(t);
        }

        public AppointMentEntry()
        {
            InitializeComponent();
           
        }

        private void AddMoreDetails_Load(object sender, EventArgs e)
        {
           
        }

        private void gradientPanelExt1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxExt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbericMethod(sender,e);
        }



      public  void NumbericMethod(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }
        }

        private void textBoxExt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbericMethod(sender, e);
        }

        private void OutStandingBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumbericMethod(sender, e);
        }

        private void AmountPaidBox_TextChanged(object sender, EventArgs e)
        {
            if (AmountPaidBox.Text != "" && FeeBox.Text != "")
            {
                OutStandingBox.Text = (double.Parse(AmountPaidBox.Text) - double.Parse(FeeBox.Text)).ToString();
            }
            else
            {
                OutStandingBox.Text = FeeBox.Text;
            }
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            PatientDBEntities PDE = new PatientDBEntities();
            PatientEntryTable PET = new PatientEntryTable();
            CollectionTable CT = new CollectionTable();
            if (TreatmentBox.Text!="" && RxBox.Text!="" && FeeBox.Text!="")
            {

                CT.Date = CurrentDateDisplay.Value.ToString();
                CT.Treatment = TreatmentBox.Text;
                CT.Rx = RxBox.Text;
                CT.id = id;
                CT.Fee = int.Parse(FeeBox.Text);
                CT.Outstanding = int.Parse(OutStandingBox.Text);

                PDE.CollectionTable.Add(CT);
                PDE.PatientEntryTable.Add(PET);
                PDE.SaveChanges();
                ClearBox();
            }
            else
            {
                MessageBox.Show("Some Details Are Unfilled","Alert");
            }
        }


        public void ClearBox()
        {
            RxBox.Clear();
            FeeBox.Clear();
            OutStandingBox.Clear();
            TreatmentBox.Clear();
            MessageBox.Show("Entry Added");
            this.Close();
        }
    }
}
