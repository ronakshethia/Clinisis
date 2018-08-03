using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinisis
{
    public partial class MasterForm : MetroForm
    {
        MetroForm1 ff;
        PatientForm pf;
        ConsolidatedPaymentForm cpf;
        public MasterForm()
        {
            InitializeComponent();
        }

        private void quickAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MetroForm1.isOpen == false)
            {
                ff = new MetroForm1();
                ff.MdiParent = this;
                ff.Dock = DockStyle.Fill;
                ff.Show();
            }
            else
            {
                ff.BringToFront();
            }
        }

        private void patientBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (PatientForm.isOpen == false)
            {
                pf = new PatientForm();
                pf.MdiParent = this;
                pf.Dock = DockStyle.Fill;
                pf.Show();
            }
            else
            {
                pf.BringToFront();
            }

        }

        private void consolidatedPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConsolidatedPaymentForm.isOpen == false)
            {
                cpf = new ConsolidatedPaymentForm();
                cpf.MdiParent = this;
                cpf.Dock = DockStyle.Fill;
                cpf.Show();
            }
            else
            {
                cpf.BringToFront();
            }

        }
    }
    }

