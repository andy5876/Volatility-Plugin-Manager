
///////////////////////////////////////////////////////////////////////////////
/// Volatility Plugin Manager 1.0                                           ///                      
/// Copyright (C) 2014  Andrew Nind                                         ///
///                                                                         ///
/// This program is free software; you can redistribute it and/or modify    ///
/// it under the terms of the GNU General Public License as published by    ///
/// the Free Software Foundation; either version 2 of the License, or       ///
/// (at your option) any later version.                                     ///
///                                                                         ///
/// This program is distributed in the hope that it will be useful,         ///
/// but WITHOUT ANY WARRANTY; without even the implied warranty of          ///
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the           ///
/// GNU General Public License for more details.                            ///
///                                                                         ///
/// You should have received a copy of the GNU General Public License along ///
/// with this program; if not, write to the Free Software Foundation, Inc., ///
/// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.             ///
///////////////////////////////////////////////////////////////////////////////
﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.DirectoryServices;
using System.Configuration;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography;


namespace volatility_GUI
{
    public partial class MainWindow : Form
    {
        // Declare Global Variables
        List<CheckBox> CheckBoxes = new List<CheckBox>();
        int ModulesSelected = 0;
        string vollocation = @"C:\Program Files (x86)\Lethal Forensics\VPM\Volatility.exe";
        
        public MainWindow()
        {
            InitializeComponent();

            foreach (Control con in this.Controls)
            // Iterate all controls on the form
            // If control is a checkbox add it to the CheckBoxes collection and
            // set its CheckedChanged event to the user defined handler below.
            {
                if (con is CheckBox)
                {
                    CheckBox c = con as CheckBox;
                    CheckBoxes.Add(c);
                    c.CheckedChanged += CheckBoxChanged;
                }
            }
        }

        private void CheckBoxChanged(object sender, EventArgs e)
        {
            // Event Handler which fires when the value of the checked property
            // changes.  Increments global count if checked otherwise decrements 
            // the value.
            CheckBox c = sender as CheckBox;
            if (c.Checked)
                ModulesSelected++;
            else
                ModulesSelected--;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.AutoPopDelay = 20000;
            tooltip1.InitialDelay = 500;
            tooltip1.ReshowDelay = 500;
            tooltip1.ShowAlways = true;
            tooltip1.SetToolTip(this.pidbox, "allows you to run a plugin against a specific set of pids (seperate pids by comma)");

            ToolTip tooltip2 = new ToolTip();
            tooltip2.AutoPopDelay = 30000;
            tooltip2.InitialDelay = 500;
            tooltip2.ReshowDelay = 500;
            tooltip2.ShowAlways = true;
            tooltip2.SetToolTip(this.profiletextbox, "the profile of the system that the image was taken from is required for all plugins other than 'imageinfo'. If the profile is unknown run 'imageinfo' first as the output created by this will tell you the profile");

            ToolTip tooltip3 = new ToolTip();
            tooltip3.AutoPopDelay = 30000;
            tooltip3.InitialDelay = 500;
            tooltip3.ReshowDelay = 500;
            tooltip3.ShowAlways = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            // Set the interval of the progress bar using the global value Modules Selected
            int progress = 0;
            int interval = 100 / ModulesSelected;
            backgroundWorker1.ReportProgress(progress);
            string imagefile = imagefiletextbox.Text;
            string output = outputtextbox.Text;
            



            ////ERROR HANDLING STARTS these lines make sure that the output and image file boxes are filled in. it also creates the chosen output directory if it does not already exist////
            if (outputtextbox.Text == "")
            {
                MessageBox.Show("Please select an output directory");
                outputtextbox.BackColor = Color.LightPink;
                return;
            }

            if (!Directory.Exists(outputtextbox.Text)) Directory.CreateDirectory(outputtextbox.Text);


            if (!Directory.Exists(outputtextbox.Text))
            {
                MessageBox.Show("Invalid output location");
                outputtextbox.BackColor = Color.LightPink;
                return;
            }

            if (!File.Exists(imagefiletextbox.Text))
            {
                MessageBox.Show("Invalid image file");
                imagefiletextbox.BackColor = Color.LightPink;
                return;
            }

            TextBox.CheckForIllegalCrossThreadCalls = false;
            //// this returns the textbox colours back to black if they have been made pink due to an error
            outputtextbox.BackColor = Color.Black;
            imagefiletextbox.BackColor = Color.Black;
            ////by disabling the button until the backgroundworker completes it's process it will prevent the user attempting to run a second process
            btnRun.Enabled = false;
            backgroundWorker1.ReportProgress(progress);


            //////////////////////////////////////////////////////////////
            //////PROCESS OF RUNNING THE SELECTED PLUGINS STARTS HERE/////
            /////////////////////////////////////////////////////////////

            foreach (CheckBox c in CheckBoxes)
            {
                if (c.Checked == true)
                {
                    if (backgroundWorker1.CancellationPending)  /// checks to see if the background worker has been cancelled (cancel button) code dotted around usually before or after each plugin process.
                    {
                        e.Cancel = true;
                        return;
                    }
                    progress = progress + interval; ///Increases the progress variable used for progress bar by the increment(interval) calculated earlier on in the code.
                    RunPlugin(c.Tag, imagefile, output); // Run the plugin
                    backgroundWorker1.ReportProgress(progress); // Update the progress bar
                }
            }
            btnRun.Enabled = true;
            progresslabel.Text = "progress.... 100%";
            progressBar1.Value = 100;
            progresstext.Text += "COMPLETE!";
            
        }

        private void RunPlugin(object Tag, string imagefile, string output)
        {
            string commandlineargs;
            string[] tags = Tag.ToString().Split(',');
            string PluginName = tags[0];
            string profile = profiletextbox.Text;
            
            

            if (tags.Contains("DIR"))
            {
                if (tags.Contains("PID") && pidbox.Text !="")
                {
                    Directory.CreateDirectory(output + "\\" + PluginName + "-PID-" + pidbox.Text);
                    commandlineargs = "-f" + " " + imagefile + " " + "--profile=" + profile + " " + PluginName + " " + "-D" + " " + output + @"\" + PluginName + "-PID-" + pidbox.Text + " " + "--output-file=" + output + @"\" + PluginName + "-PID-" + pidbox.Text + @".txt";
                }
                else
                {
                    Directory.CreateDirectory(output + "\\" + PluginName);
                    commandlineargs = "-f " + " " + imagefile + " " + " --profile=" + profile + " " + PluginName + " " + "-D" + " " + output + @"\" + PluginName + " " + "--output-file=" + output +  @"\" + PluginName + @".txt";
                }
                
            }
            else
                if (tags.Contains("PID") && pidbox.Text != "")
                {
                    commandlineargs = "-f " + " " + imagefile + " " + "--profile=" + profile + " " + PluginName + " " + "--output-file=" + output + @"\" + PluginName + "-PID-" + pidbox.Text + @".txt";
                }
                else
                {
                    commandlineargs = "-f " + " " + imagefile + " " + "--profile=" + profile + " " + PluginName + " " + "--output-file=" + output + @"\" + PluginName + @".txt";
                }
            
            if (tags.Contains("PID") && pidbox.Text != "")
            {
                commandlineargs += " -p " + pidbox.Text;
            }

            if (tags.Contains("imageinfo"))
            {
                commandlineargs = "-f" + " " + imagefile + " " + PluginName + " " + "--output-file" + " " + output + @"\" + PluginName + @".txt";
            }

            if (progresstext.Text == "")
            {
                progresstext.Text += "running" + " " + "the" + " " + PluginName + " plugin" + "...\r\n" + "Please be patient...\r\n";
                
            }
            else
            {
                progresstext.Text += "running" + " the" + " " + PluginName +  " plugin" + "...\r\n";
                progresstext.ScrollToCaret();
            }
             
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = vollocation;
            startInfo.Arguments = commandlineargs;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            process.Close();

            
            if (tags.Contains("PID") && pidbox.Text !="")
            {
                var tempfile = Path.GetTempFileName();
                using (var writer = new StreamWriter(tempfile))
                using (var reader = new StreamReader(output + @"\" + PluginName + "-PID-" + pidbox.Text + @".txt"))
                {
                    writer.WriteLine("VOLATILITY PLUGIN MANAGER 1.1");
                    writer.WriteLine(DateTime.Now);
                    writer.WriteLine("Analyst Logon:" + " " + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                    writer.WriteLine("Volatility Command:" + " " + commandlineargs);
                    writer.WriteLine("   ");
                    writer.WriteLine("   ");
                    while (!reader.EndOfStream)
                        writer.WriteLine(reader.ReadLine());
                }
                File.Copy(tempfile, output + @"\" + PluginName + "-PID-" + pidbox.Text + @".txt", true);
                File.Delete(tempfile);
            }
            else
            {
                var tempfile = Path.GetTempFileName();
                using (var writer = new StreamWriter(tempfile))
                using (var reader = new StreamReader(output + @"\" + PluginName + @".txt"))
                {
                    writer.WriteLine("VOLATILITY PLUGIN MANAGER 1.1");
                    writer.WriteLine(DateTime.Now);
                    writer.WriteLine("Analyst Logon:" + " " + System.Security.Principal.WindowsIdentity.GetCurrent().Name);
                    writer.WriteLine("Volatility Command:" + " " + commandlineargs);
                    writer.WriteLine("   ");
                    writer.WriteLine("   ");
                    while (!reader.EndOfStream)
                    writer.WriteLine(reader.ReadLine());
                }
                File.Copy(tempfile, output + @"\" + PluginName + @".txt", true);
                File.Delete(tempfile);
                progresstext.Text += PluginName + " " + "complete" + "...\r\n";
                progresstext.ScrollToCaret();
                
            }


            
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            progresstext.Text = "";
            backgroundWorker1.RunWorkerAsync(); ///sets the background worker running once all the error checks have run
        }

        private void imagenavigate_Click(object sender, EventArgs e)
        {
            /// this brings up a file explorer window for the user to select the location of the image file, this chosen file is then
            /// placed into the imagefile selection box.
            navigateimage.ShowDialog();
            imagefiletextbox.Text = navigateimage.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /// this brings up a file explorer window for the user to select the output directory, this chosen file is then
            /// placed into the output directory selection.
            navigateoutput.ShowDialog();
            outputtextbox.Text = navigateoutput.SelectedPath;
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ///sets the progress bar value as a percentage based on the "progress" variable
            progressBar1.Value = e.ProgressPercentage;
            progresslabel.Text = "progress...." + e.ProgressPercentage.ToString() + "%";
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {

            /// cancel button cancels the background worker, changes the progress label to cancelled and value to 100% and re-enables the run plugin button
            backgroundWorker1.CancelAsync();
            progresslabel.Text = "Cancelled";
            progressBar1.Value = 100;
            btnRun.Enabled = true;
            return;

        }

        private void profiletextbox_TextChanged(object sender, EventArgs e)
        {
            foreach(CheckBox c in CheckBoxes)
            {
                if (c.Name != "imageinfo")
                    if (profiletextbox.Text == "")
                        c.Enabled = false;
                    else
                        c.Enabled = true;
            }
        }

        private void connsandsocks_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void memdump_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progresstext_TextChanged(object sender, EventArgs e)
        {
            progresstext.SelectionStart = progresstext.Text.Length;
            progresstext.ScrollToCaret();
        }

    }
}
        

        
    

