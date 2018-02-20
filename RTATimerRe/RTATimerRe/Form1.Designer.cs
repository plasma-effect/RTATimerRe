namespace RTATimerRe
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTimerLabel = new System.Windows.Forms.Label();
            this.segmentNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mybestSegmentLabel = new System.Windows.Forms.Label();
            this.segmentBestLabel = new System.Windows.Forms.Label();
            this.sobsSegmentLabel = new System.Windows.Forms.Label();
            this.prevSegmentNameLabel = new System.Windows.Forms.Label();
            this.mybestPrevSegmentLabel = new System.Windows.Forms.Label();
            this.compareMybest = new System.Windows.Forms.Label();
            this.compareBestSegment = new System.Windows.Forms.Label();
            this.prevBestSegmentLabel = new System.Windows.Forms.Label();
            this.compareSOBSLabel = new System.Windows.Forms.Label();
            this.sobsPrevSegmentLabel = new System.Windows.Forms.Label();
            this.mybestLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sumOfBestSegment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bestPossibleTimeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.メニューToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ルート修正ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.記録修正ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ファイル読み込みToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.起動時に表示するファイルに設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.segmentTimeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTimerLabel
            // 
            this.mainTimerLabel.AutoSize = true;
            this.mainTimerLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainTimerLabel.Location = new System.Drawing.Point(3, 39);
            this.mainTimerLabel.Name = "mainTimerLabel";
            this.mainTimerLabel.Size = new System.Drawing.Size(534, 97);
            this.mainTimerLabel.TabIndex = 0;
            this.mainTimerLabel.Text = "00:00:00.000";
            // 
            // segmentNameLabel
            // 
            this.segmentNameLabel.AutoSize = true;
            this.segmentNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.segmentNameLabel.Location = new System.Drawing.Point(12, 136);
            this.segmentNameLabel.Name = "segmentNameLabel";
            this.segmentNameLabel.Size = new System.Drawing.Size(274, 43);
            this.segmentNameLabel.TabIndex = 1;
            this.segmentNameLabel.Text = "First Segment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(88, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Best";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(10, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segment Best";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(55, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sum of BS";
            // 
            // mybestSegmentLabel
            // 
            this.mybestSegmentLabel.AutoSize = true;
            this.mybestSegmentLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mybestSegmentLabel.Location = new System.Drawing.Point(220, 219);
            this.mybestSegmentLabel.Name = "mybestSegmentLabel";
            this.mybestSegmentLabel.Size = new System.Drawing.Size(180, 33);
            this.mybestSegmentLabel.TabIndex = 5;
            this.mybestSegmentLabel.Text = "12:34:56.789";
            // 
            // segmentBestLabel
            // 
            this.segmentBestLabel.AutoSize = true;
            this.segmentBestLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.segmentBestLabel.Location = new System.Drawing.Point(220, 252);
            this.segmentBestLabel.Name = "segmentBestLabel";
            this.segmentBestLabel.Size = new System.Drawing.Size(180, 33);
            this.segmentBestLabel.TabIndex = 6;
            this.segmentBestLabel.Text = "12:34:56.789";
            // 
            // sobsSegmentLabel
            // 
            this.sobsSegmentLabel.AutoSize = true;
            this.sobsSegmentLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sobsSegmentLabel.Location = new System.Drawing.Point(220, 285);
            this.sobsSegmentLabel.Name = "sobsSegmentLabel";
            this.sobsSegmentLabel.Size = new System.Drawing.Size(180, 33);
            this.sobsSegmentLabel.TabIndex = 7;
            this.sobsSegmentLabel.Text = "12:34:56.789";
            // 
            // prevSegmentNameLabel
            // 
            this.prevSegmentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevSegmentNameLabel.AutoSize = true;
            this.prevSegmentNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.prevSegmentNameLabel.Location = new System.Drawing.Point(243, 318);
            this.prevSegmentNameLabel.Name = "prevSegmentNameLabel";
            this.prevSegmentNameLabel.Size = new System.Drawing.Size(258, 33);
            this.prevSegmentNameLabel.TabIndex = 8;
            this.prevSegmentNameLabel.Text = "Previous Segment";
            this.prevSegmentNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mybestPrevSegmentLabel
            // 
            this.mybestPrevSegmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mybestPrevSegmentLabel.AutoSize = true;
            this.mybestPrevSegmentLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.mybestPrevSegmentLabel.Location = new System.Drawing.Point(227, 351);
            this.mybestPrevSegmentLabel.Name = "mybestPrevSegmentLabel";
            this.mybestPrevSegmentLabel.Size = new System.Drawing.Size(133, 24);
            this.mybestPrevSegmentLabel.TabIndex = 9;
            this.mybestPrevSegmentLabel.Text = "--:--:--.---";
            // 
            // compareMybest
            // 
            this.compareMybest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compareMybest.AutoSize = true;
            this.compareMybest.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.compareMybest.Location = new System.Drawing.Point(366, 351);
            this.compareMybest.Name = "compareMybest";
            this.compareMybest.Size = new System.Drawing.Size(145, 24);
            this.compareMybest.TabIndex = 10;
            this.compareMybest.Text = "-00:00:00.000";
            this.compareMybest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // compareBestSegment
            // 
            this.compareBestSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compareBestSegment.AutoSize = true;
            this.compareBestSegment.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.compareBestSegment.Location = new System.Drawing.Point(366, 375);
            this.compareBestSegment.Name = "compareBestSegment";
            this.compareBestSegment.Size = new System.Drawing.Size(145, 24);
            this.compareBestSegment.TabIndex = 11;
            this.compareBestSegment.Text = "+00:00:00.000";
            this.compareBestSegment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // prevBestSegmentLabel
            // 
            this.prevBestSegmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevBestSegmentLabel.AutoSize = true;
            this.prevBestSegmentLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.prevBestSegmentLabel.Location = new System.Drawing.Point(227, 375);
            this.prevBestSegmentLabel.Name = "prevBestSegmentLabel";
            this.prevBestSegmentLabel.Size = new System.Drawing.Size(133, 24);
            this.prevBestSegmentLabel.TabIndex = 12;
            this.prevBestSegmentLabel.Text = "--:--:--.---";
            // 
            // compareSOBSLabel
            // 
            this.compareSOBSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compareSOBSLabel.AutoSize = true;
            this.compareSOBSLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.compareSOBSLabel.Location = new System.Drawing.Point(366, 399);
            this.compareSOBSLabel.Name = "compareSOBSLabel";
            this.compareSOBSLabel.Size = new System.Drawing.Size(145, 24);
            this.compareSOBSLabel.TabIndex = 13;
            this.compareSOBSLabel.Text = "+00:00:00.000";
            this.compareSOBSLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sobsPrevSegmentLabel
            // 
            this.sobsPrevSegmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sobsPrevSegmentLabel.AutoSize = true;
            this.sobsPrevSegmentLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.sobsPrevSegmentLabel.Location = new System.Drawing.Point(227, 399);
            this.sobsPrevSegmentLabel.Name = "sobsPrevSegmentLabel";
            this.sobsPrevSegmentLabel.Size = new System.Drawing.Size(133, 24);
            this.sobsPrevSegmentLabel.TabIndex = 14;
            this.sobsPrevSegmentLabel.Text = "--:--:--.---";
            // 
            // mybestLabel
            // 
            this.mybestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mybestLabel.AutoSize = true;
            this.mybestLabel.Location = new System.Drawing.Point(245, 430);
            this.mybestLabel.Name = "mybestLabel";
            this.mybestLabel.Size = new System.Drawing.Size(133, 24);
            this.mybestLabel.TabIndex = 15;
            this.mybestLabel.Text = "12:34:56.789";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "My Best";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sum of Best Segment";
            // 
            // sumOfBestSegment
            // 
            this.sumOfBestSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sumOfBestSegment.AutoSize = true;
            this.sumOfBestSegment.Location = new System.Drawing.Point(245, 454);
            this.sumOfBestSegment.Name = "sumOfBestSegment";
            this.sumOfBestSegment.Size = new System.Drawing.Size(133, 24);
            this.sumOfBestSegment.TabIndex = 18;
            this.sumOfBestSegment.Text = "11:11:11.111";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Best Possible Time";
            // 
            // bestPossibleTimeLabel
            // 
            this.bestPossibleTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bestPossibleTimeLabel.AutoSize = true;
            this.bestPossibleTimeLabel.Location = new System.Drawing.Point(245, 478);
            this.bestPossibleTimeLabel.Name = "bestPossibleTimeLabel";
            this.bestPossibleTimeLabel.Size = new System.Drawing.Size(133, 24);
            this.bestPossibleTimeLabel.TabIndex = 20;
            this.bestPossibleTimeLabel.Text = "11:11:11.111";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニューToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 40);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // メニューToolStripMenuItem
            // 
            this.メニューToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成ToolStripMenuItem,
            this.ルート修正ToolStripMenuItem,
            this.記録修正ToolStripMenuItem,
            this.ファイル読み込みToolStripMenuItem,
            this.起動時に表示するファイルに設定ToolStripMenuItem});
            this.メニューToolStripMenuItem.Name = "メニューToolStripMenuItem";
            this.メニューToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.メニューToolStripMenuItem.Text = "メニュー";
            // 
            // 新規作成ToolStripMenuItem
            // 
            this.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            this.新規作成ToolStripMenuItem.Size = new System.Drawing.Size(426, 38);
            this.新規作成ToolStripMenuItem.Text = "新規作成";
            // 
            // ルート修正ToolStripMenuItem
            // 
            this.ルート修正ToolStripMenuItem.Name = "ルート修正ToolStripMenuItem";
            this.ルート修正ToolStripMenuItem.Size = new System.Drawing.Size(426, 38);
            this.ルート修正ToolStripMenuItem.Text = "ルート変更";
            // 
            // 記録修正ToolStripMenuItem
            // 
            this.記録修正ToolStripMenuItem.Name = "記録修正ToolStripMenuItem";
            this.記録修正ToolStripMenuItem.Size = new System.Drawing.Size(426, 38);
            this.記録修正ToolStripMenuItem.Text = "記録修正";
            // 
            // ファイル読み込みToolStripMenuItem
            // 
            this.ファイル読み込みToolStripMenuItem.Name = "ファイル読み込みToolStripMenuItem";
            this.ファイル読み込みToolStripMenuItem.Size = new System.Drawing.Size(426, 38);
            this.ファイル読み込みToolStripMenuItem.Text = "ファイル読み込み";
            // 
            // 起動時に表示するファイルに設定ToolStripMenuItem
            // 
            this.起動時に表示するファイルに設定ToolStripMenuItem.Name = "起動時に表示するファイルに設定ToolStripMenuItem";
            this.起動時に表示するファイルに設定ToolStripMenuItem.Size = new System.Drawing.Size(426, 38);
            this.起動時に表示するファイルに設定ToolStripMenuItem.Text = "起動時に表示するファイルに設定";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // segmentTimeLabel
            // 
            this.segmentTimeLabel.AutoSize = true;
            this.segmentTimeLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.segmentTimeLabel.Location = new System.Drawing.Point(286, 179);
            this.segmentTimeLabel.Name = "segmentTimeLabel";
            this.segmentTimeLabel.Size = new System.Drawing.Size(221, 40);
            this.segmentTimeLabel.TabIndex = 22;
            this.segmentTimeLabel.Text = "00:00:00.000";
            this.segmentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 511);
            this.Controls.Add(this.segmentTimeLabel);
            this.Controls.Add(this.bestPossibleTimeLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sumOfBestSegment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mybestLabel);
            this.Controls.Add(this.sobsPrevSegmentLabel);
            this.Controls.Add(this.compareSOBSLabel);
            this.Controls.Add(this.prevBestSegmentLabel);
            this.Controls.Add(this.compareBestSegment);
            this.Controls.Add(this.compareMybest);
            this.Controls.Add(this.mybestPrevSegmentLabel);
            this.Controls.Add(this.prevSegmentNameLabel);
            this.Controls.Add(this.sobsSegmentLabel);
            this.Controls.Add(this.segmentBestLabel);
            this.Controls.Add(this.mybestSegmentLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.segmentNameLabel);
            this.Controls.Add(this.mainTimerLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTimerLabel;
        private System.Windows.Forms.Label segmentNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mybestSegmentLabel;
        private System.Windows.Forms.Label segmentBestLabel;
        private System.Windows.Forms.Label sobsSegmentLabel;
        private System.Windows.Forms.Label prevSegmentNameLabel;
        private System.Windows.Forms.Label mybestPrevSegmentLabel;
        private System.Windows.Forms.Label compareMybest;
        private System.Windows.Forms.Label compareBestSegment;
        private System.Windows.Forms.Label prevBestSegmentLabel;
        private System.Windows.Forms.Label compareSOBSLabel;
        private System.Windows.Forms.Label sobsPrevSegmentLabel;
        private System.Windows.Forms.Label mybestLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sumOfBestSegment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bestPossibleTimeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニューToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規作成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ルート修正ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 記録修正ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ファイル読み込みToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 起動時に表示するファイルに設定ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label segmentTimeLabel;
    }
}

