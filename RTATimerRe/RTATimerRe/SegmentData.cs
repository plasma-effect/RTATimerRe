using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTATimerRe
{
    public partial class SegmentData : UserControl
    {
        Utility.TimeData? mybest;
        Utility.TimeData? segmentbest;
        
        internal Utility.TimeData? Mybest
        {
            get => this.mybest;
            set => this.mybest = value;
        }
        internal Utility.TimeData? Segmentbest
        {
            get => this.segmentbest;
            set => this.segmentbest = value;
        }
        internal string SegmentName
        {
            get => this.segnameLabel.Text;
            set => this.segnameLabel.Text = value;
        }
        
        public SegmentData()
        {
            InitializeComponent();
        }

        private void SegmentDataLoad(object sender, EventArgs e)
        {

        }

        public void ChangeFont(Font font)
        {
            this.segmentBestLabel.Font = font;
            this.mybestLabel.Font = font;
        }

        public void SetTime(Utility.TimeData? segment, Utility.TimeData? time)
        {
            if(segment is Utility.TimeData seg)
            {
                if(this.segmentbest is Utility.TimeData sb)
                {
                    var t = seg - sb;
                    this.segmentBestLabel.Text = t.ToString();
                    if (t.Sign)
                    {
                        Utility.LabelGreen(this.segmentBestLabel);
                    }
                }
                else
                {
                    this.segmentBestLabel.Text = seg.NormalString();
                }
            }
            else
            {
                this.segmentBestLabel.Text = "--:--:--.---";
            }
            if(time is Utility.TimeData tm)
            {
                if(this.mybest is Utility.TimeData bes)
                {
                    var t = tm - bes;
                    this.mybestLabel.Text = t.ToString();
                    if (t.Sign)
                    {
                        Utility.LabelGreen(this.mybestLabel);
                    }
                    else
                    {
                        Utility.LabelRed(this.mybestLabel);
                    }
                }
                else
                {
                    this.mybestLabel.Text = tm.NormalString();
                }
            }
            else
            {
                this.mybestLabel.Text = "--:--:--.---";
            }
        }

        public void RemoveTime()
        {
            this.mybestLabel.Text = this.mybest?.NormalString() ?? "--:--:--.---";
            this.segmentBestLabel.Text = this.segmentbest?.NormalString() ?? "--:--:--.---";
            Utility.LabelNormal(this.mybestLabel);
            Utility.LabelNormal(this.segmentBestLabel);
        }
    }
}
