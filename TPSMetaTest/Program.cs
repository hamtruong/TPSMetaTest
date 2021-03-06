﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;

namespace TPSMetaTest
{
    static class Program
    {
        /// <summary>
        /// Create a mutex from application GUID
        /// </summary>
        static Mutex mutex = new Mutex(true, Assembly.GetExecutingAssembly().GetType().GUID.ToString());
        public static String version;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Version ver =  Assembly.GetExecutingAssembly().GetName().Version;
                version = ver.Major + "." + ver.Minor + "." + ver.Build;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("There is already a running instance of TPSMetaTest.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
