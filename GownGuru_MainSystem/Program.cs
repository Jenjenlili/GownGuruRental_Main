﻿using GownGuru_MainSystem.GOWN;
using GownGuru_MainSystem.SETTINGS;
using GownGuru_MainSystem.LOGIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GownGuru_MainSystem.Customized;

namespace GownGuru_MainSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MAIN());
        }
    }
}
