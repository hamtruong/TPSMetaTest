using System;
using System.Windows.Forms;
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

        private void ctlBtnOpen_Click(object sender, EventArgs e)
        {
            dialogOpenProtocol.Filter = "Protocol file|*." + Settings.Default.FILE_EXTENSION;
            if (dialogOpenProtocol.ShowDialog() == DialogResult.OK)
            {
                using (ProtocolViewForm pvform = new ProtocolViewForm())
                {
                    pvform.ShowDialog();
                }
            }
        }
    }
}
