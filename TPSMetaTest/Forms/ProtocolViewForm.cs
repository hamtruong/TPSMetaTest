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

        private void UpdateButtons()
        {

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
            SegmentControl segment = new SegmentControl();
            var panel = (sender.Equals(ctlBtnAdd1) ? ctlPanelRequest : ctlPanelResponse);
            panel.Controls.Add(segment);


            //if (ctlTabProtocol.SelectedIndex == 0)
            //{
            //    lbl.DataSegment.Name = "Request dat " + mEditingProtocol.ReqSegments.Count;
            //    lbl.OnSelected += new EventHandler(OnReqLabelSelectChanged);

            //    ctlPanelRequest.Controls.Add(lbl);
            //    mEditingProtocol.ReqSegments.Add(lbl.DataSegment);
            //}
            //else
            //{
            //    lbl.DataSegment.Name = "Response dat " + mEditingProtocol.RepSegments.Count;
            //    lbl.OnSelected += new EventHandler(OnRepLabelSelectChanged);

            //    ctlPanelResponse.Controls.Add(lbl);
            //    mEditingProtocol.RepSegments.Add(lbl.DataSegment);
            //}
        }

        /// <summary>
        /// When click on a segment, refresh color of other segments (Request tab)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnReqLabelSelectChanged(object sender, System.EventArgs e)
        {
            SegmentLabel lbl = (SegmentLabel)sender;
            foreach (var c in ctlPanelRequest.Controls)
            {
                SegmentLabel l = (SegmentLabel)c;
                if (l.IsSelected && !l.ID.Equals(lbl.ID))
                {
                    l.IsSelected = false;
                }
            }
        }

        /// <summary>
        /// When click on a segment, refresh color of other segments (Response tab)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRepLabelSelectChanged(object sender, System.EventArgs e)
        {
            //SegmentLabel lbl = (SegmentLabel)sender;
            //foreach (var c in ctlPanelResponse.Controls)
            //{
            //    SegmentLabel l = (SegmentLabel)c;
            //    if (l.IsSelected && !l.ID.Equals(lbl.ID))
            //    {
            //        l.IsSelected = false;
            //    }
            //}
        }

        private SegmentLabel SelectedReqLabel { get; set; }
        private SegmentLabel SelectedRepLabel { get; set; }
    }
}
