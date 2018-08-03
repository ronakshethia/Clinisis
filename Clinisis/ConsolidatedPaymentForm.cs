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
    public partial class ConsolidatedPaymentForm : MetroForm
    {
        public static bool isOpen = false;
        public ConsolidatedPaymentForm()
        {
            InitializeComponent();
            isOpen = true;
        }

        private void ConsolidatedPaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }
    }
}
