using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HostsEditorOverUSB
{
    class iPhoneFileHelper
    {
        static String line, output;
        public static String ReadFromDevice(iPhone device, string path)
        {
            var fileReader = iPhoneFile.OpenRead(device, path);
            using (var fileStream = new StreamReader(fileReader))
            {
                fileReader.Seek(0, SeekOrigin.Begin);           
                while ((line = fileStream.ReadLine()) != null)
                {
                    output += String.Format(line + Environment.NewLine);
                }
                return output;
            }
        }

        public static bool WriteToDevice(iPhone device, string path, string[] lines)
        {
            try
            {
                var fileWriter = iPhoneFile.OpenWrite(device, path);
                using (var fileStream = new StreamWriter(fileWriter))
                {
                    fileWriter.Seek(0, SeekOrigin.Begin);
                    foreach (String line in lines)
                    {
                        fileStream.WriteLine(line + Environment.NewLine);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
