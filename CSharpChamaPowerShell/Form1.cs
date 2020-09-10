using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpChamaPowerShell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCallPowerShell_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process proc = new Process())
                {
                    string batDir = @"C:\app";

                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "testebat.bat";
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();
                    var exitCode = proc.ExitCode;
                    MessageBox.Show("Saída do programa " + exitCode);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

       
    }
}
