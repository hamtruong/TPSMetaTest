namespace TPSMetaTest.Controls
{
    partial class SegmentControl
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

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlLblIndex = new System.Windows.Forms.Label();
            this.ctlLblType = new System.Windows.Forms.Label();
            this.ctlLblName = new System.Windows.Forms.Label();
            this.ctlLblLen = new System.Windows.Forms.Label();
            this.ctlNumericLen = new System.Windows.Forms.NumericUpDown();
            this.ctlCbbType = new System.Windows.Forms.ComboBox();
            this.ctlTbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlBtnOk = new System.Windows.Forms.Button();
            this.ctlBtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctlNumericLen)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlLblIndex
            // 
            this.ctlLblIndex.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ctlLblIndex.Location = new System.Drawing.Point(4, 4);
            this.ctlLblIndex.Name = "ctlLblIndex";
            this.ctlLblIndex.Size = new System.Drawing.Size(58, 18);
            this.ctlLblIndex.TabIndex = 0;
            this.ctlLblIndex.Text = "[index]";
            this.ctlLblIndex.DoubleClick += new System.EventHandler(this.SegmentControl_DoubleClick);
            // 
            // ctlLblType
            // 
            this.ctlLblType.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ctlLblType.Location = new System.Drawing.Point(142, 4);
            this.ctlLblType.Name = "ctlLblType";
            this.ctlLblType.Size = new System.Drawing.Size(87, 18);
            this.ctlLblType.TabIndex = 0;
            this.ctlLblType.Text = "{Type}";
            this.ctlLblType.DoubleClick += new System.EventHandler(this.SegmentControl_DoubleClick);
            // 
            // ctlLblName
            // 
            this.ctlLblName.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ctlLblName.Location = new System.Drawing.Point(240, 4);
            this.ctlLblName.Name = "ctlLblName";
            this.ctlLblName.Size = new System.Drawing.Size(198, 18);
            this.ctlLblName.TabIndex = 0;
            this.ctlLblName.Text = "Name";
            this.ctlLblName.DoubleClick += new System.EventHandler(this.SegmentControl_DoubleClick);
            // 
            // ctlLblLen
            // 
            this.ctlLblLen.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ctlLblLen.Location = new System.Drawing.Point(73, 4);
            this.ctlLblLen.Name = "ctlLblLen";
            this.ctlLblLen.Size = new System.Drawing.Size(58, 18);
            this.ctlLblLen.TabIndex = 0;
            this.ctlLblLen.Text = "(length)";
            this.ctlLblLen.DoubleClick += new System.EventHandler(this.SegmentControl_DoubleClick);
            // 
            // ctlNumericLen
            // 
            this.ctlNumericLen.Location = new System.Drawing.Point(145, 27);
            this.ctlNumericLen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ctlNumericLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctlNumericLen.Name = "ctlNumericLen";
            this.ctlNumericLen.Size = new System.Drawing.Size(195, 19);
            this.ctlNumericLen.TabIndex = 1;
            this.ctlNumericLen.ThousandsSeparator = true;
            this.ctlNumericLen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ctlCbbType
            // 
            this.ctlCbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlCbbType.FormattingEnabled = true;
            this.ctlCbbType.Location = new System.Drawing.Point(145, 52);
            this.ctlCbbType.Name = "ctlCbbType";
            this.ctlCbbType.Size = new System.Drawing.Size(195, 20);
            this.ctlCbbType.TabIndex = 2;
            // 
            // ctlTbName
            // 
            this.ctlTbName.Location = new System.Drawing.Point(145, 78);
            this.ctlTbName.Name = "ctlTbName";
            this.ctlTbName.Size = new System.Drawing.Size(195, 19);
            this.ctlTbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "(byte)";
            // 
            // ctlBtnOk
            // 
            this.ctlBtnOk.Location = new System.Drawing.Point(348, 76);
            this.ctlBtnOk.Name = "ctlBtnOk";
            this.ctlBtnOk.Size = new System.Drawing.Size(33, 23);
            this.ctlBtnOk.TabIndex = 5;
            this.ctlBtnOk.Text = "Ok";
            this.ctlBtnOk.UseVisualStyleBackColor = true;
            this.ctlBtnOk.Click += new System.EventHandler(this.ctlBtnOk_Click);
            // 
            // ctlBtnCancel
            // 
            this.ctlBtnCancel.Location = new System.Drawing.Point(387, 76);
            this.ctlBtnCancel.Name = "ctlBtnCancel";
            this.ctlBtnCancel.Size = new System.Drawing.Size(51, 23);
            this.ctlBtnCancel.TabIndex = 5;
            this.ctlBtnCancel.Text = "Cancel";
            this.ctlBtnCancel.UseVisualStyleBackColor = true;
            this.ctlBtnCancel.Click += new System.EventHandler(this.ctlBtnCancel_Click);
            // 
            // SegmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ctlBtnCancel);
            this.Controls.Add(this.ctlBtnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlTbName);
            this.Controls.Add(this.ctlCbbType);
            this.Controls.Add(this.ctlNumericLen);
            this.Controls.Add(this.ctlLblName);
            this.Controls.Add(this.ctlLblType);
            this.Controls.Add(this.ctlLblLen);
            this.Controls.Add(this.ctlLblIndex);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SegmentControl";
            this.Size = new System.Drawing.Size(443, 102);
            this.DoubleClick += new System.EventHandler(this.SegmentControl_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.ctlNumericLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctlLblIndex;
        private System.Windows.Forms.Label ctlLblType;
        private System.Windows.Forms.Label ctlLblName;
        private System.Windows.Forms.Label ctlLblLen;
        private System.Windows.Forms.NumericUpDown ctlNumericLen;
        private System.Windows.Forms.ComboBox ctlCbbType;
        private System.Windows.Forms.TextBox ctlTbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ctlBtnOk;
        private System.Windows.Forms.Button ctlBtnCancel;
    }
}
