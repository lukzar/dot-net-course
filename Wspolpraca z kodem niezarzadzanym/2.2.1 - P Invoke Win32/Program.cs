using System;
using System.Text;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace PInvokeWin32
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 64;

            StringBuilder name = new StringBuilder(length);

            Win32.GetUserName(name, ref length);
            CatchWin32Error("GetUserName", Marshal.GetLastWin32Error());

            Win32.MessageBox(0, name.ToString(), string.Empty, 0);
            CatchWin32Error("MessageBox", Marshal.GetLastWin32Error());

            Win32.MessageBox(0, name.ToString(), string.Empty, 7);
            CatchWin32Error("MessageBox", Marshal.GetLastWin32Error());
        }

        public static void CatchWin32Error(string functionName, int errorCode)
        {
            Win32Exception ex = new Win32Exception(errorCode);

            Console.WriteLine("[Error code] {0}() : ({1}) {2} ", functionName, errorCode, ex.Message);
        }
    }
}
