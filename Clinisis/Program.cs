using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinisis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "Clinisis.Resources.Connection.txt";
            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    string result = reader.ReadToEnd();
            //    if (result != "")
            //    {
            //        MessageBox.Show(result);
            //        Application.Run(new MetroForm1());

            //    }
            //    else
            //    {
            //        Application.Run(new ConfigureForm());

            //    }
            //}
            // Properties.Resources.con

         //   File.Create("Connectionn1.txt");

          //  File.Create(file);
         //   string path = Path.Combine(Environment.CurrentDirectory, "Connection1.txt");
           // File.ReadAllText("Connectionn1.txt");
        //    MessageBox.Show(File.ReadAllText("Connectionn1.txt"));

          //  MessageBox.Show(File.ReadAllText(path));
      //      if (File.ReadAllText(path) != "")
       //     {

                Application.Run(new MasterForm());
       //     }
       //     else
       //     {
        //        Application.Run(new ConfigureForm());
       //     }

        }
    }
}
