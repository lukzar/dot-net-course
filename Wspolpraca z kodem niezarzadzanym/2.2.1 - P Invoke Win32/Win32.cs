using System;
using System.Text;
using System.Runtime.InteropServices;

namespace PInvokeWin32
{
    class Win32
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool GetUserName(StringBuilder sb, ref int length);
    }
}
