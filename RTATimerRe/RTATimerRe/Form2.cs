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
    public partial class Form2 : Form
    {
        List<SegmentData> datas;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2Load(object sender, EventArgs e)
        {

        }

        public void SetSegments(IEnumerable<string> segments)
        {
            this.datas = new List<SegmentData>(segments.Count());
            var index = -1;
            foreach (var v in segments)
            {
                ++index;
                this.datas.Add(new SegmentData
                {
                    SegmentName = v,
                    Location = new Point(0, index * 24)
                });
                this.Controls.Add(this.datas[index]);
            }
        }

        public void SetTargetTime(int index,Utility.TimeData? segbest, Utility.TimeData? mybest)
        {
            this.datas[index].Segmentbest = segbest;
            this.datas[index].Mybest = mybest;
        }
        
        public void SetTime(int index, Utility.TimeData? segment, Utility.TimeData? all)
        {
            this.datas[index].SetTime(segment, all);
        }

        public void RemoveTime(int index)
        {
            this.datas[index].RemoveTime();
        }
    }
}
