using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class DllLib
    {
        [DllImport(@"C:\Users\Юлия Хабарова\Desktop\Dll Hab\DLL3\x64\Debug\Dll3.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr LoadPicture([MarshalAs(UnmanagedType.BStr)] string path, int newColor, int borderSize);
    }
}
