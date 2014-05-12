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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tooltip1 = new ToolTip();
            tooltip1.AutoPopDelay = 20000;
            tooltip1.InitialDelay = 500;
            tooltip1.ReshowDelay = 500;
            tooltip1.ShowAlways = true;
            tooltip1.SetToolTip(this.pidbox, "allows you to run a plugin against a specific set of pids works for dlllist, vadinfo, vaddump, memdump, handles, privs, getsids, envars, malfind and threads (seperate pids by comma)");

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




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

           

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
       
        
        {
            ///////This part of the code, works out how many checkboxes are checked in order to calculate the progress interval, 100 is then divided by the amount of checkboxes checked and this is added to the progress value each time a checked plugin is completed.
            var cbs = new List<CheckBox>();
  

            if(imageinfo.Checked == true)
            {
                cbs.Add(imageinfo);
            }

            else
            {
                cbs.Remove(imageinfo);
            }

            if (psscan.Checked == true)
            {
                cbs.Add(psscan);
            }

            else
            {
                cbs.Remove(psscan);
            }
            if (pslist.Checked == true)
            {
                cbs.Add(pslist);
            }

            else
            {
                cbs.Remove(pslist);
            }
            if (pstree.Checked == true)
            {
                cbs.Add(pstree);
            }

            else
            {
                cbs.Remove(pstree);
            }
            if (dlllist.Checked == true)
            {
                cbs.Add(dlllist);
            }

            else
            {
                cbs.Remove(dlllist);
            }
            if (connscan.Checked == true)
            {
                cbs.Add(connscan);
            }

            else
            {
                cbs.Remove(connscan);
            }
            if (sockscan.Checked == true)
            {
                cbs.Add(sockscan);
            }

            else
            {
                cbs.Remove(sockscan);
            }
            if (connsandsocks.Checked == true)
            {
                cbs.Add(connsandsocks);
            }

            else
            {
                cbs.Remove(connsandsocks);
            }
            if (netscan.Checked == true)
            {
                cbs.Add(netscan);
            }

            else
            {
                cbs.Remove(netscan);
            }
            if (modscan.Checked == true)
            {
                cbs.Add(modscan);
            }

            else
            {
                cbs.Remove(modscan);
            }
            if (cmdscan.Checked == true)
            {
                cbs.Add(cmdscan);
            }

            else
            {
                cbs.Remove(cmdscan);
            }
            if (svcscan.Checked == true)
            {
                cbs.Add(svcscan);
            }

            else
            {
                cbs.Remove(svcscan);
            }
            if (getsids.Checked == true)
            {
                cbs.Add(getsids);
            }

            else
            {
                cbs.Remove(getsids);
            }
            if (evtlogs.Checked == true)
            {
                cbs.Add(evtlogs);
            }

            else
            {
                cbs.Remove(evtlogs);
            }
            if (screenshot.Checked == true)
            {
                cbs.Add(screenshot);
            }

            else
            {
                cbs.Remove(screenshot);
            }
            if (userassist.Checked == true)
            {
                cbs.Add(userassist);
            }

            else
            {
                cbs.Remove(userassist);
            }
            if (shellbags.Checked == true)
            {
                cbs.Add(shellbags);
            }

            else
            {
                cbs.Remove(shellbags);
            }
            if (shimcache.Checked == true)
            {
                cbs.Add(shimcache);
            }

            else
            {
                cbs.Remove(shimcache);
            }
            if (sessions.Checked == true)
            {
                cbs.Add(sessions);
            }

            else
            {
                cbs.Remove(sessions);
            }
            if (vadinfo.Checked == true)
            {
                cbs.Add(vadinfo);
            }

            else
            {
                cbs.Remove(vadinfo);
            }
            if (vaddump.Checked == true)
            {
                cbs.Add(vaddump);
            }

            else
            {
                cbs.Remove(vaddump);
            }
            if (memdump.Checked == true)
            {
                cbs.Add(memdump);
            }

            else
            {
                cbs.Remove(memdump);
            }
            if (handles.Checked == true)
            {
                cbs.Add(handles);
            }

            else
            {
                cbs.Remove(handles);
            }
            if (privs.Checked == true)
            {
                cbs.Add(privs);
            }

            else
            {
                cbs.Remove(privs);
            }
            if (envars.Checked == true)
            {
                cbs.Add(envars);
            }

            else
            {
                cbs.Remove(envars);
            }
            if (threads.Checked == true)
            {
                cbs.Add(threads);
            }

            else
            {
                cbs.Remove(threads);
            }
            if (iehistory.Checked == true)
            {
                cbs.Add(iehistory);
            }

            else
            {
                cbs.Remove(iehistory);
            }
            if (malfind.Checked == true)
            {
                cbs.Add(malfind);
            }

            else
            {
                cbs.Remove(malfind);
            }

           


            int progress = 0;
            int interval = 100 / cbs.Count;
            backgroundWorker1.ReportProgress(progress);
            string imagefile = imagefiletextbox.Text;
            string vollocation = @"C:\Program Files (x86)\Lethal Forensics\VPM\Volatility.exe";
            string output = outputtextbox.Text;
            string profile = profiletextbox.Text;

            

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
            button1.Enabled = false;
            backgroundWorker1.ReportProgress(progress);


            //////////////////////////////////////////////////////////////
            //////PROCESS OF RUNNING THE SELECTED PLUGINS STARTS HERE/////
            /////////////////////////////////////////////////////////////


            if (imageinfo.Checked == true)
            {

                progress = progress + interval; ///Increases the progress variable used for progress bar by the increment(interval) calculated earlier on in the code.
                string commandlineargs = "-f " + imagefile + " imageinfo" + " --output-file=" + output + @"\imageinfo.txt";
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = vollocation;
                startInfo.Arguments = commandlineargs;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                process.Close();
               
            }
            

            {
                backgroundWorker1.ReportProgress(progress);
                if (psscan.Checked == true)
                {
                    if (backgroundWorker1.CancellationPending)  /// checks to see if the background worker has been cancelled (cancel button) code dotted around usually before or after each plugin process.
                    {
                        e.Cancel = true;
                        return;
                    }
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " psscan" + " --output-file=" + output + @"\psscan.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                     

                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                backgroundWorker1.ReportProgress(progress);
                if (pslist.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " pslist" + " --output-file=" + output + @"\pslist.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                   
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                backgroundWorker1.ReportProgress(progress);
                if (pstree.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " pstree" + " --output-file=" + output + @"\pstree.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    
                    
                }
                backgroundWorker1.ReportProgress(progress);
                if (dlllist.Checked == true)
                {
                    progress = progress + interval; // these plugins can operate with a -p argument, so this checks if the pidbox check is checked and if so adds in the pid or pids that are typed into the pid box. if it is not checked then it carries out the else argument in the code
                    if (pidcheck.Checked == true)
                    {
                        
                        backgroundWorker1.ReportProgress(progress);
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " dlllist" + " --output-file=" + output + @"\dlllist.txt" + " -p" + pidbox.Text;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                        }
                     else
                        {
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " dlllist" + " --output-file=" + output + @"\dlllist.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                   
                        }
                    }
                
                }
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            
            backgroundWorker1.ReportProgress(progress);
            if (connscan.Checked == true)
                
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " connscan" + " --output-file=" + output + @"\connscan.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                   
                  
                }
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
       
            backgroundWorker1.ReportProgress(progress);
                if (sockscan.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " sockscan" + " --output-file=" + output + @"\sockscan.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                  
                }
            if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
               
                backgroundWorker1.ReportProgress(progress);
                if (connsandsocks.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " connections and sockets" + " --output-file=" + output + @"\conns-and-socks-(active).txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                   
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (netscan.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " netscan" + " --output-file=" + output + @"\netscan.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                   
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (modscan.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " modscan" + " --output-file=" + output + @"\modscan.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                 
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (cmdscan.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " cmdscan" + " --output-file=" + output + @"\cmdscan.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                   
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (svcscan.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " svcscan" + " --output-file=" + output + @"\svcscan.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                  
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (getsids.Checked == true)
                {
                    progress = progress + interval;
                    if (pidcheck.Checked == true)
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " getsids" + " --output-file=" + output + @"\getsids.txt" + " -p" + pidbox.Text;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                       
                        
                    }
                    else
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " getsids" + " --output-file=" + output + @"\getsids.txt";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                       
                        
                    }
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (screenshot.Checked == true)
                {
                    progress = progress + interval;
                    Directory.CreateDirectory(output + @"\screenshot");
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " screenshot" + " --dump-dir=" + output + @"\screenshot";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                  
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (userassist.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " userassist" + " --output-file=" + output + @"\userassist.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
               
                backgroundWorker1.ReportProgress(progress);
                if (shellbags.Checked == true)
                {

                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " shellbags" + " --output-file=" + output + @"\shellbags.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    
                } if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (shimcache.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " shimcache" + " --output-file=" + output + @"\shimcache.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                  
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
               
                backgroundWorker1.ReportProgress(progress);
                if (sessions.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " sessions" + " --output-file=" + output + @"\sessions.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                     
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                    if (vadinfo.Checked == true)
                    {
                        progress = progress + interval;;
                    if (pidcheck.Checked == true)
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " vadinfo" + " --output-file=" + output + @"\vadinfo.txt" + " -p" + pidbox.Text;
                        Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                
                    }
                    else
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " vadinfo" + " --output-file=" + output + @"\vadinfo.txt";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                     
                    }
                    
                }
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    
                    backgroundWorker1.ReportProgress(progress);
                if(vaddump.Checked == true)
                {
                    progress = progress + interval;
                    if (pidcheck.Checked == true)
                    {
                        Directory.CreateDirectory(outputtextbox.Text + @"\vaddump");
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " vaddump" + " --dump-dir=" + output + @"\vaddump" + " -p" + pidbox.Text;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                       
                    }
                    else
                    {
                        Directory.CreateDirectory(outputtextbox.Text + @"\vaddump");
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " vaddump" + " --dump-dir=" + output + @"\vaddump";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                       
                    }
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
                if (evtlogs.Checked == true)
                {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " evtlogs" + " --output-file=" + output + @"\evtlogs.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    
                }
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                
                backgroundWorker1.ReportProgress(progress);
 if (malfind.Checked == true)
 {
                    progress = progress + interval;
                    if (pidcheck.Checked == true)
                    {
                        Directory.CreateDirectory(output + @"\malfind");
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " malfind" + " --dump-dir=" + output + @"\malfind" + " -p" + pidbox.Text;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                    }
                    else
                    {
                        Directory.CreateDirectory(output + @"\malfind");
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " malfind" + " --dump-dir=" + output + @"\malfind";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                    }
                }
 if (backgroundWorker1.CancellationPending)
 {
     e.Cancel = true;
     return;
 }
 
 backgroundWorker1.ReportProgress(progress);
 if (iehistory.Checked == true)
 {
                    progress = progress + interval;
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " iehistory" + " --output-file=" + output + @"\iehistory.txt";
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    
                }
 if (backgroundWorker1.CancellationPending)
 {
     e.Cancel = true;
     return;
 }

 backgroundWorker1.ReportProgress(progress);
 if (threads.Checked == true)
 {
     progress = progress + interval;
                    if (pidcheck.Checked == true)
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " threads" + " --output-file=" + output + @"\threads.txt" + " -p" + pidbox.Text;
                        Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    
                    }
                    else
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " threads" + " --output-file=" + output + @"\threads.txt";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                     
                    } 
                    
                }
 if (backgroundWorker1.CancellationPending)
 {
     e.Cancel = true;
     return;
 }
 
 backgroundWorker1.ReportProgress(progress);
 if (envars.Checked == true)
 {
                    progress = progress + interval;
                    if (pidcheck.Checked == true)
                    {
                    string commandlineargs = "-f " + imagefile + " --profile=" + profile + " envars" + " --output-file=" + output + @"\envars.txt" + " -p" + pidbox.Text;
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = vollocation;
                    startInfo.Arguments = commandlineargs;
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                    
                    
                    }
                    else
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " envars" + " --output-file=" + output + @"\envars.txt";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                    }

                }
 if (backgroundWorker1.CancellationPending)
 {
     e.Cancel = true;
     return;
 }
 
 backgroundWorker1.ReportProgress(progress);
 if (privs.Checked == true)
 {
     progress = progress + interval;
                    if (pidcheck.Checked == true)
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " privs" + " --output-file=" + output + @"\privs.txt" + " -p" + pidbox.Text;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                    }
                    else
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " privs" + " --output-file=" + output + @"\privs.txt";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                       
                    } 
                    
                }
 if (backgroundWorker1.CancellationPending)
 {
     e.Cancel = true;
     return;
 }

 backgroundWorker1.ReportProgress(progress);
if (handles.Checked == true)
{
    progress = progress + interval;
                    if(pidcheck.Checked == true)
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " handles" + " --output-file=" + output + @"\handles.txt" + " -p" + pidbox.Text;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                    }
                    else
                    {
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " handles" + " --output-file=" + output + @"\handles.txt";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                    } 
                   
                }
if (backgroundWorker1.CancellationPending)
{
    e.Cancel = true;
    return;
}
                    
                    backgroundWorker1.ReportProgress(progress);
                    if (memdump.Checked == true)
                    {
                        progress = progress + interval;
                    if (pidcheck.Checked == true)
                    {
                        Directory.CreateDirectory(output + @"\memdump");
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " memdump" + " --dump-dir=" + output + @"\memdump" + " -p" + pidbox.Text;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                        
                    }
		            else
                    {
                        Directory.CreateDirectory(output + @"\memdump");
                        string commandlineargs = "-f " + imagefile + " --profile=" + profile + " memdump" + " --dump-dir=" + output + @"\memdump";
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = vollocation;
                        startInfo.Arguments = commandlineargs;
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        process.Close();
                       
                    } if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                    
                }
                    button1.Enabled = true;


backgroundWorker1.ReportProgress(progress);
                 
                
        }







        private void button1_Click(object sender, EventArgs e)
        {

            
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            /// error handling for if no profile is selected and any plugin other than image info is checked///
            ///          each plugin has it's own if statement to check for profile box being empty         ///
            /// ///////////////////////////////////////////////////////////////////////////////////////////////
            if (profiletextbox.Text == "" && psscan.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && pslist.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && dlllist.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && connscan.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && sockscan.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && connsandsocks.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && netscan.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && modscan.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && cmdscan.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && svcscan.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && getsids.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && evtlogs.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && screenshot.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && userassist.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && shellbags.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && shimcache.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && sessions.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && vadinfo.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && vaddump.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && memdump.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && handles.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && privs.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && envars.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && threads.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && iehistory.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }

            if (profiletextbox.Text == "" && malfind.Checked == true)
            {
                MessageBox.Show("Profile box must be completed in order to run any plugin other than 'image info'. If you do not know the profile, run 'image info' first.");
                return;
            }
           
            backgroundWorker1.RunWorkerAsync(); ///sets the background worker running once all the error checks have run

           
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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

      

        private void sessions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vadinfo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
       
        }

        

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ///sets the progress bar value as a percentage based on the "progress" variable
            progressBar1.Value = e.ProgressPercentage;
            progresslabel.Text ="progress...." + e.ProgressPercentage.ToString() + "%";
        }

        private void pidcheck_CheckedChanged(object sender, EventArgs e)
        {
            ///grey's out the pid text box if the pid check box is unticked
            pidbox.Enabled = true;
            if(pidcheck.Checked == false)
            {
                pidbox.Enabled = false;
            }
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {

            /// cancel button cancels the background worker, changes the progress label to cancelled and value to 100% and re-enables the run plugin button
            backgroundWorker1.CancelAsync();
            progresslabel.Text = "Cancelled";
            progressBar1.Value = 100;
            button1.Enabled = true;
            return;

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pidbox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void profiletextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        

       

       

      

       

       

        
       

       
                }
            }
        

        
    

