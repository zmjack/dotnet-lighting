using System;

namespace Lighting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NativeMethods.SystemParametersInfoW(NativeConstants.SPI_SETSCREENSAVEACTIVE, 0, IntPtr.Zero, 0);
                var esFlags = NativeConstants.ES_CONTINUOUS | NativeConstants.ES_DISPLAY_REQUIRED | NativeConstants.ES_SYSTEM_REQUIRED;
                NativeMethods.SetThreadExecutionState(esFlags);
                Console.WriteLine("Enable always lighting...");
                Console.WriteLine();
                Console.WriteLine("  Press [Esc] to exit...");
                while (Console.ReadKey(true).Key == ConsoleKey.Escape) break;
            }
            finally
            {
                NativeMethods.SystemParametersInfoW(NativeConstants.SPI_SETSCREENSAVEACTIVE, 1, IntPtr.Zero, 0);
                NativeMethods.SetThreadExecutionState(NativeConstants.ES_CONTINUOUS);
            }
        }
    }
}
