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
using System.IO;
using System.Diagnostics;
using System.Management;
using System.Collections.Specialized;
using System.Text.RegularExpressions;


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace New_UI
{
    public partial class Update : Form
    {
        public static string AppVersion = "1010";

        public Update()
        {
            InitializeComponent();
            guna2Button1.Visible = false;
            this.Show();
        }
        void programi_Sil()
        {
            Process islem = new Process();
            ProcessStartInfo islem_Bilgisi = new ProcessStartInfo("cmd.exe", "/C del \"" + Application.ExecutablePath + "\"");
            islem_Bilgisi.CreateNoWindow = true;
            islem_Bilgisi.UseShellExecute = false;
            islem = Process.Start(islem_Bilgisi);
            islem.Close();
        }
       
        public static string Base64Decode(string sifreliMetin)
        {

            var sifreliMetinBaytlari = Convert.FromBase64String(sifreliMetin);
            return Encoding.UTF8.GetString(sifreliMetinBaytlari);
        }

        private void Update_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LoginTrue == true)
            {
            }
            verikontrol();

            hide();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void verikontrol()
        {
            //var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            //ManagementObjectCollection mbsList = mbs.Get();
            //string id = "";
            //foreach (ManagementObject maObject in mbsList)
            //{
            //    id = maObject["ProcessorId"].ToString();
            //    break;
            //}

            //ServicePointManager.Expect100Continue = true;
            //ServicePointManager.DefaultConnectionLimit = 9999;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            //WebClient client = new WebClient();
            //client.Headers["User-Agent"] = "LegendaryCheats/2.0";
            //client.Headers["User-Agent"] = "LegendaryCheats/1.0";
            //string veri = client.DownloadString("https://legendui.xyz/panel/admin/backend/ban-kontrol.php?serial_bans=" + $"{id}");
                        

            //var veriD = JObject.Parse(veri);

            //string bansveri = veriD["serial_ban"].ToString();
            ////MessageBox.Show((bansveri));

            //if (bansveri == "True")
            //{
            //    MessageBox.Show("Hesabınız Kalıcı Olarak Askıya Alınmıştır Code:[0x11]                            " +
            //        "Your Account Has Been Permanently Suspended Code:[0x11]", "LegendUI Security");


            //    Environment.Exit(0);
            //}
            //else
            //{
               
            //}

        }
        private void hide()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            // İnternet kontrol & TEST Font setup
            WebClient client = new WebClient();
           // client.DownloadFile("https://github.com/Utku1114/AlphaUI/raw/main/font/OpenSans-Bold.ttf", @"C:\Windows\Fonts\OpenSans-Bold.ttf");
            try
            {
                client.DownloadString("https://google.com");
            }
            catch
            {
                MessageBox.Show("Connection Failed Code:[0x11]");
            }
            // Version kontrol
            string vDataL = client.DownloadString("https://raw.githubusercontent.com/Utku1114/AlphaUI/main/docs/version.lcpg");

            vDataL = Base64Decode(vDataL);

            var vDataD = JObject.Parse(vDataL);
            string.Concat(vDataD["version"]);

            string vData = vDataD["version"].ToString();

            if (vData == AppVersion)
            {
                

                //login.Show();
                //hide();
               
                guna2Button1.Visible = true;
                

            }
            else
            {
                startDownload();
            }

        }
     
        private void startDownload()
        {
           
            //Download ettik
            guna2HtmlLabel2.Text = "INSTALLING";
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            client.Headers["User-Agent"] = "LegendaryCheats/2.0";
            client.Headers["User-Agent"] = "LegendaryCheats/1.0";
            client.DownloadFileAsync(new Uri("https://legendarycheats.net/Loader/Loader.exe"), Application.StartupPath + @"\" + "X7YuiS1K11.exe");
        }
        private void repairControl()
        {
            
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Bir dizin geride oluşan exe'yi eski yerine koymayı ve dll leri yanına koymayı unutmayın !!");
            //İndirme bitişi0
            System.Diagnostics.Process.Start((Application.StartupPath + @"\" + "X7YuiS1K9.exe")); // Yenisini çalıştırdıl
           
            programi_Sil();  // Programı sildik

            Environment.Exit(0);  // Çıkış
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.DefaultConnectionLimit = 9999;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            // Progessbar için download/totaldownload barı
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            guna2HtmlLabel3.Text = string.Format("{0}",
        (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
        

            guna2HtmlLabel4.Text = string.Format("/ {0} MB",
        
        (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00")));
            guna2ProgressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Uygulamadan çıktık
            Application.Exit();
        }

        private void bt1()
        {
            ////// Kullanmıyorum .
            this.Hide();
            MessageBox.Show("edf");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show(); // Login Açıldı
            this.Hide();  // Update Kapandı
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.LoginTrue = false;

            Login login = new Login();
            this.Hide();
            login.Show();
                 
        }

      

    }
}
