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
                seg.Name = "Data " + i.ToString();
                flowLayoutPanel1.Controls.Add(seg.GetLabel());
            }
        }

        private void flowLayoutPanel1_MouseEnter(object sender, System.EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }
    }
}
