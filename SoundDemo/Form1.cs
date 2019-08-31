using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.DirectX.DirectSound;


namespace SoundDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {
            NAudioRecorder.Instance.label = label1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SoundPick.Instance.Stoprec();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            NAudioRecorder.Instance.SetFileName("Demo.wav");
            NAudioRecorder.Instance.StartRec();
            Start.Enabled = false;
            Stop.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            NAudioRecorder.Instance.StopRec();

            Start.Enabled = true;
            Stop.Enabled = false;
        }
    }
}
