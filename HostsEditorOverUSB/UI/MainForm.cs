using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HostsEditorOverUSB
{
    public partial class MainForm : Form
    {
        public static iPhone iDevice = null;
        public static MainForm instance = null;
        public MainForm()
        {
            InitializeComponent();
            Utils.Init();
            instance = this;
            animateTimer.Interval = 500;
            animateTimer.Start();
            logBox.AppendText("This is an early beta version!");
            AppendTextBox("Please connect your iOS-device via USB.");
            iDevice = new iPhone();
            iDevice.Connect += new ConnectEventHandler(onConnectHandler);
            iDevice.Disconnect += new ConnectEventHandler(onDisconnectHandler);
        }
        private void animateTimer_Tick(object sender, EventArgs e)
        {
            this.timeLbl.Text = Utils.getTime();
            bool isDefaultTxt = (waitingLbl.Text == "Waiting for USB-Handshake");
            if (isDefaultTxt)
            {
                waitingLbl.Text = String.Format("Waiting for USB-Handshake.");
            }
            else if (waitingLbl.Text == "Waiting for USB-Handshake.")
            {
                waitingLbl.Text = String.Format("Waiting for USB-Handshake..");
            }
            else if (waitingLbl.Text == "Waiting for USB-Handshake..")
            {
                waitingLbl.Text = String.Format("Waiting for USB-Handshake...");
            }
            else
            {
                waitingLbl.Text = String.Format("Waiting for USB-Handshake.");
            }
            //   isDefaultText = !isDefaultText; 
        }

        public void onConnectHandler(object sender, ConnectEventArgs args)
        {
            AppendTextBox("Device connected (Callback " + args.GetHashCode() + ")");
            AppendTextBox("");
            if (iDevice.Exists("/usr/libexec/afc2d"))
            {
                // Continue...      
                    bool AFC2_installed = iDevice.Exists("/usr/libexec/afc2d");
                    DialogResult dr = MessageBox.Show("A new device connected.\nName: " + iDevice.GetDeviceName + "\niOS: " + iDevice.GetDeviceVersion + "\nJailbroken: " + iDevice.IsJailbreak + "\nAFC2 installed: " + AFC2_installed + "\nDo you want to edit the hosts file?", "New device!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    switch (dr)
                    {
                        case DialogResult.Yes:                                                             
                              HostsForm hf = new HostsForm();
                              hf.gimmedatdevice(iDevice);
                              hf.ShowDialog();
                              break;
                        default:
                              // ?
                              break;
                    }
                
            }
            else
            {
                MessageBox.Show("AFC2 is required to continue! \nYou can download it at Cydia. \nSearch \"Apple File Conduit 2\"", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void onDisconnectHandler(object sender, ConnectEventArgs args)
        {

        }
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {           
               this.Invoke(new Action<string>(AppendTextBox), new object[] { value });             
               return;
            }
            logBox.AppendText(String.Format(System.Environment.NewLine + value));
        }

        private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.saveLogs(this.logBox.Lines);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coded by ExPl0itR | Made with C#", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can easily edit your hosts file without \naccessing it through the phone.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
