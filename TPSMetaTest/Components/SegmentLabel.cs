using System;
using System.Windows.Forms;
using TPSMetaTest.Data;
using TPSMetaTest.Properties;

namespace TPSMetaTest.Components
{
    class SegmentLabel:Label
    {
        public Segment DataSegment { get; set; }

        public SegmentLabel()
        {
            InitializeComponent();
        }

        public SegmentLabel(Segment segment)
        {
            this.DataSegment = segment;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SegmentLabel
            // 
            this.BackColor = Settings.Default.SEG_DEFAULT_COLOR;
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
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

            this.BackColor = Settings.Default.SEG_HOVER_COLOR;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.BackColor = Settings.Default.SEG_DEFAULT_COLOR;
        }
    }
}
