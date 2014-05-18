﻿namespace volatility_GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.imagefiletextbox = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.imageinfo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profiletextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.psscan = new System.Windows.Forms.CheckBox();
            this.pslist = new System.Windows.Forms.CheckBox();
            this.pstree = new System.Windows.Forms.CheckBox();
            this.dlllist = new System.Windows.Forms.CheckBox();
            this.connscan = new System.Windows.Forms.CheckBox();
            this.sockscan = new System.Windows.Forms.CheckBox();
            this.connsandsocks = new System.Windows.Forms.CheckBox();
            this.netscan = new System.Windows.Forms.CheckBox();
            this.modscan = new System.Windows.Forms.CheckBox();
            this.cmdscan = new System.Windows.Forms.CheckBox();
            this.svcscan = new System.Windows.Forms.CheckBox();
            this.getsids = new System.Windows.Forms.CheckBox();
            this.outputtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.navigateimage = new System.Windows.Forms.OpenFileDialog();
            this.btnImageFile = new System.Windows.Forms.Button();
            this.navigateoutput = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.screenshot = new System.Windows.Forms.CheckBox();
            this.userassist = new System.Windows.Forms.CheckBox();
            this.shellbags = new System.Windows.Forms.CheckBox();
            this.shimcache = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sessions = new System.Windows.Forms.CheckBox();
            this.vadinfo = new System.Windows.Forms.CheckBox();
            this.vaddump = new System.Windows.Forms.CheckBox();
            this.memdump = new System.Windows.Forms.CheckBox();
            this.handles = new System.Windows.Forms.CheckBox();
            this.privs = new System.Windows.Forms.CheckBox();
            this.pidbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.CheckBox();
            this.envars = new System.Windows.Forms.CheckBox();
            this.iehistory = new System.Windows.Forms.CheckBox();
            this.malfind = new System.Windows.Forms.CheckBox();
            this.evtlogs = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progresslabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.atoms = new System.Windows.Forms.CheckBox();
            this.atomscan = new System.Windows.Forms.CheckBox();
            this.devicetree = new System.Windows.Forms.CheckBox();
            this.deskscan = new System.Windows.Forms.CheckBox();
            this.crashinfo = new System.Windows.Forms.CheckBox();
            this.consoles = new System.Windows.Forms.CheckBox();
            this.callbacks = new System.Windows.Forms.CheckBox();
            this.bioskbd = new System.Windows.Forms.CheckBox();
            this.dumpfiles = new System.Windows.Forms.CheckBox();
            this.dumpcerts = new System.Windows.Forms.CheckBox();
            this.driverscan = new System.Windows.Forms.CheckBox();
            this.driverirp = new System.Windows.Forms.CheckBox();
            this.dlldump = new System.Windows.Forms.CheckBox();
            this.eventhooks = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagefiletextbox
            // 
            this.imagefiletextbox.AllowDrop = true;
            this.imagefiletextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.imagefiletextbox.ForeColor = System.Drawing.Color.Silver;
            this.imagefiletextbox.Location = new System.Drawing.Point(116, 6);
            this.imagefiletextbox.Name = "imagefiletextbox";
            this.imagefiletextbox.Size = new System.Drawing.Size(169, 22);
            this.imagefiletextbox.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Transparent;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRun.Location = new System.Drawing.Point(465, 422);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 42);
            this.btnRun.TabIndex = 19;
            this.btnRun.Text = "run plugins";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageinfo
            // 
            this.imageinfo.AutoSize = true;
            this.imageinfo.BackColor = System.Drawing.Color.Transparent;
            this.imageinfo.ForeColor = System.Drawing.Color.Silver;
            this.imageinfo.Location = new System.Drawing.Point(463, 36);
            this.imageinfo.Name = "imageinfo";
            this.imageinfo.Size = new System.Drawing.Size(95, 21);
            this.imageinfo.TabIndex = 5;
            this.imageinfo.Tag = "imageinfo";
            this.imageinfo.Text = "Image Info";
            this.imageinfo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Image filepath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(460, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "plugins";
            // 
            // profiletextbox
            // 
            this.profiletextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.profiletextbox.ForeColor = System.Drawing.Color.Silver;
            this.profiletextbox.Location = new System.Drawing.Point(116, 64);
            this.profiletextbox.Name = "profiletextbox";
            this.profiletextbox.Size = new System.Drawing.Size(169, 22);
            this.profiletextbox.TabIndex = 2;
            this.profiletextbox.TextChanged += new System.EventHandler(this.profiletextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(63, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "profile";
            // 
            // psscan
            // 
            this.psscan.AutoSize = true;
            this.psscan.BackColor = System.Drawing.Color.Transparent;
            this.psscan.Enabled = false;
            this.psscan.ForeColor = System.Drawing.Color.Silver;
            this.psscan.Location = new System.Drawing.Point(463, 63);
            this.psscan.Name = "psscan";
            this.psscan.Size = new System.Drawing.Size(75, 21);
            this.psscan.TabIndex = 5;
            this.psscan.Tag = "psscan";
            this.psscan.Text = "psscan";
            this.psscan.UseVisualStyleBackColor = false;
            // 
            // pslist
            // 
            this.pslist.AutoSize = true;
            this.pslist.BackColor = System.Drawing.Color.Transparent;
            this.pslist.Enabled = false;
            this.pslist.ForeColor = System.Drawing.Color.Silver;
            this.pslist.Location = new System.Drawing.Point(463, 90);
            this.pslist.Name = "pslist";
            this.pslist.Size = new System.Drawing.Size(62, 21);
            this.pslist.TabIndex = 6;
            this.pslist.Tag = "pslist";
            this.pslist.Text = "pslist";
            this.pslist.UseVisualStyleBackColor = false;
            // 
            // pstree
            // 
            this.pstree.AutoSize = true;
            this.pstree.BackColor = System.Drawing.Color.Transparent;
            this.pstree.Enabled = false;
            this.pstree.ForeColor = System.Drawing.Color.Silver;
            this.pstree.Location = new System.Drawing.Point(463, 117);
            this.pstree.Name = "pstree";
            this.pstree.Size = new System.Drawing.Size(70, 21);
            this.pstree.TabIndex = 7;
            this.pstree.Tag = "pstree";
            this.pstree.Text = "pstree";
            this.pstree.UseVisualStyleBackColor = false;
            // 
            // dlllist
            // 
            this.dlllist.AutoSize = true;
            this.dlllist.BackColor = System.Drawing.Color.Transparent;
            this.dlllist.Enabled = false;
            this.dlllist.ForeColor = System.Drawing.Color.Silver;
            this.dlllist.Location = new System.Drawing.Point(463, 141);
            this.dlllist.Name = "dlllist";
            this.dlllist.Size = new System.Drawing.Size(61, 21);
            this.dlllist.TabIndex = 8;
            this.dlllist.Tag = "dlllist,PID";
            this.dlllist.Text = "dlllist";
            this.dlllist.UseVisualStyleBackColor = false;
            // 
            // connscan
            // 
            this.connscan.AutoSize = true;
            this.connscan.BackColor = System.Drawing.Color.Transparent;
            this.connscan.Enabled = false;
            this.connscan.ForeColor = System.Drawing.Color.Silver;
            this.connscan.Location = new System.Drawing.Point(463, 168);
            this.connscan.Name = "connscan";
            this.connscan.Size = new System.Drawing.Size(91, 21);
            this.connscan.TabIndex = 9;
            this.connscan.Tag = "connscan";
            this.connscan.Text = "connscan";
            this.connscan.UseVisualStyleBackColor = false;
            // 
            // sockscan
            // 
            this.sockscan.AutoSize = true;
            this.sockscan.BackColor = System.Drawing.Color.Transparent;
            this.sockscan.Enabled = false;
            this.sockscan.ForeColor = System.Drawing.Color.Silver;
            this.sockscan.Location = new System.Drawing.Point(463, 195);
            this.sockscan.Name = "sockscan";
            this.sockscan.Size = new System.Drawing.Size(89, 21);
            this.sockscan.TabIndex = 10;
            this.sockscan.Tag = "sockscan";
            this.sockscan.Text = "sockscan";
            this.sockscan.UseVisualStyleBackColor = false;
            // 
            // connsandsocks
            // 
            this.connsandsocks.AutoSize = true;
            this.connsandsocks.BackColor = System.Drawing.Color.Transparent;
            this.connsandsocks.Enabled = false;
            this.connsandsocks.ForeColor = System.Drawing.Color.Silver;
            this.connsandsocks.Location = new System.Drawing.Point(463, 220);
            this.connsandsocks.Name = "connsandsocks";
            this.connsandsocks.Size = new System.Drawing.Size(106, 21);
            this.connsandsocks.TabIndex = 11;
            this.connsandsocks.Tag = "connections";
            this.connsandsocks.Text = "connections";
            this.connsandsocks.UseVisualStyleBackColor = false;
            this.connsandsocks.CheckedChanged += new System.EventHandler(this.connsandsocks_CheckedChanged);
            // 
            // netscan
            // 
            this.netscan.AutoSize = true;
            this.netscan.BackColor = System.Drawing.Color.Transparent;
            this.netscan.Enabled = false;
            this.netscan.ForeColor = System.Drawing.Color.Silver;
            this.netscan.Location = new System.Drawing.Point(463, 247);
            this.netscan.Name = "netscan";
            this.netscan.Size = new System.Drawing.Size(80, 21);
            this.netscan.TabIndex = 12;
            this.netscan.Tag = "netscan";
            this.netscan.Text = "netscan";
            this.netscan.UseVisualStyleBackColor = false;
            // 
            // modscan
            // 
            this.modscan.AutoSize = true;
            this.modscan.BackColor = System.Drawing.Color.Transparent;
            this.modscan.Enabled = false;
            this.modscan.ForeColor = System.Drawing.Color.Silver;
            this.modscan.Location = new System.Drawing.Point(463, 274);
            this.modscan.Name = "modscan";
            this.modscan.Size = new System.Drawing.Size(87, 21);
            this.modscan.TabIndex = 13;
            this.modscan.Tag = "modscan";
            this.modscan.Text = "modscan";
            this.modscan.UseVisualStyleBackColor = false;
            // 
            // cmdscan
            // 
            this.cmdscan.AutoSize = true;
            this.cmdscan.BackColor = System.Drawing.Color.Transparent;
            this.cmdscan.Enabled = false;
            this.cmdscan.ForeColor = System.Drawing.Color.Silver;
            this.cmdscan.Location = new System.Drawing.Point(463, 301);
            this.cmdscan.Name = "cmdscan";
            this.cmdscan.Size = new System.Drawing.Size(86, 21);
            this.cmdscan.TabIndex = 14;
            this.cmdscan.Tag = "cmdscan";
            this.cmdscan.Text = "cmdscan";
            this.cmdscan.UseVisualStyleBackColor = false;
            // 
            // svcscan
            // 
            this.svcscan.AutoSize = true;
            this.svcscan.BackColor = System.Drawing.Color.Transparent;
            this.svcscan.Enabled = false;
            this.svcscan.ForeColor = System.Drawing.Color.Silver;
            this.svcscan.Location = new System.Drawing.Point(463, 328);
            this.svcscan.Name = "svcscan";
            this.svcscan.Size = new System.Drawing.Size(81, 21);
            this.svcscan.TabIndex = 15;
            this.svcscan.Tag = "svcscan";
            this.svcscan.Text = "svcscan";
            this.svcscan.UseVisualStyleBackColor = false;
            // 
            // getsids
            // 
            this.getsids.AutoSize = true;
            this.getsids.BackColor = System.Drawing.Color.Transparent;
            this.getsids.Enabled = false;
            this.getsids.ForeColor = System.Drawing.Color.Silver;
            this.getsids.Location = new System.Drawing.Point(463, 355);
            this.getsids.Name = "getsids";
            this.getsids.Size = new System.Drawing.Size(75, 21);
            this.getsids.TabIndex = 16;
            this.getsids.Tag = "getsids,PID";
            this.getsids.Text = "getsids";
            this.getsids.UseVisualStyleBackColor = false;
            // 
            // outputtextbox
            // 
            this.outputtextbox.AllowDrop = true;
            this.outputtextbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.outputtextbox.ForeColor = System.Drawing.Color.Silver;
            this.outputtextbox.Location = new System.Drawing.Point(116, 36);
            this.outputtextbox.Name = "outputtextbox";
            this.outputtextbox.Size = new System.Drawing.Size(169, 22);
            this.outputtextbox.TabIndex = 1;
            this.outputtextbox.Text = "C:\\vol-plugin-outputs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Output filepath";
            // 
            // navigateimage
            // 
            this.navigateimage.InitialDirectory = "C:\\";
            this.navigateimage.ShowHelp = true;
            this.navigateimage.Title = "navigate";
            // 
            // btnImageFile
            // 
            this.btnImageFile.BackColor = System.Drawing.Color.Transparent;
            this.btnImageFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImageFile.ForeColor = System.Drawing.Color.Silver;
            this.btnImageFile.Location = new System.Drawing.Point(291, 2);
            this.btnImageFile.Name = "btnImageFile";
            this.btnImageFile.Size = new System.Drawing.Size(50, 25);
            this.btnImageFile.TabIndex = 24;
            this.btnImageFile.Text = "...";
            this.btnImageFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImageFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImageFile.UseVisualStyleBackColor = false;
            this.btnImageFile.Click += new System.EventHandler(this.imagenavigate_Click);
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.BackColor = System.Drawing.Color.Transparent;
            this.btnOutputPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOutputPath.ForeColor = System.Drawing.Color.Silver;
            this.btnOutputPath.Location = new System.Drawing.Point(291, 36);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(50, 25);
            this.btnOutputPath.TabIndex = 27;
            this.btnOutputPath.Text = "...";
            this.btnOutputPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutputPath.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOutputPath.UseVisualStyleBackColor = false;
            this.btnOutputPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 256);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // screenshot
            // 
            this.screenshot.AutoSize = true;
            this.screenshot.BackColor = System.Drawing.Color.Transparent;
            this.screenshot.Enabled = false;
            this.screenshot.ForeColor = System.Drawing.Color.Silver;
            this.screenshot.Location = new System.Drawing.Point(585, 36);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(100, 21);
            this.screenshot.TabIndex = 30;
            this.screenshot.Tag = "screenshot,DIR";
            this.screenshot.Text = "screenshot";
            this.screenshot.UseVisualStyleBackColor = false;
            // 
            // userassist
            // 
            this.userassist.AutoSize = true;
            this.userassist.BackColor = System.Drawing.Color.Transparent;
            this.userassist.Enabled = false;
            this.userassist.ForeColor = System.Drawing.Color.Silver;
            this.userassist.Location = new System.Drawing.Point(585, 63);
            this.userassist.Name = "userassist";
            this.userassist.Size = new System.Drawing.Size(94, 21);
            this.userassist.TabIndex = 31;
            this.userassist.Tag = "userassist";
            this.userassist.Text = "userassist";
            this.userassist.UseVisualStyleBackColor = false;
            // 
            // shellbags
            // 
            this.shellbags.AutoSize = true;
            this.shellbags.BackColor = System.Drawing.Color.Transparent;
            this.shellbags.Enabled = false;
            this.shellbags.ForeColor = System.Drawing.Color.Silver;
            this.shellbags.Location = new System.Drawing.Point(585, 90);
            this.shellbags.Name = "shellbags";
            this.shellbags.Size = new System.Drawing.Size(90, 21);
            this.shellbags.TabIndex = 32;
            this.shellbags.Tag = "shellbags";
            this.shellbags.Text = "shellbags";
            this.shellbags.UseVisualStyleBackColor = false;
            // 
            // shimcache
            // 
            this.shimcache.AutoSize = true;
            this.shimcache.BackColor = System.Drawing.Color.Transparent;
            this.shimcache.Enabled = false;
            this.shimcache.ForeColor = System.Drawing.Color.Silver;
            this.shimcache.Location = new System.Drawing.Point(585, 117);
            this.shimcache.Name = "shimcache";
            this.shimcache.Size = new System.Drawing.Size(97, 21);
            this.shimcache.TabIndex = 33;
            this.shimcache.Tag = "shimcache";
            this.shimcache.Text = "shimcache";
            this.shimcache.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // sessions
            // 
            this.sessions.AutoSize = true;
            this.sessions.BackColor = System.Drawing.Color.Transparent;
            this.sessions.Enabled = false;
            this.sessions.ForeColor = System.Drawing.Color.Silver;
            this.sessions.Location = new System.Drawing.Point(585, 141);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(85, 21);
            this.sessions.TabIndex = 34;
            this.sessions.Tag = "sessions";
            this.sessions.Text = "sessions";
            this.sessions.UseVisualStyleBackColor = false;
            // 
            // vadinfo
            // 
            this.vadinfo.AutoSize = true;
            this.vadinfo.BackColor = System.Drawing.Color.Transparent;
            this.vadinfo.Enabled = false;
            this.vadinfo.ForeColor = System.Drawing.Color.Silver;
            this.vadinfo.Location = new System.Drawing.Point(585, 168);
            this.vadinfo.Name = "vadinfo";
            this.vadinfo.Size = new System.Drawing.Size(76, 21);
            this.vadinfo.TabIndex = 35;
            this.vadinfo.Tag = "vadinfo,PID";
            this.vadinfo.Text = "vadinfo";
            this.vadinfo.UseVisualStyleBackColor = false;
            // 
            // vaddump
            // 
            this.vaddump.AutoSize = true;
            this.vaddump.BackColor = System.Drawing.Color.Transparent;
            this.vaddump.Enabled = false;
            this.vaddump.ForeColor = System.Drawing.Color.Silver;
            this.vaddump.Location = new System.Drawing.Point(585, 195);
            this.vaddump.Name = "vaddump";
            this.vaddump.Size = new System.Drawing.Size(88, 21);
            this.vaddump.TabIndex = 36;
            this.vaddump.Tag = "vaddump,PID,DIR";
            this.vaddump.Text = "vaddump";
            this.vaddump.UseVisualStyleBackColor = false;
            // 
            // memdump
            // 
            this.memdump.AutoSize = true;
            this.memdump.BackColor = System.Drawing.Color.Transparent;
            this.memdump.Enabled = false;
            this.memdump.ForeColor = System.Drawing.Color.Silver;
            this.memdump.Location = new System.Drawing.Point(585, 222);
            this.memdump.Name = "memdump";
            this.memdump.Size = new System.Drawing.Size(95, 21);
            this.memdump.TabIndex = 37;
            this.memdump.Tag = "memdump,PID,DIR";
            this.memdump.Text = "memdump";
            this.memdump.UseVisualStyleBackColor = false;
            this.memdump.CheckedChanged += new System.EventHandler(this.memdump_CheckedChanged);
            // 
            // handles
            // 
            this.handles.AutoSize = true;
            this.handles.BackColor = System.Drawing.Color.Transparent;
            this.handles.Enabled = false;
            this.handles.ForeColor = System.Drawing.Color.Silver;
            this.handles.Location = new System.Drawing.Point(584, 247);
            this.handles.Name = "handles";
            this.handles.Size = new System.Drawing.Size(80, 21);
            this.handles.TabIndex = 38;
            this.handles.Tag = "handles,PID";
            this.handles.Text = "handles";
            this.handles.UseVisualStyleBackColor = false;
            // 
            // privs
            // 
            this.privs.AutoSize = true;
            this.privs.BackColor = System.Drawing.Color.Transparent;
            this.privs.Enabled = false;
            this.privs.ForeColor = System.Drawing.Color.Silver;
            this.privs.Location = new System.Drawing.Point(585, 274);
            this.privs.Name = "privs";
            this.privs.Size = new System.Drawing.Size(60, 21);
            this.privs.TabIndex = 39;
            this.privs.Tag = "privs,PID";
            this.privs.Text = "privs";
            this.privs.UseVisualStyleBackColor = false;
            // 
            // pidbox
            // 
            this.pidbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pidbox.ForeColor = System.Drawing.Color.Silver;
            this.pidbox.Location = new System.Drawing.Point(116, 92);
            this.pidbox.Name = "pidbox";
            this.pidbox.Size = new System.Drawing.Size(169, 22);
            this.pidbox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(73, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "PIDs";
            // 
            // threads
            // 
            this.threads.AutoSize = true;
            this.threads.BackColor = System.Drawing.Color.Transparent;
            this.threads.Enabled = false;
            this.threads.ForeColor = System.Drawing.Color.Silver;
            this.threads.Location = new System.Drawing.Point(585, 328);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(78, 21);
            this.threads.TabIndex = 42;
            this.threads.Tag = "threads,PID";
            this.threads.Text = "threads";
            this.threads.UseVisualStyleBackColor = false;
            // 
            // envars
            // 
            this.envars.AutoSize = true;
            this.envars.BackColor = System.Drawing.Color.Transparent;
            this.envars.Enabled = false;
            this.envars.ForeColor = System.Drawing.Color.Silver;
            this.envars.Location = new System.Drawing.Point(585, 301);
            this.envars.Name = "envars";
            this.envars.Size = new System.Drawing.Size(73, 21);
            this.envars.TabIndex = 43;
            this.envars.Tag = "envars,PID";
            this.envars.Text = "envars";
            this.envars.UseVisualStyleBackColor = false;
            // 
            // iehistory
            // 
            this.iehistory.AutoSize = true;
            this.iehistory.BackColor = System.Drawing.Color.Transparent;
            this.iehistory.Enabled = false;
            this.iehistory.ForeColor = System.Drawing.Color.Silver;
            this.iehistory.Location = new System.Drawing.Point(585, 353);
            this.iehistory.Name = "iehistory";
            this.iehistory.Size = new System.Drawing.Size(83, 21);
            this.iehistory.TabIndex = 44;
            this.iehistory.Tag = "iehistory";
            this.iehistory.Text = "iehistory";
            this.iehistory.UseVisualStyleBackColor = false;
            // 
            // malfind
            // 
            this.malfind.AutoSize = true;
            this.malfind.BackColor = System.Drawing.Color.Transparent;
            this.malfind.Enabled = false;
            this.malfind.ForeColor = System.Drawing.Color.Silver;
            this.malfind.Location = new System.Drawing.Point(584, 380);
            this.malfind.Name = "malfind";
            this.malfind.Size = new System.Drawing.Size(75, 21);
            this.malfind.TabIndex = 45;
            this.malfind.Tag = "malfind,PID,DIR";
            this.malfind.Text = "malfind";
            this.malfind.UseVisualStyleBackColor = false;
            // 
            // evtlogs
            // 
            this.evtlogs.AutoSize = true;
            this.evtlogs.BackColor = System.Drawing.Color.Transparent;
            this.evtlogs.ForeColor = System.Drawing.Color.Silver;
            this.evtlogs.Location = new System.Drawing.Point(463, 382);
            this.evtlogs.Name = "evtlogs";
            this.evtlogs.Size = new System.Drawing.Size(75, 21);
            this.evtlogs.TabIndex = 46;
            this.evtlogs.Tag = "evtlogs";
            this.evtlogs.Text = "evtlogs";
            this.evtlogs.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(704, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 42);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.Location = new System.Drawing.Point(17, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(324, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 49;
            // 
            // progresslabel
            // 
            this.progresslabel.AutoSize = true;
            this.progresslabel.BackColor = System.Drawing.Color.Transparent;
            this.progresslabel.Location = new System.Drawing.Point(309, 141);
            this.progresslabel.Name = "progresslabel";
            this.progresslabel.Size = new System.Drawing.Size(0, 17);
            this.progresslabel.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("SketchFlow Print", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(5, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 41);
            this.label8.TabIndex = 53;
            this.label8.Text = "Plugin Manager";
            // 
            // atoms
            // 
            this.atoms.AutoSize = true;
            this.atoms.BackColor = System.Drawing.Color.Transparent;
            this.atoms.Enabled = false;
            this.atoms.ForeColor = System.Drawing.Color.Silver;
            this.atoms.Location = new System.Drawing.Point(704, 35);
            this.atoms.Name = "atoms";
            this.atoms.Size = new System.Drawing.Size(68, 21);
            this.atoms.TabIndex = 54;
            this.atoms.Tag = "atoms";
            this.atoms.Text = "atoms";
            this.atoms.UseVisualStyleBackColor = false;
            // 
            // atomscan
            // 
            this.atomscan.AutoSize = true;
            this.atomscan.BackColor = System.Drawing.Color.Transparent;
            this.atomscan.Enabled = false;
            this.atomscan.ForeColor = System.Drawing.Color.Silver;
            this.atomscan.Location = new System.Drawing.Point(703, 63);
            this.atomscan.Name = "atomscan";
            this.atomscan.Size = new System.Drawing.Size(91, 21);
            this.atomscan.TabIndex = 55;
            this.atomscan.Tag = "atomscan";
            this.atomscan.Text = "atomscan";
            this.atomscan.UseVisualStyleBackColor = false;
            // 
            // devicetree
            // 
            this.devicetree.AutoSize = true;
            this.devicetree.BackColor = System.Drawing.Color.Transparent;
            this.devicetree.Enabled = false;
            this.devicetree.ForeColor = System.Drawing.Color.Silver;
            this.devicetree.Location = new System.Drawing.Point(704, 222);
            this.devicetree.Name = "devicetree";
            this.devicetree.Size = new System.Drawing.Size(96, 21);
            this.devicetree.TabIndex = 56;
            this.devicetree.Tag = "devicetree";
            this.devicetree.Text = "devicetree";
            this.devicetree.UseVisualStyleBackColor = false;
            // 
            // deskscan
            // 
            this.deskscan.AutoSize = true;
            this.deskscan.BackColor = System.Drawing.Color.Transparent;
            this.deskscan.Enabled = false;
            this.deskscan.ForeColor = System.Drawing.Color.Silver;
            this.deskscan.Location = new System.Drawing.Point(704, 195);
            this.deskscan.Name = "deskscan";
            this.deskscan.Size = new System.Drawing.Size(90, 21);
            this.deskscan.TabIndex = 57;
            this.deskscan.Tag = "deskscan";
            this.deskscan.Text = "deskscan";
            this.deskscan.UseVisualStyleBackColor = false;
            // 
            // crashinfo
            // 
            this.crashinfo.AutoSize = true;
            this.crashinfo.BackColor = System.Drawing.Color.Transparent;
            this.crashinfo.Enabled = false;
            this.crashinfo.ForeColor = System.Drawing.Color.Silver;
            this.crashinfo.Location = new System.Drawing.Point(703, 168);
            this.crashinfo.Name = "crashinfo";
            this.crashinfo.Size = new System.Drawing.Size(88, 21);
            this.crashinfo.TabIndex = 58;
            this.crashinfo.Tag = "crashinfo";
            this.crashinfo.Text = "crashinfo";
            this.crashinfo.UseVisualStyleBackColor = false;
            // 
            // consoles
            // 
            this.consoles.AutoSize = true;
            this.consoles.BackColor = System.Drawing.Color.Transparent;
            this.consoles.Enabled = false;
            this.consoles.ForeColor = System.Drawing.Color.Silver;
            this.consoles.Location = new System.Drawing.Point(703, 141);
            this.consoles.Name = "consoles";
            this.consoles.Size = new System.Drawing.Size(86, 21);
            this.consoles.TabIndex = 59;
            this.consoles.Tag = "consoles";
            this.consoles.Text = "consoles";
            this.consoles.UseVisualStyleBackColor = false;
            // 
            // callbacks
            // 
            this.callbacks.AutoSize = true;
            this.callbacks.BackColor = System.Drawing.Color.Transparent;
            this.callbacks.Enabled = false;
            this.callbacks.ForeColor = System.Drawing.Color.Silver;
            this.callbacks.Location = new System.Drawing.Point(703, 117);
            this.callbacks.Name = "callbacks";
            this.callbacks.Size = new System.Drawing.Size(88, 21);
            this.callbacks.TabIndex = 60;
            this.callbacks.Tag = "callbacks";
            this.callbacks.Text = "callbacks";
            this.callbacks.UseVisualStyleBackColor = false;
            // 
            // bioskbd
            // 
            this.bioskbd.AutoSize = true;
            this.bioskbd.BackColor = System.Drawing.Color.Transparent;
            this.bioskbd.Enabled = false;
            this.bioskbd.ForeColor = System.Drawing.Color.Silver;
            this.bioskbd.Location = new System.Drawing.Point(704, 90);
            this.bioskbd.Name = "bioskbd";
            this.bioskbd.Size = new System.Drawing.Size(79, 21);
            this.bioskbd.TabIndex = 61;
            this.bioskbd.Tag = "bioskbd";
            this.bioskbd.Text = "bioskbd";
            this.bioskbd.UseVisualStyleBackColor = false;
            // 
            // dumpfiles
            // 
            this.dumpfiles.AutoSize = true;
            this.dumpfiles.BackColor = System.Drawing.Color.Transparent;
            this.dumpfiles.Enabled = false;
            this.dumpfiles.ForeColor = System.Drawing.Color.Silver;
            this.dumpfiles.Location = new System.Drawing.Point(704, 353);
            this.dumpfiles.Name = "dumpfiles";
            this.dumpfiles.Size = new System.Drawing.Size(90, 21);
            this.dumpfiles.TabIndex = 62;
            this.dumpfiles.Tag = "dumpfiles,PID,DIR";
            this.dumpfiles.Text = "dumpfiles";
            this.dumpfiles.UseVisualStyleBackColor = false;
            // 
            // dumpcerts
            // 
            this.dumpcerts.AutoSize = true;
            this.dumpcerts.BackColor = System.Drawing.Color.Transparent;
            this.dumpcerts.Enabled = false;
            this.dumpcerts.ForeColor = System.Drawing.Color.Silver;
            this.dumpcerts.Location = new System.Drawing.Point(704, 328);
            this.dumpcerts.Name = "dumpcerts";
            this.dumpcerts.Size = new System.Drawing.Size(96, 21);
            this.dumpcerts.TabIndex = 63;
            this.dumpcerts.Tag = "dumpcerts,PID,DIR";
            this.dumpcerts.Text = "dumpcerts";
            this.dumpcerts.UseVisualStyleBackColor = false;
            // 
            // driverscan
            // 
            this.driverscan.AutoSize = true;
            this.driverscan.BackColor = System.Drawing.Color.Transparent;
            this.driverscan.Enabled = false;
            this.driverscan.ForeColor = System.Drawing.Color.Silver;
            this.driverscan.Location = new System.Drawing.Point(704, 303);
            this.driverscan.Name = "driverscan";
            this.driverscan.Size = new System.Drawing.Size(96, 21);
            this.driverscan.TabIndex = 64;
            this.driverscan.Tag = "driverscan";
            this.driverscan.Text = "driverscan";
            this.driverscan.UseVisualStyleBackColor = false;
            // 
            // driverirp
            // 
            this.driverirp.AutoSize = true;
            this.driverirp.BackColor = System.Drawing.Color.Transparent;
            this.driverirp.Enabled = false;
            this.driverirp.ForeColor = System.Drawing.Color.Silver;
            this.driverirp.Location = new System.Drawing.Point(704, 276);
            this.driverirp.Name = "driverirp";
            this.driverirp.Size = new System.Drawing.Size(82, 21);
            this.driverirp.TabIndex = 65;
            this.driverirp.Tag = "driverirp";
            this.driverirp.Text = "driverirp";
            this.driverirp.UseVisualStyleBackColor = false;
            // 
            // dlldump
            // 
            this.dlldump.AutoSize = true;
            this.dlldump.BackColor = System.Drawing.Color.Transparent;
            this.dlldump.Enabled = false;
            this.dlldump.ForeColor = System.Drawing.Color.Silver;
            this.dlldump.Location = new System.Drawing.Point(704, 249);
            this.dlldump.Name = "dlldump";
            this.dlldump.Size = new System.Drawing.Size(79, 21);
            this.dlldump.TabIndex = 66;
            this.dlldump.Tag = "dlldump,PID,DIR";
            this.dlldump.Text = "dlldump";
            this.dlldump.UseVisualStyleBackColor = false;
            // 
            // eventhooks
            // 
            this.eventhooks.AutoSize = true;
            this.eventhooks.BackColor = System.Drawing.Color.Transparent;
            this.eventhooks.Enabled = false;
            this.eventhooks.ForeColor = System.Drawing.Color.Silver;
            this.eventhooks.Location = new System.Drawing.Point(704, 380);
            this.eventhooks.Name = "eventhooks";
            this.eventhooks.Size = new System.Drawing.Size(103, 21);
            this.eventhooks.TabIndex = 67;
            this.eventhooks.Tag = "eventhooks";
            this.eventhooks.Text = "eventhooks";
            this.eventhooks.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::volatility_GUI.Properties.Resources.VPMbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 476);
            this.Controls.Add(this.eventhooks);
            this.Controls.Add(this.dlldump);
            this.Controls.Add(this.driverirp);
            this.Controls.Add(this.driverscan);
            this.Controls.Add(this.dumpcerts);
            this.Controls.Add(this.dumpfiles);
            this.Controls.Add(this.bioskbd);
            this.Controls.Add(this.callbacks);
            this.Controls.Add(this.consoles);
            this.Controls.Add(this.crashinfo);
            this.Controls.Add(this.deskscan);
            this.Controls.Add(this.devicetree);
            this.Controls.Add(this.atomscan);
            this.Controls.Add(this.atoms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progresslabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.evtlogs);
            this.Controls.Add(this.malfind);
            this.Controls.Add(this.iehistory);
            this.Controls.Add(this.envars);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pidbox);
            this.Controls.Add(this.privs);
            this.Controls.Add(this.handles);
            this.Controls.Add(this.memdump);
            this.Controls.Add(this.vaddump);
            this.Controls.Add(this.vadinfo);
            this.Controls.Add(this.sessions);
            this.Controls.Add(this.shimcache);
            this.Controls.Add(this.shellbags);
            this.Controls.Add(this.userassist);
            this.Controls.Add(this.screenshot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOutputPath);
            this.Controls.Add(this.btnImageFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputtextbox);
            this.Controls.Add(this.getsids);
            this.Controls.Add(this.svcscan);
            this.Controls.Add(this.cmdscan);
            this.Controls.Add(this.modscan);
            this.Controls.Add(this.netscan);
            this.Controls.Add(this.connsandsocks);
            this.Controls.Add(this.sockscan);
            this.Controls.Add(this.connscan);
            this.Controls.Add(this.dlllist);
            this.Controls.Add(this.pstree);
            this.Controls.Add(this.pslist);
            this.Controls.Add(this.psscan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profiletextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageinfo);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.imagefiletextbox);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Volatility plugin manager 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagefiletextbox;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox imageinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox profiletextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox psscan;
        private System.Windows.Forms.CheckBox pslist;
        private System.Windows.Forms.CheckBox pstree;
        private System.Windows.Forms.CheckBox dlllist;
        private System.Windows.Forms.CheckBox connscan;
        private System.Windows.Forms.CheckBox sockscan;
        private System.Windows.Forms.CheckBox connsandsocks;
        private System.Windows.Forms.CheckBox netscan;
        private System.Windows.Forms.CheckBox modscan;
        private System.Windows.Forms.CheckBox cmdscan;
        private System.Windows.Forms.CheckBox svcscan;
        private System.Windows.Forms.CheckBox getsids;
        private System.Windows.Forms.TextBox outputtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog navigateimage;
        private System.Windows.Forms.Button btnImageFile;
        private System.Windows.Forms.FolderBrowserDialog navigateoutput;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox screenshot;
        private System.Windows.Forms.CheckBox userassist;
        private System.Windows.Forms.CheckBox shellbags;
        private System.Windows.Forms.CheckBox shimcache;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox sessions;
        private System.Windows.Forms.CheckBox vadinfo;
        private System.Windows.Forms.CheckBox vaddump;
        private System.Windows.Forms.CheckBox memdump;
        private System.Windows.Forms.CheckBox handles;
        private System.Windows.Forms.TextBox pidbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox privs;
        private System.Windows.Forms.CheckBox threads;
        private System.Windows.Forms.CheckBox envars;
        private System.Windows.Forms.CheckBox iehistory;
        private System.Windows.Forms.CheckBox malfind;
        private System.Windows.Forms.CheckBox evtlogs;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progresslabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox atoms;
        private System.Windows.Forms.CheckBox atomscan;
        private System.Windows.Forms.CheckBox devicetree;
        private System.Windows.Forms.CheckBox deskscan;
        private System.Windows.Forms.CheckBox crashinfo;
        private System.Windows.Forms.CheckBox consoles;
        private System.Windows.Forms.CheckBox callbacks;
        private System.Windows.Forms.CheckBox bioskbd;
        private System.Windows.Forms.CheckBox dumpfiles;
        private System.Windows.Forms.CheckBox dumpcerts;
        private System.Windows.Forms.CheckBox driverscan;
        private System.Windows.Forms.CheckBox driverirp;
        private System.Windows.Forms.CheckBox dlldump;
        private System.Windows.Forms.CheckBox eventhooks;
    }
}

