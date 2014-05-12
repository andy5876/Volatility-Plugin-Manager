namespace volatility_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagefiletextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.imagenavigate = new System.Windows.Forms.Button();
            this.navigateoutput = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
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
            this.pidcheck = new System.Windows.Forms.CheckBox();
            this.cancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progresslabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.imagefiletextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(463, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "run plugins";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.psscan.ForeColor = System.Drawing.Color.Silver;
            this.psscan.Location = new System.Drawing.Point(463, 63);
            this.psscan.Name = "psscan";
            this.psscan.Size = new System.Drawing.Size(75, 21);
            this.psscan.TabIndex = 5;
            this.psscan.Text = "psscan";
            this.psscan.UseVisualStyleBackColor = false;
            this.psscan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pslist
            // 
            this.pslist.AutoSize = true;
            this.pslist.BackColor = System.Drawing.Color.Transparent;
            this.pslist.ForeColor = System.Drawing.Color.Silver;
            this.pslist.Location = new System.Drawing.Point(463, 90);
            this.pslist.Name = "pslist";
            this.pslist.Size = new System.Drawing.Size(62, 21);
            this.pslist.TabIndex = 6;
            this.pslist.Text = "pslist";
            this.pslist.UseVisualStyleBackColor = false;
            // 
            // pstree
            // 
            this.pstree.AutoSize = true;
            this.pstree.BackColor = System.Drawing.Color.Transparent;
            this.pstree.ForeColor = System.Drawing.Color.Silver;
            this.pstree.Location = new System.Drawing.Point(463, 117);
            this.pstree.Name = "pstree";
            this.pstree.Size = new System.Drawing.Size(70, 21);
            this.pstree.TabIndex = 7;
            this.pstree.Text = "pstree";
            this.pstree.UseVisualStyleBackColor = false;
            // 
            // dlllist
            // 
            this.dlllist.AutoSize = true;
            this.dlllist.BackColor = System.Drawing.Color.Transparent;
            this.dlllist.ForeColor = System.Drawing.Color.Silver;
            this.dlllist.Location = new System.Drawing.Point(463, 141);
            this.dlllist.Name = "dlllist";
            this.dlllist.Size = new System.Drawing.Size(61, 21);
            this.dlllist.TabIndex = 8;
            this.dlllist.Text = "dlllist";
            this.dlllist.UseVisualStyleBackColor = false;
            // 
            // connscan
            // 
            this.connscan.AutoSize = true;
            this.connscan.BackColor = System.Drawing.Color.Transparent;
            this.connscan.ForeColor = System.Drawing.Color.Silver;
            this.connscan.Location = new System.Drawing.Point(463, 168);
            this.connscan.Name = "connscan";
            this.connscan.Size = new System.Drawing.Size(91, 21);
            this.connscan.TabIndex = 9;
            this.connscan.Text = "connscan";
            this.connscan.UseVisualStyleBackColor = false;
            // 
            // sockscan
            // 
            this.sockscan.AutoSize = true;
            this.sockscan.BackColor = System.Drawing.Color.Transparent;
            this.sockscan.ForeColor = System.Drawing.Color.Silver;
            this.sockscan.Location = new System.Drawing.Point(463, 195);
            this.sockscan.Name = "sockscan";
            this.sockscan.Size = new System.Drawing.Size(89, 21);
            this.sockscan.TabIndex = 10;
            this.sockscan.Text = "sockscan";
            this.sockscan.UseVisualStyleBackColor = false;
            // 
            // connsandsocks
            // 
            this.connsandsocks.AutoSize = true;
            this.connsandsocks.BackColor = System.Drawing.Color.Transparent;
            this.connsandsocks.ForeColor = System.Drawing.Color.Silver;
            this.connsandsocks.Location = new System.Drawing.Point(463, 220);
            this.connsandsocks.Name = "connsandsocks";
            this.connsandsocks.Size = new System.Drawing.Size(187, 21);
            this.connsandsocks.TabIndex = 11;
            this.connsandsocks.Text = "conns and socks (active)";
            this.connsandsocks.UseVisualStyleBackColor = false;
            // 
            // netscan
            // 
            this.netscan.AutoSize = true;
            this.netscan.BackColor = System.Drawing.Color.Transparent;
            this.netscan.ForeColor = System.Drawing.Color.Silver;
            this.netscan.Location = new System.Drawing.Point(463, 247);
            this.netscan.Name = "netscan";
            this.netscan.Size = new System.Drawing.Size(80, 21);
            this.netscan.TabIndex = 12;
            this.netscan.Text = "netscan";
            this.netscan.UseVisualStyleBackColor = false;
            // 
            // modscan
            // 
            this.modscan.AutoSize = true;
            this.modscan.BackColor = System.Drawing.Color.Transparent;
            this.modscan.ForeColor = System.Drawing.Color.Silver;
            this.modscan.Location = new System.Drawing.Point(463, 274);
            this.modscan.Name = "modscan";
            this.modscan.Size = new System.Drawing.Size(87, 21);
            this.modscan.TabIndex = 13;
            this.modscan.Text = "modscan";
            this.modscan.UseVisualStyleBackColor = false;
            // 
            // cmdscan
            // 
            this.cmdscan.AutoSize = true;
            this.cmdscan.BackColor = System.Drawing.Color.Transparent;
            this.cmdscan.ForeColor = System.Drawing.Color.Silver;
            this.cmdscan.Location = new System.Drawing.Point(463, 301);
            this.cmdscan.Name = "cmdscan";
            this.cmdscan.Size = new System.Drawing.Size(86, 21);
            this.cmdscan.TabIndex = 14;
            this.cmdscan.Text = "cmdscan";
            this.cmdscan.UseVisualStyleBackColor = false;
            // 
            // svcscan
            // 
            this.svcscan.AutoSize = true;
            this.svcscan.BackColor = System.Drawing.Color.Transparent;
            this.svcscan.ForeColor = System.Drawing.Color.Silver;
            this.svcscan.Location = new System.Drawing.Point(463, 328);
            this.svcscan.Name = "svcscan";
            this.svcscan.Size = new System.Drawing.Size(81, 21);
            this.svcscan.TabIndex = 15;
            this.svcscan.Text = "svcscan";
            this.svcscan.UseVisualStyleBackColor = false;
            // 
            // getsids
            // 
            this.getsids.AutoSize = true;
            this.getsids.BackColor = System.Drawing.Color.Transparent;
            this.getsids.ForeColor = System.Drawing.Color.Silver;
            this.getsids.Location = new System.Drawing.Point(463, 355);
            this.getsids.Name = "getsids";
            this.getsids.Size = new System.Drawing.Size(75, 21);
            this.getsids.TabIndex = 16;
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
            this.navigateimage.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imagenavigate
            // 
            this.imagenavigate.BackColor = System.Drawing.Color.Transparent;
            this.imagenavigate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imagenavigate.ForeColor = System.Drawing.Color.Silver;
            this.imagenavigate.Location = new System.Drawing.Point(291, 2);
            this.imagenavigate.Name = "imagenavigate";
            this.imagenavigate.Size = new System.Drawing.Size(50, 25);
            this.imagenavigate.TabIndex = 24;
            this.imagenavigate.Text = "...";
            this.imagenavigate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imagenavigate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.imagenavigate.UseVisualStyleBackColor = false;
            this.imagenavigate.Click += new System.EventHandler(this.imagenavigate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(291, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 25);
            this.button2.TabIndex = 27;
            this.button2.Text = "...";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // screenshot
            // 
            this.screenshot.AutoSize = true;
            this.screenshot.BackColor = System.Drawing.Color.Transparent;
            this.screenshot.ForeColor = System.Drawing.Color.Silver;
            this.screenshot.Location = new System.Drawing.Point(704, 36);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(100, 21);
            this.screenshot.TabIndex = 30;
            this.screenshot.Text = "screenshot";
            this.screenshot.UseVisualStyleBackColor = false;
            // 
            // userassist
            // 
            this.userassist.AutoSize = true;
            this.userassist.BackColor = System.Drawing.Color.Transparent;
            this.userassist.ForeColor = System.Drawing.Color.Silver;
            this.userassist.Location = new System.Drawing.Point(704, 63);
            this.userassist.Name = "userassist";
            this.userassist.Size = new System.Drawing.Size(94, 21);
            this.userassist.TabIndex = 31;
            this.userassist.Text = "userassist";
            this.userassist.UseVisualStyleBackColor = false;
            // 
            // shellbags
            // 
            this.shellbags.AutoSize = true;
            this.shellbags.BackColor = System.Drawing.Color.Transparent;
            this.shellbags.ForeColor = System.Drawing.Color.Silver;
            this.shellbags.Location = new System.Drawing.Point(704, 90);
            this.shellbags.Name = "shellbags";
            this.shellbags.Size = new System.Drawing.Size(90, 21);
            this.shellbags.TabIndex = 32;
            this.shellbags.Text = "shellbags";
            this.shellbags.UseVisualStyleBackColor = false;
            // 
            // shimcache
            // 
            this.shimcache.AutoSize = true;
            this.shimcache.BackColor = System.Drawing.Color.Transparent;
            this.shimcache.ForeColor = System.Drawing.Color.Silver;
            this.shimcache.Location = new System.Drawing.Point(704, 117);
            this.shimcache.Name = "shimcache";
            this.shimcache.Size = new System.Drawing.Size(97, 21);
            this.shimcache.TabIndex = 33;
            this.shimcache.Text = "shimcache";
            this.shimcache.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // sessions
            // 
            this.sessions.AutoSize = true;
            this.sessions.BackColor = System.Drawing.Color.Transparent;
            this.sessions.ForeColor = System.Drawing.Color.Silver;
            this.sessions.Location = new System.Drawing.Point(704, 141);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(85, 21);
            this.sessions.TabIndex = 34;
            this.sessions.Text = "sessions";
            this.sessions.UseVisualStyleBackColor = false;
            this.sessions.CheckedChanged += new System.EventHandler(this.sessions_CheckedChanged);
            // 
            // vadinfo
            // 
            this.vadinfo.AutoSize = true;
            this.vadinfo.BackColor = System.Drawing.Color.Transparent;
            this.vadinfo.ForeColor = System.Drawing.Color.Silver;
            this.vadinfo.Location = new System.Drawing.Point(704, 168);
            this.vadinfo.Name = "vadinfo";
            this.vadinfo.Size = new System.Drawing.Size(76, 21);
            this.vadinfo.TabIndex = 35;
            this.vadinfo.Text = "vadinfo";
            this.vadinfo.UseVisualStyleBackColor = false;
            this.vadinfo.CheckedChanged += new System.EventHandler(this.vadinfo_CheckedChanged);
            // 
            // vaddump
            // 
            this.vaddump.AutoSize = true;
            this.vaddump.BackColor = System.Drawing.Color.Transparent;
            this.vaddump.ForeColor = System.Drawing.Color.Silver;
            this.vaddump.Location = new System.Drawing.Point(704, 195);
            this.vaddump.Name = "vaddump";
            this.vaddump.Size = new System.Drawing.Size(88, 21);
            this.vaddump.TabIndex = 36;
            this.vaddump.Text = "vaddump";
            this.vaddump.UseVisualStyleBackColor = false;
            // 
            // memdump
            // 
            this.memdump.AutoSize = true;
            this.memdump.BackColor = System.Drawing.Color.Transparent;
            this.memdump.ForeColor = System.Drawing.Color.Silver;
            this.memdump.Location = new System.Drawing.Point(704, 222);
            this.memdump.Name = "memdump";
            this.memdump.Size = new System.Drawing.Size(95, 21);
            this.memdump.TabIndex = 37;
            this.memdump.Text = "memdump";
            this.memdump.UseVisualStyleBackColor = false;
            // 
            // handles
            // 
            this.handles.AutoSize = true;
            this.handles.BackColor = System.Drawing.Color.Transparent;
            this.handles.ForeColor = System.Drawing.Color.Silver;
            this.handles.Location = new System.Drawing.Point(703, 247);
            this.handles.Name = "handles";
            this.handles.Size = new System.Drawing.Size(80, 21);
            this.handles.TabIndex = 38;
            this.handles.Text = "handles";
            this.handles.UseVisualStyleBackColor = false;
            // 
            // privs
            // 
            this.privs.AutoSize = true;
            this.privs.BackColor = System.Drawing.Color.Transparent;
            this.privs.ForeColor = System.Drawing.Color.Silver;
            this.privs.Location = new System.Drawing.Point(704, 274);
            this.privs.Name = "privs";
            this.privs.Size = new System.Drawing.Size(60, 21);
            this.privs.TabIndex = 39;
            this.privs.Text = "privs";
            this.privs.UseVisualStyleBackColor = false;
            // 
            // pidbox
            // 
            this.pidbox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pidbox.Enabled = false;
            this.pidbox.ForeColor = System.Drawing.Color.Silver;
            this.pidbox.Location = new System.Drawing.Point(116, 92);
            this.pidbox.Name = "pidbox";
            this.pidbox.Size = new System.Drawing.Size(169, 22);
            this.pidbox.TabIndex = 3;
            this.pidbox.TextChanged += new System.EventHandler(this.pidbox_TextChanged);
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
            this.threads.ForeColor = System.Drawing.Color.Silver;
            this.threads.Location = new System.Drawing.Point(704, 328);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(78, 21);
            this.threads.TabIndex = 42;
            this.threads.Text = "threads";
            this.threads.UseVisualStyleBackColor = false;
            // 
            // envars
            // 
            this.envars.AutoSize = true;
            this.envars.BackColor = System.Drawing.Color.Transparent;
            this.envars.ForeColor = System.Drawing.Color.Silver;
            this.envars.Location = new System.Drawing.Point(704, 301);
            this.envars.Name = "envars";
            this.envars.Size = new System.Drawing.Size(73, 21);
            this.envars.TabIndex = 43;
            this.envars.Text = "envars";
            this.envars.UseVisualStyleBackColor = false;
            // 
            // iehistory
            // 
            this.iehistory.AutoSize = true;
            this.iehistory.BackColor = System.Drawing.Color.Transparent;
            this.iehistory.ForeColor = System.Drawing.Color.Silver;
            this.iehistory.Location = new System.Drawing.Point(704, 353);
            this.iehistory.Name = "iehistory";
            this.iehistory.Size = new System.Drawing.Size(83, 21);
            this.iehistory.TabIndex = 44;
            this.iehistory.Text = "iehistory";
            this.iehistory.UseVisualStyleBackColor = false;
            // 
            // malfind
            // 
            this.malfind.AutoSize = true;
            this.malfind.BackColor = System.Drawing.Color.Transparent;
            this.malfind.ForeColor = System.Drawing.Color.Silver;
            this.malfind.Location = new System.Drawing.Point(703, 380);
            this.malfind.Name = "malfind";
            this.malfind.Size = new System.Drawing.Size(75, 21);
            this.malfind.TabIndex = 45;
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
            this.evtlogs.Text = "evtlogs";
            this.evtlogs.UseVisualStyleBackColor = false;
            // 
            // pidcheck
            // 
            this.pidcheck.AutoSize = true;
            this.pidcheck.BackColor = System.Drawing.Color.Transparent;
            this.pidcheck.ForeColor = System.Drawing.Color.Transparent;
            this.pidcheck.Location = new System.Drawing.Point(291, 94);
            this.pidcheck.Name = "pidcheck";
            this.pidcheck.Size = new System.Drawing.Size(18, 17);
            this.pidcheck.TabIndex = 4;
            this.pidcheck.UseVisualStyleBackColor = false;
            this.pidcheck.CheckedChanged += new System.EventHandler(this.pidcheck_CheckedChanged);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.Location = new System.Drawing.Point(704, 404);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(111, 42);
            this.cancel.TabIndex = 48;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.Location = new System.Drawing.Point(17, 141);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(270, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 49;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
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
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::volatility_GUI.Properties.Resources.VPMbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 465);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progresslabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pidcheck);
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
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imagenavigate);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagefiletextbox);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Volatility plugin manager 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagefiletextbox;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button imagenavigate;
        private System.Windows.Forms.FolderBrowserDialog navigateoutput;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.CheckBox pidcheck;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progresslabel;
        private System.Windows.Forms.Label label8;
    }
}

