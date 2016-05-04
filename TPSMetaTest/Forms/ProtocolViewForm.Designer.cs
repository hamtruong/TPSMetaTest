namespace TPSMetaTest
{
    partial class ProtocolViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtocolViewForm));
            this.ctlToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ctlStatusStrip = new System.Windows.Forms.StatusStrip();
            this.ctlSplitCtn = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlToolStrip.SuspendLayout();
            this.ctlSplitCtn.Panel1.SuspendLayout();
            this.ctlSplitCtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlToolStrip
            // 
            this.ctlToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.ctlToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ctlToolStrip.Name = "ctlToolStrip";
            this.ctlToolStrip.Size = new System.Drawing.Size(1016, 25);
            this.ctlToolStrip.TabIndex = 0;
            this.ctlToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton1.Text = "New..";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(41, 22);
            this.toolStripButton2.Text = "Save";
            // 
            // ctlStatusStrip
            // 
            this.ctlStatusStrip.Location = new System.Drawing.Point(0, 760);
            this.ctlStatusStrip.Name = "ctlStatusStrip";
            this.ctlStatusStrip.Size = new System.Drawing.Size(1016, 22);
            this.ctlStatusStrip.TabIndex = 1;
            this.ctlStatusStrip.Text = "statusStrip1";
            // 
            // ctlSplitCtn
            // 
            this.ctlSplitCtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlSplitCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSplitCtn.IsSplitterFixed = true;
            this.ctlSplitCtn.Location = new System.Drawing.Point(0, 25);
            this.ctlSplitCtn.Name = "ctlSplitCtn";
            // 
            // ctlSplitCtn.Panel1
            // 
            this.ctlSplitCtn.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.ctlSplitCtn.Size = new System.Drawing.Size(1016, 735);
            this.ctlSplitCtn.SplitterDistance = 329;
            this.ctlSplitCtn.SplitterWidth = 2;
            this.ctlSplitCtn.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 733);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.MouseEnter += new System.EventHandler(this.flowLayoutPanel1_MouseEnter);
            // 
            // ProtocolViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 782);
            this.Controls.Add(this.ctlSplitCtn);
            this.Controls.Add(this.ctlStatusStrip);
            this.Controls.Add(this.ctlToolStrip);
            this.Name = "ProtocolViewForm";
            this.Text = "ProtocolViewForm";
            this.ctlToolStrip.ResumeLayout(false);
            this.ctlToolStrip.PerformLayout();
            this.ctlSplitCtn.Panel1.ResumeLayout(false);
            this.ctlSplitCtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ctlToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip ctlStatusStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.SplitContainer ctlSplitCtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}