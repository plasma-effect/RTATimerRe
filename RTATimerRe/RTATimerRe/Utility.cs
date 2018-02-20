using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RTATimerRe
{
    public static class Utility
    {
        [Serializable]public struct TimeData
        {
            bool sign;
            int hour;
            int min;
            int sec;
            int mill;
            
            public TimeData(int hour, int min, int sec, int mill)
            {
                this.sign = false;
                this.hour = hour;
                this.min = min;
                this.sec = sec;
                this.mill = mill;
            }

            public TimeData(long rowtime)
            {
                this.sign = rowtime < 0;
                if (this.sign)
                {
                    rowtime = -rowtime;
                }
                this.mill = (int)(rowtime % 1000);
                rowtime /= 1000;
                this.sec = (int)(rowtime % 60);
                rowtime /= 60;
                this.min = (int)(rowtime % 60);
                rowtime /= 60;
                this.hour = (int)rowtime;
            }

            public override string ToString()
            {
                return (this.sign ? "-" : "+") +
                    this.hour.ToString("00") + ":" +
                    this.min.ToString("00") + ":" +
                    this.sec.ToString("00") + "." +
                    this.mill.ToString("000");
            }

            public string NormalString()
            {
                return
                    this.hour.ToString("00") + ":" +
                    this.min.ToString("00") + ":" +
                    this.sec.ToString("00") + "." +
                    this.mill.ToString("000");
            }

            public long RowData => (this.sign ? -1 : 1) * (this.hour * 36000000 + this.mill * 60000 + this.sec * 1000 + this.mill);

            public bool Sign => this.sign;
            public int Hour => this.hour;
            public int Min => this.min;
            public int Sec => this.sec;
            public int Mill => this.mill;

            static public TimeData operator +(TimeData lhs, TimeData rhs)
            {
                return new TimeData(lhs.RowData + rhs.RowData);
            }

            static public TimeData operator -(TimeData lhs, TimeData rhs)
            {
                return new TimeData(lhs.RowData - rhs.RowData);
            }
        }

        static public TimeData? ToTimeData(this long? time)
        {
            if(time is long t)
            {
                return new TimeData(t);
            }
            return null;
        }

        static public TimeData ToTimeData(this long time)
        {
            return new TimeData(time);
        }

        static public void LabelRed(Label label)
        {
            label.ForeColor = Color.White;
            label.BackColor = Color.Red;
        }

        static public void LabelGreen(Label label)
        {
            label.ForeColor = Color.White;
            label.BackColor = Color.Green;
        }

        static public void LabelNormal(Label label)
        {
            label.ForeColor = SystemColors.ControlText;
            label.BackColor = SystemColors.Control;
        }

        [Serializable]public class CompleteData
        {
            long? mybest;
            [Serializable]public class LapData
            {
                List<long?[]> timer;
                string[] segname;

                public LapData(List<long?[]> timer, string[] segname)
                {
                    this.timer = timer;
                    this.segname = segname;
                }

                public string[] SegmentName => this.segname;
                public List<long?[]> Times => this.timer;

                public void AddTime(long?[] time)
                {
                    if (time.Length != this.segname.Length)
                    {
                        throw new ArgumentOutOfRangeException("time");
                    }
                    this.timer.Add(time);
                }

                public long?[] SumOfBestSegment
                {
                    get
                    {
                        var ret = new long?[this.segname.Length];
                        foreach(var t in this.timer)
                        {
                            if(ret[0] is long v)
                            {
                                if (t[0] is long u && u < v) 
                                {
                                    ret[0] = u;
                                }
                            }
                            else
                            {
                                ret[0] = t[0];
                            }
                            for(var i = 1; i < this.segname.Length; ++i)
                            {
                                if(ret[i] is long a)
                                {
                                    if (t[i] is long b && t[i - 1] is long c && b - c < a) 
                                    {
                                        ret[i] = b - c;
                                    }
                                }
                                else
                                {
                                    ret[i] = t[i] - t[i - 1];
                                }
                            }
                        }
                        for(var i = 1; i < this.segname.Length; ++i)
                        {
                            ret[i] += ret[i - 1];
                        }
                        return ret;
                    }
                }

                public long?[] MyBest
                {
                    get
                    {
                        var ret = new long?[this.segname.Length];
                        foreach(var t in this.timer)
                        {
                            for(var i = this.segname.Length - 1; i >= 0; --i)
                            {
                                if (ret[i] is long v)
                                {
                                    if (t[i] is long u)
                                    {
                                        if (u < v)
                                        {
                                            ret = t;
                                        }
                                        break;
                                    }
                                    break;
                                }
                                else if (t[i].HasValue) 
                                {
                                    ret = t;
                                    break;
                                }
                            }
                        }
                        return ret;
                    }
                }

            }
            Dictionary<string, LapData> lapdatas;

            public CompleteData(long? mybest, Dictionary<string, LapData> lapdatas)
            {
                this.mybest = mybest;
                this.lapdatas = lapdatas;
            }

            public Dictionary<string, LapData> MyLapData => this.lapdatas;
            public long? MyBest => this.mybest;
            
            public void Add(LapData lap, long?[] time)
            {
                lap.AddTime(time);
                if(time.Last() is long t && !(this.mybest <= t))
                {
                    this.mybest = t;
                }
            }

            public LapData NewLapData(string name,string[] segname)
            {
                this.lapdatas.Add(name, new LapData(new List<long?[]>(), segname));
                return this.lapdatas.Last().Value;
            }
        }

    }
}
