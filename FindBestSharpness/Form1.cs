using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace TestRTSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            m_timer_video.Interval = 30;//in default
            m_timer_video.Tick += new EventHandler(ZDraw_Frame_from_timer);
            pt1 = new Point(100, 100);
            pt2 = new Point(300, 200);
        }

        private void ZDraw_Frame_from_timer(object sender, EventArgs e)
        {
            Mat frame = m_vc_capture.QueryFrame();
            if(frame != null)
            {
                //double presen_time = m_vc_capture.GetCaptureProperty(CapProp.PosMsec);
                //label_presentation_time.Text = ((int)presen_time).ToString();
                //double frame_idx = m_vc_capture.GetCaptureProperty(CapProp.PosFrames);
                //label_cur_frame.Text = ((int)frame_idx).ToString();
                m_cur_frame = frame;
                imageBox1.Image = Draw_Keypoints_To_Frame(frame);
            }

        }

        private VideoCapture m_vc_capture;
        private System.Windows.Forms.Timer m_timer_video = new System.Windows.Forms.Timer();
        private Point pt1 = new Point();
        private Point pt2 = new Point();
        private Mat m_cur_frame;
        //private TimeSpan playedTime
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            string file = @"e:\1.mp4";
            //m_vc_capture = new VideoCapture(file);
            //m_vc_capture = new VideoCapture("rtsp://172.16.1.31/video1.sdp");
            m_vc_capture = new VideoCapture(textBox1.Text);
            m_timer_video.Start();
            while (true)
            {
                await Task.Run(Do_Measure);
            }
        }
        private Mat Draw_Keypoints_To_Frame(Mat aFrame)
        {
            CvInvoke.Line(aFrame, pt1, pt2, new Bgr(Color.Blue).MCvScalar, 3);
            return aFrame;
        }
        private async Task Do_Measure()
        {
           Random rand = new Random();
           await Task.Delay(rand.Next(1500, 5000));
            pt1.Offset(rand.Next(-50, 50), rand.Next(-100, 100));
            pt2.Offset(rand.Next(-50, 50), rand.Next(-100, 100));
            label_presentation_time.Text = pt1.ToString() + ", " + pt2.ToString();

        }
    }
}
