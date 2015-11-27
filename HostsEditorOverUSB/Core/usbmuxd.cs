using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace HostsEditorOverUSB
{
   abstract class usbmuxd
    {
       [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
       static extern SafeFileHandle CreateFile(
          string lpFileName,
          [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess,
          [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode,
          IntPtr lpSecurityAttributes,
          [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition,
          [MarshalAs(UnmanagedType.U4)] FileAttributes dwFlagsAndAttributes,
          IntPtr hTemplateFile);

        public abstract void init();
        public static int reverse_connection(iPhone device, int v1, int v2, IntPtr unknown)
        {
            v1 = ~v1 & v2;
            int result = 0x10F;
            return result - v1;
        }
    }
}
