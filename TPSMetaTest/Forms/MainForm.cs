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
using TPSMetaTest.Forms;

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

            this.Text += " V" + Program.version;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutForm ab = new AboutForm())
            {
                ab.StartPosition = FormStartPosition.CenterParent;
                ab.ShowDialog();
            }
        }
    }
}
