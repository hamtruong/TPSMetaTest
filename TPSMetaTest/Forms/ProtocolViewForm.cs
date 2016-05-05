using System.Windows.Forms;
using TPSMetaTest.Properties;
using TPSMetaTest.Components;
using TPSMetaTest.Data;

namespace TPSMetaTest
{
    public partial class ProtocolViewForm : Form
    {
        public ProtocolViewForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            this.Icon = Resources.icon;

            for (int i = 0; i < 20; i++)
            {
                Segment seg = new Segment();
                seg.Name = "Request dat " + i.ToString();
                flowLayoutPanel1.Controls.Add(seg.GetLabel());
            }

            for (int i = 0; i < 10; i++)
            {
                Segment seg = new Segment();
                seg.Name = "Response " + i.ToString();
                flowLayoutPanel2.Controls.Add(seg.GetLabel());
            }
        }

        private void flowLayoutPanel_MouseEnter(object sender, System.EventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            panel.Focus();
        }

        private void ProtocolViewForm_Shown(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
