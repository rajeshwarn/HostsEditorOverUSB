using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
namespace HostsEditorOverUSB
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.progress.Location = new Point(68, 183);
            BeginChecking();
        }

        public async void BeginChecking()
        {
            
                this.progress.Text = "Checking libs...";
                if (!Directory.Exists("logs"))
                {
                    Directory.CreateDirectory("logs");
                }
                if (!Directory.Exists("lib"))
                {
                    Directory.CreateDirectory("lib");
                }
            
                if (!File.Exists("lib/iTunesMobileDevice.dll"))
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile("http://expl0itr.bplaced.net/home/iTunesMobileDevice.dll", "lib/iTunesMobileDevice.dll");
                        MessageBox.Show("You apparently deleted iTunesMobileDevice.dll!\nI redownloaded it for you.\nPlease do not delete required librarys..", "What the sh*t?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                await Task.Delay(1000);
                this.progress.Location = new Point(79, 183);
                this.progress.Text = "Initializing UI...";
                await Task.Delay(1000);
                MainForm mf = new MainForm();
                this.Hide();
                mf.FormClosed += (s, args) => this.Close();
                mf.ShowDialog();               
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
