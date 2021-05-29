using System;
using System.Runtime.InteropServices;

namespace Lighting
{
    public static class NativeMethods
    {
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

        [DllImport("kernel32.dll", EntryPoint = "SetThreadExecutionState")]
        public static extern uint SetThreadExecutionState(uint esFlags);

    }
}
