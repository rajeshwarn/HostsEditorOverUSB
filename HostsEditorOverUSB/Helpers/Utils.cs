using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
namespace HostsEditorOverUSB
{
    class Utils
    {
        public static void Init()
        {
            iTunesCheck();
        }
        public static void iTunesCheck()
        {
            const string __iTunesPath = @"C:\Program Files (x86)\iTunes\";
            const string __iTunesPath32 = @"C:\Program Files\iTunes";
            if (!System.IO.Directory.Exists(__iTunesPath) || !System.IO.Directory.Exists(__iTunesPath32))
            {
                MessageBox.Show("Sorry, you need to have iTunes installed in order to continue!", "Ooops...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Environment.Exit(1);
                // Exit
            }
        }
        public static void saveLogs(string[] lines)
        {
            try
            {
                if(!Directory.Exists("logs"))
                    Directory.CreateDirectory("logs");
                System.IO.StreamWriter writer = new System.IO.StreamWriter(Environment.CurrentDirectory + @"\logs\log_" + Utils.getTime().Replace(":", "_") + ".txt");
                writer.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
                writer.WriteLine("START LOG " + Utils.getTime());
                writer.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
                writer.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
                writer.WriteLine("END LOG " + Utils.getTime());
                writer.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+");
                writer.Close();
                MessageBox.Show("Logs saved :)!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
              MessageBox.Show("Could not save logfile: " + exception.Message, "Error saving logfiles", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        public static string getTime()
        {
            return System.DateTime.UtcNow.ToString();
        }

    }
}