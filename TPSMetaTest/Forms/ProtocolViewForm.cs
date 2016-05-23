using System.Windows.Forms;
using TPSMetaTest.Properties;
using TPSMetaTest.Data;
using TPSMetaTest.Components;
using System;
using TPSMetaTest.Controls;

namespace TPSMetaTest
{
    public partial class ProtocolViewForm : Form
    {
        Protocol mEditingProtocol;

        public ProtocolViewForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            this.Icon = Resources.icon;

            mEditingProtocol = new Protocol();
        }
        
        /// <summary>
        /// Focus on layout panel on mouse enter in order to activate mouse wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flowLayoutPanel_MouseEnter(object sender, System.EventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            panel.Focus();
        }

        /// <summary>
        /// On form shown, maximize it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProtocolViewForm_Shown(object sender, System.EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            //Refresh();
        }

        /// <summary>
        /// Add new segment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctlBtnAdd_Click(object sender, System.EventArgs e)
        {
            SegmentControl segment = new SegmentControl(new Segment());
            var panel = (sender.Equals(ctlBtnAdd1) ? ctlPanelRequest : ctlPanelResponse);
            panel.Controls.Add(segment);
            //TODO: Do other stuffs
        }

        private void OnBtnClear_Click(object sender, EventArgs e)
        {
            var panel = (sender.Equals(ctlBtnClear1) ? ctlPanelRequest : ctlPanelResponse);
            panel.Controls.Clear();
            //TODO: Do other stuffs
        }
    }
}
