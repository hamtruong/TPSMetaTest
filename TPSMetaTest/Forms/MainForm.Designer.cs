namespace TPSMetaTest
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlBtnOpen = new System.Windows.Forms.Button();
            this.ctlBtnNew = new System.Windows.Forms.Button();
            this.dialogOpenProtocol = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(277, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.aboutToolStripMenuItem.Text = "About..";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ctlBtnOpen
            // 
            this.ctlBtnOpen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ctlBtnOpen.Location = new System.Drawing.Point(19, 44);
            this.ctlBtnOpen.Name = "ctlBtnOpen";
            this.ctlBtnOpen.Size = new System.Drawing.Size(106, 41);
            this.ctlBtnOpen.TabIndex = 1;
            this.ctlBtnOpen.Text = "Open..";
            this.ctlBtnOpen.UseVisualStyleBackColor = true;
            this.ctlBtnOpen.Click += new System.EventHandler(this.ctlBtnOpen_Click);
            // 
            // ctlBtnNew
            // 
            this.ctlBtnNew.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ctlBtnNew.Location = new System.Drawing.Point(151, 44);
            this.ctlBtnNew.Name = "ctlBtnNew";
            this.ctlBtnNew.Size = new System.Drawing.Size(106, 41);
            this.ctlBtnNew.TabIndex = 1;
            this.ctlBtnNew.Text = "New..";
            this.ctlBtnNew.UseVisualStyleBackColor = true;
            this.ctlBtnNew.Click += new System.EventHandler(this.ctlBtnNew_Click);
            // 
            // dialogOpenProtocol
            // 
            this.dialogOpenProtocol.Filter = "Protocol file|*.tpsprotocol";
            this.dialogOpenProtocol.Title = "Open a protocol..";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 103);
            this.Controls.Add(this.ctlBtnNew);
            this.Controls.Add(this.ctlBtnOpen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPSMetaTest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button ctlBtnOpen;
        private System.Windows.Forms.Button ctlBtnNew;
        private System.Windows.Forms.OpenFileDialog dialogOpenProtocol;
    }
}

