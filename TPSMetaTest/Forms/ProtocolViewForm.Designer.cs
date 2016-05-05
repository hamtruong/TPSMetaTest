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
            this.ctlPanelResponse = new System.Windows.Forms.FlowLayoutPanel();
            this.ctlTabProtocol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlBtnAdd = new System.Windows.Forms.Button();
            this.ctlBtnUp = new System.Windows.Forms.Button();
            this.ctlBtnDown = new System.Windows.Forms.Button();
            this.ctlBtnRemove = new System.Windows.Forms.Button();
            this.ctlToolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctlTabProtocol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.ctlPanelRequest.Location = new System.Drawing.Point(3, 3);
            this.ctlPanelRequest.Name = "ctlPanelRequest";
            this.ctlPanelRequest.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ctlPanelRequest.Size = new System.Drawing.Size(234, 697);
            this.ctlPanelRequest.TabIndex = 0;
            this.ctlPanelRequest.WrapContents = false;
            this.ctlPanelRequest.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.ctlTabProtocol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1016, 735);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ctlPanelResponse
            // 
            this.ctlPanelResponse.AutoScroll = true;
            this.ctlPanelResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPanelResponse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ctlPanelResponse.Location = new System.Drawing.Point(3, 3);
            this.ctlPanelResponse.Name = "ctlPanelResponse";
            this.ctlPanelResponse.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ctlPanelResponse.Size = new System.Drawing.Size(234, 697);
            this.ctlPanelResponse.TabIndex = 1;
            this.ctlPanelResponse.WrapContents = false;
            this.ctlPanelResponse.MouseEnter += new System.EventHandler(this.flowLayoutPanel_MouseEnter);
            // 
            // ctlTabProtocol
            // 
            this.ctlTabProtocol.Controls.Add(this.tabPage1);
            this.ctlTabProtocol.Controls.Add(this.tabPage2);
            this.ctlTabProtocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTabProtocol.Location = new System.Drawing.Point(3, 3);
            this.ctlTabProtocol.Name = "ctlTabProtocol";
            this.ctlTabProtocol.SelectedIndex = 0;
            this.ctlTabProtocol.Size = new System.Drawing.Size(248, 729);
            this.ctlTabProtocol.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlPanelRequest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(240, 703);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlPanelResponse);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(240, 703);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Response";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctlBtnRemove);
            this.panel1.Controls.Add(this.ctlBtnDown);
            this.panel1.Controls.Add(this.ctlBtnUp);
            this.panel1.Controls.Add(this.ctlBtnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(257, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 729);
            this.panel1.TabIndex = 4;
            // 
            // ctlBtnAdd
            // 
            this.ctlBtnAdd.Location = new System.Drawing.Point(3, 3);
            this.ctlBtnAdd.Name = "ctlBtnAdd";
            this.ctlBtnAdd.Size = new System.Drawing.Size(60, 33);
            this.ctlBtnAdd.TabIndex = 0;
            this.ctlBtnAdd.Text = "Add";
            this.ctlBtnAdd.UseVisualStyleBackColor = true;
            this.ctlBtnAdd.Click += new System.EventHandler(this.ctlBtnAdd_Click);
            // 
            // ctlBtnUp
            // 
            this.ctlBtnUp.Enabled = false;
            this.ctlBtnUp.Location = new System.Drawing.Point(3, 46);
            this.ctlBtnUp.Name = "ctlBtnUp";
            this.ctlBtnUp.Size = new System.Drawing.Size(60, 33);
            this.ctlBtnUp.TabIndex = 0;
            this.ctlBtnUp.Text = "Up";
            this.ctlBtnUp.UseVisualStyleBackColor = true;
            // 
            // ctlBtnDown
            // 
            this.ctlBtnDown.Enabled = false;
            this.ctlBtnDown.Location = new System.Drawing.Point(3, 89);
            this.ctlBtnDown.Name = "ctlBtnDown";
            this.ctlBtnDown.Size = new System.Drawing.Size(60, 33);
            this.ctlBtnDown.TabIndex = 0;
            this.ctlBtnDown.Text = "Down";
            this.ctlBtnDown.UseVisualStyleBackColor = true;
            // 
            // ctlBtnRemove
            // 
            this.ctlBtnRemove.Enabled = false;
            this.ctlBtnRemove.Location = new System.Drawing.Point(3, 132);
            this.ctlBtnRemove.Name = "ctlBtnRemove";
            this.ctlBtnRemove.Size = new System.Drawing.Size(60, 33);
            this.ctlBtnRemove.TabIndex = 0;
            this.ctlBtnRemove.Text = "Remove";
            this.ctlBtnRemove.UseVisualStyleBackColor = true;
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
            this.ctlTabProtocol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel ctlPanelResponse;
        private System.Windows.Forms.TabControl ctlTabProtocol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ctlBtnAdd;
        private System.Windows.Forms.Button ctlBtnRemove;
        private System.Windows.Forms.Button ctlBtnDown;
        private System.Windows.Forms.Button ctlBtnUp;
    }
}