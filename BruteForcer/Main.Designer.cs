namespace AccountChecker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.start = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.TextBox();
            this.lblaccounts = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.statistics = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblthreads = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblcheckeds = new System.Windows.Forms.Label();
            this.lblextants = new System.Windows.Forms.Label();
            this.lblgoods = new System.Windows.Forms.Label();
            this.lblbads = new System.Windows.Forms.Label();
            this.lblerrors = new System.Windows.Forms.Label();
            this.lblbadproxies = new System.Windows.Forms.Label();
            this.lblproxies = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.telegramservice = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.NumericUpDown();
            this.bottoken = new System.Windows.Forms.TextBox();
            this.chatid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveformat = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadproxy = new System.Windows.Forms.Button();
            this.statistics.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threads)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(162, 34);
            this.start.TabIndex = 0;
            this.start.Text = "Start BruteForcing";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // logs
            // 
            this.logs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logs.BackColor = System.Drawing.Color.White;
            this.logs.Location = new System.Drawing.Point(351, 12);
            this.logs.MaxLength = 999999999;
            this.logs.Multiline = true;
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(297, 351);
            this.logs.TabIndex = 10;
            // 
            // lblaccounts
            // 
            this.lblaccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblaccounts.Location = new System.Drawing.Point(3, 0);
            this.lblaccounts.Name = "lblaccounts";
            this.lblaccounts.Size = new System.Drawing.Size(153, 33);
            this.lblaccounts.TabIndex = 4;
            this.lblaccounts.Text = "Accounts: 0";
            this.lblaccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(12, 369);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(636, 23);
            this.pb.TabIndex = 5;
            // 
            // statistics
            // 
            this.statistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statistics.Controls.Add(this.tableLayoutPanel1);
            this.statistics.Location = new System.Drawing.Point(180, 12);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(165, 351);
            this.statistics.TabIndex = 6;
            this.statistics.TabStop = false;
            this.statistics.Text = "Statistics";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblaccounts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblthreads, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbltime, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblcheckeds, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblextants, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblgoods, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblbads, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblerrors, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblbadproxies, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblproxies, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.997568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.997568F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 330);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblthreads
            // 
            this.lblthreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblthreads.Location = new System.Drawing.Point(3, 295);
            this.lblthreads.Name = "lblthreads";
            this.lblthreads.Size = new System.Drawing.Size(153, 35);
            this.lblthreads.TabIndex = 5;
            this.lblthreads.Text = "Active threads: 0";
            this.lblthreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltime
            // 
            this.lbltime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltime.Location = new System.Drawing.Point(3, 263);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(153, 32);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "Elapsed time: 00:00:00";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcheckeds
            // 
            this.lblcheckeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcheckeds.Location = new System.Drawing.Point(3, 66);
            this.lblcheckeds.Name = "lblcheckeds";
            this.lblcheckeds.Size = new System.Drawing.Size(153, 33);
            this.lblcheckeds.TabIndex = 4;
            this.lblcheckeds.Text = "Checkeds: 0";
            this.lblcheckeds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblextants
            // 
            this.lblextants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblextants.Location = new System.Drawing.Point(3, 99);
            this.lblextants.Name = "lblextants";
            this.lblextants.Size = new System.Drawing.Size(153, 33);
            this.lblextants.TabIndex = 4;
            this.lblextants.Text = "Extants: 0";
            this.lblextants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgoods
            // 
            this.lblgoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblgoods.Location = new System.Drawing.Point(3, 132);
            this.lblgoods.Name = "lblgoods";
            this.lblgoods.Size = new System.Drawing.Size(153, 33);
            this.lblgoods.TabIndex = 4;
            this.lblgoods.Text = "Goods: 0";
            this.lblgoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbads
            // 
            this.lblbads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblbads.Location = new System.Drawing.Point(3, 165);
            this.lblbads.Name = "lblbads";
            this.lblbads.Size = new System.Drawing.Size(153, 33);
            this.lblbads.TabIndex = 4;
            this.lblbads.Text = "Bads: 0";
            this.lblbads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblerrors
            // 
            this.lblerrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblerrors.Location = new System.Drawing.Point(3, 198);
            this.lblerrors.Name = "lblerrors";
            this.lblerrors.Size = new System.Drawing.Size(153, 33);
            this.lblerrors.TabIndex = 4;
            this.lblerrors.Text = "Errors: 0";
            this.lblerrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbadproxies
            // 
            this.lblbadproxies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblbadproxies.Location = new System.Drawing.Point(3, 231);
            this.lblbadproxies.Name = "lblbadproxies";
            this.lblbadproxies.Size = new System.Drawing.Size(153, 32);
            this.lblbadproxies.TabIndex = 4;
            this.lblbadproxies.Text = "Bad proxies: 0";
            this.lblbadproxies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblproxies
            // 
            this.lblproxies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblproxies.Location = new System.Drawing.Point(3, 33);
            this.lblproxies.Name = "lblproxies";
            this.lblproxies.Size = new System.Drawing.Size(153, 33);
            this.lblproxies.TabIndex = 4;
            this.lblproxies.Text = "Proxies: 0";
            this.lblproxies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(12, 52);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(162, 34);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop BruteForcing";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 92);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(162, 34);
            this.load.TabIndex = 2;
            this.load.Text = "Load Accounts";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 172);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(162, 34);
            this.result.TabIndex = 4;
            this.result.Text = "Result Folder";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // telegramservice
            // 
            this.telegramservice.AutoSize = true;
            this.telegramservice.Location = new System.Drawing.Point(12, 284);
            this.telegramservice.Name = "telegramservice";
            this.telegramservice.Size = new System.Drawing.Size(151, 17);
            this.telegramservice.TabIndex = 7;
            this.telegramservice.Text = "Send goods to Telegram";
            this.telegramservice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Threads:";
            // 
            // threads
            // 
            this.threads.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threads.Location = new System.Drawing.Point(74, 212);
            this.threads.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(100, 22);
            this.threads.TabIndex = 5;
            this.threads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.threads.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // bottoken
            // 
            this.bottoken.Location = new System.Drawing.Point(74, 310);
            this.bottoken.Name = "bottoken";
            this.bottoken.Size = new System.Drawing.Size(100, 22);
            this.bottoken.TabIndex = 8;
            this.bottoken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chatid
            // 
            this.chatid.Location = new System.Drawing.Point(74, 338);
            this.chatid.Name = "chatid";
            this.chatid.Size = new System.Drawing.Size(100, 22);
            this.chatid.TabIndex = 9;
            this.chatid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Bot token:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Chat Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Save format:";
            // 
            // saveformat
            // 
            this.saveformat.Location = new System.Drawing.Point(12, 256);
            this.saveformat.Name = "saveformat";
            this.saveformat.Size = new System.Drawing.Size(162, 22);
            this.saveformat.TabIndex = 6;
            this.saveformat.Text = "<USER>:<PASS>|<CAP>";
            this.saveformat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadproxy
            // 
            this.loadproxy.Location = new System.Drawing.Point(12, 132);
            this.loadproxy.Name = "loadproxy";
            this.loadproxy.Size = new System.Drawing.Size(162, 34);
            this.loadproxy.TabIndex = 3;
            this.loadproxy.Text = "Load Proxies";
            this.loadproxy.UseVisualStyleBackColor = true;
            this.loadproxy.Click += new System.EventHandler(this.loadproxy_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 404);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.chatid);
            this.Controls.Add(this.saveformat);
            this.Controls.Add(this.bottoken);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telegramservice);
            this.Controls.Add(this.result);
            this.Controls.Add(this.loadproxy);
            this.Controls.Add(this.load);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(676, 443);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Checker | LilToba";
            this.statistics.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.threads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.Label lblaccounts;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.GroupBox statistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblerrors;
        private System.Windows.Forms.Label lblcheckeds;
        private System.Windows.Forms.Label lblbads;
        private System.Windows.Forms.Label lblextants;
        private System.Windows.Forms.Label lblgoods;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.CheckBox telegramservice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown threads;
        private System.Windows.Forms.TextBox bottoken;
        private System.Windows.Forms.TextBox chatid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox saveformat;
        private System.Windows.Forms.Label lblthreads;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblbadproxies;
        private System.Windows.Forms.Label lblproxies;
        private System.Windows.Forms.Button loadproxy;
    }
}

