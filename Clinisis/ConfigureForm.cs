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

using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Resources;
using System.Linq;
using System.Collections;

namespace Clinisis
{
    public partial class ConfigureForm : Syncfusion.Windows.Forms.MetroForm
    {
       
        public ConfigureForm()
        {
            InitializeComponent();
         


        }

        private void ChooseDatabase_Click(object sender, EventArgs e)
        {
            folderBrowser1.ShowDialog();
            if(folderBrowser1.DirectoryPath!=null)
            {
                choo.Text = folderBrowser1.DirectoryPath;
                System.IO.File.WriteAllText(@"C:\Connection.txt", choo.Text);
                button2.Enabled = false;
            }
          
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName!=null)
            {
                res.Text = openFileDialog1.FileName;
                ChooseDatabase.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseDatabase.Enabled = true;
            button2.Enabled = true;
            openFileDialog1.FileName = null;
            choo.Text = "";
            res.Text = "";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
           string path =  Path.Combine(Environment.CurrentDirectory, "Connection.txt");
            System.IO.File.WriteAllText(path, folderBrowser1.DirectoryPath);
            this.Hide();
            MetroForm1 f = new MetroForm1();
            f.Show();

        }

        private void gradientPanelExt1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfigureForm_Load(object sender, EventArgs e)
        {

            

            //ResourceWriter rr = new ResourceWriter();

            //Assembly assem = this.GetType().Assembly;

        

            //using (Stream stream = assem.GetManifestResourceStream("Clinisis\\Resources\\Connection.txt"))
            //{
            //    StreamReader sreader = new StreamReader(stream);

            //    //Read the first line of text
            //    string ss = sreader.ReadLine();
            //}

        }

     

    }
}
