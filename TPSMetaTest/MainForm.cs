using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using TPSMetaTest.Properties;

namespace TPSMetaTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitMainForm();
        }

        /// <summary>
        /// Init on contruction
        /// </summary>
        private void InitMainForm()
        {
            this.Icon = Resources.icon;

            Version ver = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text += " V" + ver.Major + "." + ver.Minor + "." + ver.Build;
        }
    }
}
