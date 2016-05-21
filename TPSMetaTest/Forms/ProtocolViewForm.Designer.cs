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
            this.ctlPanelRequest = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ctlBtnAdd1 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnRemove1 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnUp1 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnDown1 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnClear1 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ctlPanelResponse = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ctlBtnAdd2 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnRemove2 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnUp2 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnDown2 = new System.Windows.Forms.ToolStripButton();
            this.ctlBtnClear2 = new System.Windows.Forms.ToolStripButton();
            this.ctlToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            // ctlPanelRequest
            // 
            this.ctlPanelRequest.AutoScroll = true;
            this.ctlPanelRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPanelRequest.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ctlPanelRequest.Location = new System.Drawing.Point(0, 0);
            this.ctlPanelRequest.Name = "ctlPanelRequest";
            this.ctlPanelRequest.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ctlPanelRequest.Size = new System.Drawing.Size(497, 694);
            this.ctlPanelRequest.TabIndex = 0;
            this.ctlPanelRequest.WrapContents = false;
            this.ctlPanelRequest.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 735);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctlPanelRequest);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 719);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlBtnAdd1,
            this.ctlBtnRemove1,
            this.ctlBtnUp1,
            this.ctlBtnDown1,
            this.ctlBtnClear1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 694);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ctlBtnAdd1
            // 
            this.ctlBtnAdd1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnAdd1.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnAdd1.Image")));
            this.ctlBtnAdd1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnAdd1.Name = "ctlBtnAdd1";
            this.ctlBtnAdd1.Size = new System.Drawing.Size(23, 22);
            this.ctlBtnAdd1.Text = "+";
            this.ctlBtnAdd1.Click += new System.EventHandler(this.ctlBtnAdd_Click);
            // 
            // ctlBtnRemove1
            // 
            this.ctlBtnRemove1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnRemove1.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnRemove1.Image")));
            this.ctlBtnRemove1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnRemove1.Name = "ctlBtnRemove1";
            this.ctlBtnRemove1.Size = new System.Drawing.Size(23, 22);
            this.ctlBtnRemove1.Text = "-";
            // 
            // ctlBtnUp1
            // 
            this.ctlBtnUp1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnUp1.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnUp1.Image")));
            this.ctlBtnUp1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnUp1.Name = "ctlBtnUp1";
            this.ctlBtnUp1.Size = new System.Drawing.Size(24, 22);
            this.ctlBtnUp1.Text = "↑";
            // 
            // ctlBtnDown1
            // 
            this.ctlBtnDown1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnDown1.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnDown1.Image")));
            this.ctlBtnDown1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnDown1.Name = "ctlBtnDown1";
            this.ctlBtnDown1.Size = new System.Drawing.Size(24, 22);
            this.ctlBtnDown1.Text = "↓";
            // 
            // ctlBtnClear1
            // 
            this.ctlBtnClear1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnClear1.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnClear1.Image")));
            this.ctlBtnClear1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnClear1.Name = "ctlBtnClear1";
            this.ctlBtnClear1.Size = new System.Drawing.Size(42, 22);
            this.ctlBtnClear1.Text = "Clear";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctlPanelResponse);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(511, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 719);
            this.panel2.TabIndex = 2;
            // 
            // ctlPanelResponse
            // 
            this.ctlPanelResponse.AutoScroll = true;
            this.ctlPanelResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPanelResponse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ctlPanelResponse.Location = new System.Drawing.Point(0, 0);
            this.ctlPanelResponse.Name = "ctlPanelResponse";
            this.ctlPanelResponse.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ctlPanelResponse.Size = new System.Drawing.Size(497, 694);
            this.ctlPanelResponse.TabIndex = 1;
            this.ctlPanelResponse.WrapContents = false;
            this.ctlPanelResponse.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlBtnAdd2,
            this.ctlBtnRemove2,
            this.ctlBtnUp2,
            this.ctlBtnDown2,
            this.ctlBtnClear2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 694);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(497, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ctlBtnAdd2
            // 
            this.ctlBtnAdd2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnAdd2.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnAdd2.Image")));
            this.ctlBtnAdd2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnAdd2.Name = "ctlBtnAdd2";
            this.ctlBtnAdd2.Size = new System.Drawing.Size(23, 22);
            this.ctlBtnAdd2.Text = "+";
            this.ctlBtnAdd2.Click += new System.EventHandler(this.ctlBtnAdd_Click);
            // 
            // ctlBtnRemove2
            // 
            this.ctlBtnRemove2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnRemove2.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnRemove2.Image")));
            this.ctlBtnRemove2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnRemove2.Name = "ctlBtnRemove2";
            this.ctlBtnRemove2.Size = new System.Drawing.Size(23, 22);
            this.ctlBtnRemove2.Text = "-";
            // 
            // ctlBtnUp2
            // 
            this.ctlBtnUp2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnUp2.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnUp2.Image")));
            this.ctlBtnUp2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnUp2.Name = "ctlBtnUp2";
            this.ctlBtnUp2.Size = new System.Drawing.Size(24, 22);
            this.ctlBtnUp2.Text = "↑";
            // 
            // ctlBtnDown2
            // 
            this.ctlBtnDown2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnDown2.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnDown2.Image")));
            this.ctlBtnDown2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnDown2.Name = "ctlBtnDown2";
            this.ctlBtnDown2.Size = new System.Drawing.Size(24, 22);
            this.ctlBtnDown2.Text = "↓";
            // 
            // ctlBtnClear2
            // 
            this.ctlBtnClear2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlBtnClear2.Image = ((System.Drawing.Image)(resources.GetObject("ctlBtnClear2.Image")));
            this.ctlBtnClear2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlBtnClear2.Name = "ctlBtnClear2";
            this.ctlBtnClear2.Size = new System.Drawing.Size(42, 22);
            this.ctlBtnClear2.Text = "Clear";
            // 
            // ProtocolViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 782);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ctlStatusStrip);
            this.Controls.Add(this.ctlToolStrip);
            this.Name = "ProtocolViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProtocolViewForm";
            this.Shown += new System.EventHandler(this.ProtocolViewForm_Shown);
            this.ctlToolStrip.ResumeLayout(false);
            this.ctlToolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ctlToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip ctlStatusStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.FlowLayoutPanel ctlPanelRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel ctlPanelResponse;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton ctlBtnAdd1;
        private System.Windows.Forms.ToolStripButton ctlBtnRemove1;
        private System.Windows.Forms.ToolStripButton ctlBtnUp1;
        private System.Windows.Forms.ToolStripButton ctlBtnDown1;
        private System.Windows.Forms.ToolStripButton ctlBtnClear1;
        private System.Windows.Forms.ToolStripButton ctlBtnAdd2;
        private System.Windows.Forms.ToolStripButton ctlBtnRemove2;
        private System.Windows.Forms.ToolStripButton ctlBtnUp2;
        private System.Windows.Forms.ToolStripButton ctlBtnDown2;
        private System.Windows.Forms.ToolStripButton ctlBtnClear2;
    }
}