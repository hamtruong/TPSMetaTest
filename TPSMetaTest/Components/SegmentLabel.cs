using System;
using System.Windows.Forms;
using TPSMetaTest.Data;
using TPSMetaTest.Properties;

namespace TPSMetaTest.Components
{
    class SegmentLabel:Label
    {
        public Segment DataSegment { get; set; }
        public bool Selected { get; set; }

        public SegmentLabel()
        {
            InitializeComponent();
            this.Selected = false;
        }

        public SegmentLabel(Segment segment)
        {
            this.DataSegment = segment;
            InitializeComponent();
            this.Selected = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SegmentLabel
            // 
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ResumeLayout(false);

        }

        protected override System.Drawing.Size DefaultSize
        {
            get
            {
                return new System.Drawing.Size(200, 52);
            }
        }

        public override string Text
        {
            get
            {
                return "[" + this.DataSegment.Length + "] " + this.DataSegment.Name
                    + Environment.NewLine + this.DataSegment.Type.ToString()
                    + Environment.NewLine + "\"123456\"";
            }

            set
            {
                ;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (this.Selected == false)
            {
                this.BackColor = Settings.Default.SEG_HOVER_COLOR;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (this.Selected == false)
            {
                this.BackColor = Settings.Default.SEG_DEFAULT_COLOR;
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            this.Selected = !this.Selected;

            if (this.Selected)
            {
                this.BackColor = Settings.Default.SEG_CLICK_COLOR;
            }
            else
            {
                this.BackColor = Settings.Default.SEG_HOVER_COLOR;
            }
        }
    }
}
