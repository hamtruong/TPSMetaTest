namespace TPSMetaTest.Forms
{
    partial class AboutForm
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
            this.ctlTableView = new System.Windows.Forms.TableLayoutPanel();
            this.ctlPictureBox = new System.Windows.Forms.PictureBox();
            this.cltPanelInfo = new System.Windows.Forms.Panel();
            this.ctlLinklblEmail = new System.Windows.Forms.LinkLabel();
            this.ctlLinklblLink = new System.Windows.Forms.LinkLabel();
            this.ctlLblLink = new System.Windows.Forms.Label();
            this.ctlLblAuthor = new System.Windows.Forms.Label();
            this.ctlLblVersion = new System.Windows.Forms.Label();
            this.ctlLblSoftName = new System.Windows.Forms.Label();
            this.ctlBtnOk = new System.Windows.Forms.Button();
            this.ctlTableView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlPictureBox)).BeginInit();
            this.cltPanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlTableView
            // 
            this.ctlTableView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlTableView.ColumnCount = 2;
            this.ctlTableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.72325F));
            this.ctlTableView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.27675F));
            this.ctlTableView.Controls.Add(this.ctlPictureBox, 0, 0);
            this.ctlTableView.Controls.Add(this.cltPanelInfo, 1, 0);
            this.ctlTableView.Location = new System.Drawing.Point(3, 3);
            this.ctlTableView.Name = "ctlTableView";
            this.ctlTableView.RowCount = 1;
            this.ctlTableView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ctlTableView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.ctlTableView.Size = new System.Drawing.Size(388, 114);
            this.ctlTableView.TabIndex = 1;
            // 
            // ctlPictureBox
            // 
            this.ctlPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPictureBox.Image = global::TPSMetaTest.Properties.Resources.icon_png;
            this.ctlPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ctlPictureBox.Name = "ctlPictureBox";
            this.ctlPictureBox.Size = new System.Drawing.Size(89, 108);
            this.ctlPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ctlPictureBox.TabIndex = 0;
            this.ctlPictureBox.TabStop = false;
            // 
            // cltPanelInfo
            // 
            this.cltPanelInfo.Controls.Add(this.ctlLinklblEmail);
            this.cltPanelInfo.Controls.Add(this.ctlLinklblLink);
            this.cltPanelInfo.Controls.Add(this.ctlLblLink);
            this.cltPanelInfo.Controls.Add(this.ctlLblAuthor);
            this.cltPanelInfo.Controls.Add(this.ctlLblVersion);
            this.cltPanelInfo.Controls.Add(this.ctlLblSoftName);
            this.cltPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cltPanelInfo.Location = new System.Drawing.Point(98, 3);
            this.cltPanelInfo.Name = "cltPanelInfo";
            this.cltPanelInfo.Size = new System.Drawing.Size(287, 108);
            this.cltPanelInfo.TabIndex = 0;
            // 
            // ctlLinklblEmail
            // 
            this.ctlLinklblEmail.AutoSize = true;
            this.ctlLinklblEmail.Location = new System.Drawing.Point(87, 66);
            this.ctlLinklblEmail.Name = "ctlLinklblEmail";
            this.ctlLinklblEmail.Size = new System.Drawing.Size(131, 12);
            this.ctlLinklblEmail.TabIndex = 3;
            this.ctlLinklblEmail.TabStop = true;
            this.ctlLinklblEmail.Text = "(quangyendn@gmail.com)";
            // 
            // ctlLinklblLink
            // 
            this.ctlLinklblLink.AutoSize = true;
            this.ctlLinklblLink.Location = new System.Drawing.Point(36, 85);
            this.ctlLinklblLink.Name = "ctlLinklblLink";
            this.ctlLinklblLink.Size = new System.Drawing.Size(233, 12);
            this.ctlLinklblLink.TabIndex = 5;
            this.ctlLinklblLink.TabStop = true;
            this.ctlLinklblLink.Text = "https://github.com/hamtruong/TPSMetaTest";
            // 
            // ctlLblLink
            // 
            this.ctlLblLink.AutoSize = true;
            this.ctlLblLink.Location = new System.Drawing.Point(4, 85);
            this.ctlLblLink.Name = "ctlLblLink";
            this.ctlLblLink.Size = new System.Drawing.Size(28, 12);
            this.ctlLblLink.TabIndex = 4;
            this.ctlLblLink.Text = "Link:";
            // 
            // ctlLblAuthor
            // 
            this.ctlLblAuthor.AutoSize = true;
            this.ctlLblAuthor.Location = new System.Drawing.Point(4, 66);
            this.ctlLblAuthor.Name = "ctlLblAuthor";
            this.ctlLblAuthor.Size = new System.Drawing.Size(80, 12);
            this.ctlLblAuthor.TabIndex = 2;
            this.ctlLblAuthor.Text = "Author: YenNQ";
            // 
            // ctlLblVersion
            // 
            this.ctlLblVersion.AutoSize = true;
            this.ctlLblVersion.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ctlLblVersion.Location = new System.Drawing.Point(102, 35);
            this.ctlLblVersion.Name = "ctlLblVersion";
            this.ctlLblVersion.Size = new System.Drawing.Size(82, 14);
            this.ctlLblVersion.TabIndex = 1;
            this.ctlLblVersion.Text = "Version X.XX";
            // 
            // ctlLblSoftName
            // 
            this.ctlLblSoftName.AutoSize = true;
            this.ctlLblSoftName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ctlLblSoftName.Location = new System.Drawing.Point(82, 10);
            this.ctlLblSoftName.Name = "ctlLblSoftName";
            this.ctlLblSoftName.Size = new System.Drawing.Size(123, 18);
            this.ctlLblSoftName.TabIndex = 0;
            this.ctlLblSoftName.Text = "TPSMetaTest";
            // 
            // ctlBtnOk
            // 
            this.ctlBtnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctlBtnOk.Location = new System.Drawing.Point(313, 123);
            this.ctlBtnOk.Name = "ctlBtnOk";
            this.ctlBtnOk.Size = new System.Drawing.Size(75, 23);
            this.ctlBtnOk.TabIndex = 0;
            this.ctlBtnOk.Text = "Ok";
            this.ctlBtnOk.UseVisualStyleBackColor = true;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.ctlBtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctlBtnOk;
            this.ClientSize = new System.Drawing.Size(394, 151);
            this.Controls.Add(this.ctlBtnOk);
            this.Controls.Add(this.ctlTableView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About TPSMetatTest";
            this.ctlTableView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlPictureBox)).EndInit();
            this.cltPanelInfo.ResumeLayout(false);
            this.cltPanelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ctlTableView;
        private System.Windows.Forms.PictureBox ctlPictureBox;
        private System.Windows.Forms.Panel cltPanelInfo;
        private System.Windows.Forms.Label ctlLblSoftName;
        private System.Windows.Forms.Button ctlBtnOk;
        private System.Windows.Forms.Label ctlLblVersion;
        private System.Windows.Forms.Label ctlLblLink;
        private System.Windows.Forms.Label ctlLblAuthor;
        private System.Windows.Forms.LinkLabel ctlLinklblLink;
        private System.Windows.Forms.LinkLabel ctlLinklblEmail;
    }
}