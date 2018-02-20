namespace RTATimerRe
{
    partial class SegmentData
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.segnameLabel = new System.Windows.Forms.Label();
            this.mybestLabel = new System.Windows.Forms.Label();
            this.segmentBestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // segnameLabel
            // 
            this.segnameLabel.AutoSize = true;
            this.segnameLabel.Location = new System.Drawing.Point(3, 0);
            this.segnameLabel.Name = "segnameLabel";
            this.segnameLabel.Size = new System.Drawing.Size(160, 24);
            this.segnameLabel.TabIndex = 0;
            this.segnameLabel.Text = "Segment Name";
            // 
            // mybestLabel
            // 
            this.mybestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mybestLabel.Location = new System.Drawing.Point(327, 0);
            this.mybestLabel.Name = "mybestLabel";
            this.mybestLabel.Size = new System.Drawing.Size(145, 24);
            this.mybestLabel.TabIndex = 1;
            this.mybestLabel.Text = "--:--:--.---";
            this.mybestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // segmentBestLabel
            // 
            this.segmentBestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.segmentBestLabel.Location = new System.Drawing.Point(176, 0);
            this.segmentBestLabel.Name = "segmentBestLabel";
            this.segmentBestLabel.Size = new System.Drawing.Size(145, 24);
            this.segmentBestLabel.TabIndex = 2;
            this.segmentBestLabel.Text = "--:--:--.---";
            this.segmentBestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SegmentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.segmentBestLabel);
            this.Controls.Add(this.mybestLabel);
            this.Controls.Add(this.segnameLabel);
            this.Name = "SegmentData";
            this.Size = new System.Drawing.Size(471, 24);
            this.Load += new System.EventHandler(this.SegmentDataLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label segnameLabel;
        private System.Windows.Forms.Label mybestLabel;
        private System.Windows.Forms.Label segmentBestLabel;
    }
}
