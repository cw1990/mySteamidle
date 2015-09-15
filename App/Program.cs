using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        [DllImport("steam_api.dll", EntryPoint = "SteamAPI_Init")]
        private static extern int win_Steam();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Environment.SetEnvironmentVariable("SteamAppId", args[0]);
                win_Steam();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
