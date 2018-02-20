using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTATimerRe
{
    public partial class Form1 : Form
    {
        Form2 segments_form;
        Utility.CompleteData data;
        Utility.CompleteData.LapData target;
        System.Diagnostics.Stopwatch stopwatch;
        long?[] now;
        int index;
        string name;
        bool saved;

        public Form1()
        {
            InitializeComponent();
            this.data = new Utility.CompleteData(3000, new Dictionary<string, Utility.CompleteData.LapData>());
            this.target = this.data.NewLapData("test", new string[] { "test1", "test2", "test3" });
            this.stopwatch = new System.Diagnostics.Stopwatch();
            this.index = -1;
            this.saved = false;
        }

        private void Form1KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case (char)Keys.Enter:
                    EnterClick();
                    break;
                case (char)Keys.Back:
                    BackClick();
                    break;
                case (char)Keys.Space:
                    SpaceClick();
                    break;
                case (char)Keys.Escape:
                    EscapeClick();
                    break;
            }
        }

        private void EscapeClick()
        {
            this.data.Add(this.target, this.now);
            this.stopwatch.Reset();
            this.index = -1;
            if (!this.saved)
            {
                if (this.name != null)
                {
                    var binary = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    using (var stream = new System.IO.FileStream(this.name, System.IO.FileMode.OpenOrCreate))
                    {
                        binary.Serialize(stream, this.data);
                    }
                }
                this.saved = true;
            }
            ResetTimes();
        }

        private void SpaceClick()
        {
            if (this.index >= 0 && this.index < this.target.SegmentName.Length)
            {
                this.now[this.index] = null;
                this.segments_form.SetTime(this.index, null, null);
                ++this.index;
            }
        }

        private void BackClick()
        {
            if (this.index > 0)
            {
                --this.index;
                this.segments_form.RemoveTime(this.index);
            }
        }

        private void EnterClick()
        {
            if (this.index == -1)
            {
                this.now = new long?[this.target.SegmentName.Length];
                this.index = 0;
                this.saved = false;
                this.stopwatch.Reset();
                this.stopwatch.Start();
            }
            else if (this.index < this.target.SegmentName.Length)
            {
                this.now[this.index] = this.stopwatch.ElapsedMilliseconds;
                this.segments_form.SetTime(this.index, 
                    (this.now[this.index] - (this.index > 0 ? this.now[this.index - 1] : 0)).ToTimeData(),
                    this.now[this.index].ToTimeData());
                ++this.index;
            }
        }

        private void Form1Load(object sender, EventArgs e)
        {
            this.segments_form = new Form2();
            this.segments_form.SetSegments(this.target.SegmentName);
            ResetTimes();
            this.segments_form.Show();
        }

        private void ResetTimes()
        {
            var best = this.target.MyBest;
            var sobs = this.target.SumOfBestSegment;
            for (var i = 0; i < this.target.SegmentName.Length; ++i)
            {
                this.segments_form.SetTargetTime(i, sobs[i].ToTimeData(), best[i].ToTimeData());
            }
            this.mybestLabel.Text = this.data.MyBest.ToTimeData()?.NormalString() ?? "--:--:--.---";
            this.sumOfBestSegment.Text = sobs.Last().ToTimeData()?.NormalString() ?? "--:--:--.---";
            this.bestPossibleTimeLabel.Text = sobs.Last().ToTimeData()?.NormalString() ?? "--:--:--.---";

            this.prevSegmentNameLabel.Text = "";
            this.mybestPrevSegmentLabel.Text = "";
            this.sobsPrevSegmentLabel.Text = "";
            this.prevBestSegmentLabel.Text = "";
            this.compareBestSegment.Text = "";
            this.compareMybest.Text = "";
            this.compareSOBSLabel.Text = "";

            this.segmentNameLabel.Text = this.target.SegmentName[0];
            this.mybestSegmentLabel.Text = best[0].ToTimeData()?.NormalString() ?? "--:--:--.---";
            this.sobsSegmentLabel.Text = sobs[0].ToTimeData()?.NormalString() ?? "--:--:--.---";
            this.segmentBestLabel.Text = sobs[0].ToTimeData()?.NormalString() ?? "--:--:--.---";

            this.mainTimerLabel.Text = "00:00:00.000";
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.mainTimerLabel.Text=new Utility.TimeData(this.stopwatch.ElapsedMilliseconds)
        }
    }
}
