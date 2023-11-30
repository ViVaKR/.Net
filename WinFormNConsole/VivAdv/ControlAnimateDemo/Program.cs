﻿using System;
using System.Windows.Forms;

namespace ControlAnimateDemo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}


//static void Main()
//{
//    if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
//    ApplicationConfiguration.Initialize();
//    Application.Run(new MainForm());
//}

//[System.Runtime.InteropServices.DllImport("user32.dll")]
//private static extern bool SetProcessDPIAware();