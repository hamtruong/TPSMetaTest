using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPSMetaTest.Properties;
using TPSMetaTest.Data;

namespace TPSMetaTest.Controls
{
    public partial class SegmentControl : UserControl
    {
        public event EventHandler LengthChanged;

        private Segment Segment { get; set; }
        public bool IsExpaned { get; set; }

        public SegmentControl(Segment segment)
        {
            InitializeComponent();

            ctlCbbType.Items.Clear();
            ctlCbbType.Items.AddRange(Enum.GetNames(typeof(Data.DataDefinition.SegType)));

            //Background
            this.BackColor = Settings.Default.SEG_DEFAULT_COLOR;

            //Minimize
            Settings.Default.SEG_HEIGHT_EXPANDED = this.Height;
            this.Height = Settings.Default.SEG_HEIGHT_MINIMIZED;
            this.IsExpaned = false;

            this.Segment = segment;
            UpdateControlValue();
        }

        #region "Events"
        private void SegmentControl_DoubleClick(object sender, EventArgs e)
        {
            if (this.IsExpaned)
                CollapseView();
            else
                ExpandView();
        }

        private void ctlBtnOk_Click(object sender, EventArgs e)
        {
            if (ctlTbName.Text.Trim() == string.Empty)
                return;

            string text = ctlTbName.Text.Trim();
            DataDefinition.SegType type = (DataDefinition.SegType)Enum.Parse(typeof(DataDefinition.SegType), ctlCbbType.SelectedItem.ToString());
            ushort len = Convert.ToUInt16(ctlNumericLen.Value);
            bool isLenChanged = (len != this.Segment.Length);

            this.Segment.Name = text;
            this.Segment.Type = type;
            this.Segment.Length = len;

            UpdateControlValue();
            CollapseView();

            if (isLenChanged && (LengthChanged != null))
                LengthChanged(this, null);
        }

        private void ctlBtnCancel_Click(object sender, EventArgs e)
        {
            UpdateControlValue();
            CollapseView();
        }
        #endregion

        #region "Method"
        private void ExpandView()
        {
            SetLabelVisibility(false);

            this.BackColor = Settings.Default.SEG_HOVER_COLOR;
            this.Height = Settings.Default.SEG_HEIGHT_EXPANDED;
            this.IsExpaned = true;

            ctlNumericLen.Focus();
        }

        private void CollapseView()
        {
            this.BackColor = Settings.Default.SEG_DEFAULT_COLOR;
            this.Height = Settings.Default.SEG_HEIGHT_MINIMIZED;
            this.IsExpaned = false;

            SetLabelVisibility(true);

            this.Parent.Focus();
        }

        private void SetLabelVisibility(bool visible)
        {
            ctlLblLen.Visible = visible;
            ctlLblType.Visible = visible;
            ctlLblName.Visible = visible;
        }

        private void UpdateControlValue()
        {
            ctlLblLen.Text = this.Segment.Length.ToString();
            ctlNumericLen.Value = this.Segment.Length;
            ctlLblType.Text = this.Segment.Type.ToString();
            ctlCbbType.SelectedItem = this.Segment.Type.ToString();
            ctlLblName.Text = this.Segment.Name;
            ctlTbName.Text = this.Segment.Name;
        }

        #endregion
    }
}
