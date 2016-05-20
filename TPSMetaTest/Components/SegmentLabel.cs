using System;
using System.Windows.Forms;
using TPSMetaTest.Data;
using TPSMetaTest.Properties;

namespace TPSMetaTest.Components
{
    class SegmentLabel:Label
    {
        private string mId;

        public event EventHandler OnSelected;

        public SegmentLabel()
        {
            InitializeComponent();

            this.DataSegment = new Segment();
            this.IsSelected = false;
            this.mId = Guid.NewGuid().ToString("N");

            this.DataBindings.Add(new Binding("Text", this.DataSegment, "LabelText"));
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SegmentLabel
            // 
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ResumeLayout(false);

        }
        
        #region "Properties"

        public Segment DataSegment { get; set; }
        
        public String ID
        {
            get
            {
                return mId;
            }
        }

        protected override System.Drawing.Size DefaultSize
        {
            get
            {
                return new System.Drawing.Size(250, 20);
            }
        }

        //public override string Text
        //{
        //    get
        //    {
        //        return "[" + this.DataSegment.Length + "] ("
        //            + this.DataSegment.Type.ToString() + ") "
        //            + this.DataSegment.Name.Substring(0, Math.Min(this.DataSegment.Name.Length, 20));
        //    }

        //    set
        //    {
        //        ;
        //    }
        //}

        #endregion

        #region "Event handler"

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (this.IsSelected == false)
            {
                this.BackColor = Settings.Default.SEG_HOVER_COLOR;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            if (this.IsSelected == false)
            {
                this.BackColor = Settings.Default.SEG_DEFAULT_COLOR;
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            this.IsSelected = !this.IsSelected;

            if (!this.IsSelected)
            {
                this.BackColor = Settings.Default.SEG_HOVER_COLOR; 
            }
            else
            {
                this.BackColor = Settings.Default.SEG_CLICK_COLOR;
            }
        }

        private bool mIsSelected = false;
        public bool IsSelected
        {
            get
            {
                return mIsSelected;
            }
            set
            {
                if (mIsSelected != value)
                {
                    mIsSelected = value;

                    if (mIsSelected)
                    {
                        this.BackColor = Settings.Default.SEG_CLICK_COLOR;
                    }
                    else
                    {
                        this.BackColor = Settings.Default.SEG_DEFAULT_COLOR;
                    }

                    //Call select changed event
                    if (mIsSelected && OnSelected != null)
                    {
                        OnSelected(this, new EventArgs());
                    }
                }
            }
        }

        #endregion

        
    }
}
