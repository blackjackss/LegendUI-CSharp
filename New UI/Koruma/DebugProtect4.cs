using System;
using System.Runtime.InteropServices;
using System.Text;

namespace New_UI.Koruma
{
    class DebugProtect4
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        delegate bool fVirtualProtect(IntPtr lpAddress,
        UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        public static void AntiDebug()
        {
            try
            {
                /*
                    xor eax, eax
                    ret
                */
                byte[] b1gShellCode = new byte[] { 0x31, 0xC0, 0xC3 };

                //IsDebuggerPresent
                var secretProcedure = GetProcAddress(GetModuleHandle(Encoding.ASCII.GetString(new byte[] { 0x4b, 0x45, 0x52, 0x4e, 0x45, 0x4c, 0x42, 0x41, 0x53, 0x45, 0x2e, 0x64, 0x6c, 0x6c })), Encoding.ASCII.GetString(new byte[] { 0x49, 0x73, 0x44, 0x65, 0x62, 0x75, 0x67, 0x67, 0x65, 0x72, 0x50, 0x72, 0x65, 0x73, 0x65, 0x6e, 0x74 }));

                //VirtualProtect ama delegate olarak ( ¯\_(ツ)_/¯ )
                var VirtualProtect = Marshal.GetDelegateForFunctionPointer<fVirtualProtect>(GetProcAddress(GetModuleHandle(Encoding.ASCII.GetString(new byte[] { 0x6b, 0x65, 0x72, 0x6e, 0x65, 0x6c, 0x33, 0x32, 0x2e, 0x64, 0x6c, 0x6c })), Encoding.ASCII.GetString(new byte[] { 0x56, 0x69, 0x72, 0x74, 0x75, 0x61, 0x6c, 0x50, 0x72, 0x6f, 0x74, 0x65, 0x63, 0x74 })));

                VirtualProtect(secretProcedure, new UIntPtr(0x1000), 0x40, out uint oldOne);

                Marshal.Copy(b1gShellCode, 0, secretProcedure, b1gShellCode.Length);

                VirtualProtect(secretProcedure, new UIntPtr(0x1000), oldOne, out oldOne);
            }
            catch (Exception)
            {
                //Potansiyel kod atlamasi ??
                Environment.FailFast(null);
                Environment.Exit(0);
            }
        }
    }
    
}
