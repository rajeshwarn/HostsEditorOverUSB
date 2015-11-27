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
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
namespace HostsEditorOverUSB
{
    public partial class HostsForm : Form
    {
        iPhone iDevice = null;
        //iPhoneDFUDevice iDeviceDFU = null;

        public HostsForm()
        {
            InitializeComponent();
            this.iPadPicture.Visible = false;
            this.iPodPicture.Visible = false;
            this.iPhonePicture.Visible = false;
            this.FormClosing += (sender, args) =>
            {
            };
        }

        public void gimmedatdevice(iPhone device)
        {       
            iDevice = device;
        }

        private void HostsForm_Shown(object sender, EventArgs e)
        {
            int count = 0;
            this.deviceName.Text = iDevice.GetDeviceName;
            this.iOSVersion.Text = iDevice.GetDeviceVersion;
            this.cpuArch.Text = iDevice.GetCPUArchitecture;
            try
            {
                foreach (var folder in iDevice.GetDirectories("/var/mobile/Containers/Bundle/Application"))
                {
                    count++;
                }
                if (count != 0)
                {
                    this.installedApps.Text = count.ToString();
                }
            }
            catch (Exception foldersNotFound)
            {
                MessageBox.Show("Failed to retrieve application path,\nyou're under iOS 8.\nThis will be optimized in in the future.", "Hmm.", MessageBoxButtons.OK, MessageBoxIcon.Warning);          
            }
            string deviceType = iDevice.GetProductType.Remove(iDevice.GetProductType.Length - 3);
            switch (deviceType)
            {
                case "iPad":
                    this.iPadPicture.Visible = true;
                    break;
                case "iPhone":
                    this.iPhonePicture.Visible = true;
                    break;
                case "iPod":
                    this.iPodPicture.Visible = true;
                    break;
            }
            hostsBox.AppendText(iPhoneFileHelper.ReadFromDevice(iDevice, "/etc/hosts") + Environment.NewLine);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("By clicking \"OK\", you send the file you edited above.\nClick \"OK\" when you edited the file successfully.\nClick \"Cancel\" when you made a mistake", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Cancel:
                    this.Close();
                    break;
                case DialogResult.OK:
                    iPhoneFileHelper.WriteToDevice(iDevice, "/etc/hosts", hostsBox.Lines);
                    break;
            }
        }

    }
}
