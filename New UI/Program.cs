using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_UI
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Update());

            Koruma.DumpProtect1.AntiDump();
            Koruma.Scanner.ScanAndKill();
            Koruma.DebugProtect4.AntiDebug();

            if (Koruma.DebugProtect1.PerformChecks() == 1)
            {
                Environment.FailFast("");
            }

            if (Koruma.DebugProtect2.PerformChecks() == 1)
            {
                Environment.FailFast("");
            }

            System.Threading.Thread workerThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    Koruma.Scanner.ScanAndKill();

                    if (Koruma.DebugProtect1.PerformChecks() == 1)
                    {
                        Environment.FailFast("");
                    }

                    if (Koruma.DebugProtect2.PerformChecks() == 1)
                    {
                        Environment.FailFast("");
                    }

                    System.Threading.Thread.Sleep(1000);
                }
            });

            Koruma.DebugProtect3.HideOSThreads();
        }
    }
}
