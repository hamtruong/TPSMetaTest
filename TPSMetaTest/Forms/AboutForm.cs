using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPSMetaTest.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            InitForm();
        }

        private void InitForm()
        {
            ctlLblVersion.Text = "Version " + Program.version;
        }

        private void ctlLinklblLink_Click(object sender, EventArgs e)
        {
            // Navigate to Github page
            System.Diagnostics.Process.Start("https://github.com/hamtruong/TPSMetaTest");
        }

        private void ctlLinklblEmail_Click(object sender, EventArgs e)
        {
            // Open default email handler
            System.Diagnostics.Process.Start("mailto:quangyendn@gmail.com?subject=TPSMetaTest-Question");
        }
    }
}
