using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Management;
using System.Collections.Specialized;
using System.Text.RegularExpressions;


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace New_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Init_Data();
            panel1.BackColor = Color.FromArgb(170, Color.Black);
           
            

        }
        public static string Base64Decode(string sifreliMetin)
        {

            var sifreliMetinBaytlari = Convert.FromBase64String(sifreliMetin);
            return Encoding.UTF8.GetString(sifreliMetinBaytlari);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            



        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    guna2TextBox1.Text = Properties.Settings.Default.Username;
                    guna2TextBox2.Text = Properties.Settings.Default.Password;

                }
                else
                {
                    guna2TextBox1.Text = Properties.Settings.Default.Username;
                    guna2TextBox2.Text = Properties.Settings.Default.Password;
                }
            }
        }
        private void Save_Data()
        {
            if (true)
            {
                Properties.Settings.Default.Username = guna2TextBox1.Text.Trim();
                Properties.Settings.Default.Password = guna2TextBox2.Text.Trim();
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string Modem()
        {
            var webClient = new WebClient();
            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;
            webClient.Dispose();
            return dnsString;
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string loginData;

            Save_Data();

            WebClient client = new WebClient();
            client.Headers["User-Agent"] = "LegendaryCheats/2.0";
            loginData = client.DownloadString($"https://www.legendarycheats.net/benböyleapi.php?username=" + guna2TextBox1.Text + "&password=" + guna2TextBox2.Text);







            MessageBox.Show($"{loginData}");

            var logindetails = JObject.Parse(loginData);

            

               


            if (guna2TextBox1.Text == "" && guna2TextBox2.Text == "")
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Boş Alan Bırakmayınız!";
                notifyIcon1.BalloonTipTitle = "LegendUI";
                notifyIcon1.Text = "LegendUI";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(30000);
                Properties.Settings.Default.LoginTrue = false;
                return;
            }

           

           

            try
            {
                string.Concat(logindetails["user"]["username"]);
            }
            catch
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "Hatalı Şifre Veya Kullanıcı Adı !";
                notifyIcon1.BalloonTipTitle = "LegendUI";
                notifyIcon1.Text = "LegendUI";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(30000);
                Properties.Settings.Default.LoginTrue = false;
                return;
            }

            string bannedcode = logindetails["user"]["user_title"].ToString();

            if (bannedcode == "Banned")
            {
                MessageBox.Show("Banned Code:[0x3]", "LegendUI Security");
                Properties.Settings.Default.LoginTrue = false;
                return;
            }

           

            MainForm mainform = new MainForm();

            string.Concat(logindetails["user"]["username"]);

            string usernameveri = logindetails["user"]["username"].ToString();

            string.Concat(logindetails["user"]["message_count"]);

            string messagecountveri = logindetails["user"]["message_count"].ToString();

            string.Concat(logindetails["user"]["reaction_score"]);

            string reactionveri = logindetails["user"]["reaction_score"].ToString();

            string.Concat(logindetails["user"]["profile_banner_urls"]["l"]);

            string profilephotoveri = logindetails["user"]["profile_banner_urls"]["l"].ToString();

            string.Concat(logindetails["user"]["avatar_urls"]["o"]);

            string avatarphotoveri = logindetails["user"]["avatar_urls"]["o"].ToString();


            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject maObject in mbsList)
            {
                id = maObject["ProcessorId"].ToString();
                break;
            }
         

            string bilgisayarAdi = Dns.GetHostName();
           
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            client.Headers["User-Agent"] = "LegendaryCheats/2.0";
            client.Headers["User-Agent"] = "LegendaryCheats/1.0";

            //string te4 = client.DownloadString("https://legendui.xyz/panel/admin/backend/user-ekle.php");



//            try
//            {


//                using (WebClient client1 = new WebClient())
//                {
//                    // Post URL
//                    client.Headers["User-Agent"] = "LegendaryCheats/2.0";
//                    client.Headers["User-Agent"] = "LegendaryCheats/1.0";
//                    string postUrl = "https://legendui.xyz/panel/admin/backend/user-ekle.php";

//                    client.UploadValues(postUrl, new NameValueCollection()
//{
//{ "username", usernameveri },
//{ "serial", id },
//{ "ip", Modem() },
//{ "localuser", Environment.UserName },
//{ "pcname", bilgisayarAdi },
//});

//                }
//            }
//            catch
//            {
//                MessageBox.Show("cURL Data Post failed Code:[0x37]");
//                //MessageBox.Show((client.DownloadString("https://legendui.xyz/panel/admin/backend/user-ekle.php")));
//                Properties.Settings.Default.LoginTrue = false;
//                return;
//            }

            Properties.Settings.Default.LoginTrue = true;

            mainform.Show();
            this.Hide();
            mainform.usernameAveri = usernameveri;
            mainform.messagecountAveri = messagecountveri;
            mainform.reactionAveri = reactionveri;
            mainform.profilephotoAveri = profilephotoveri;
            mainform.avatarphotoAveri = avatarphotoveri;
            mainform.titleAveri = bannedcode;

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            System.Diagnostics.Process.Start("https://legendarycheats.net/register/");
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
