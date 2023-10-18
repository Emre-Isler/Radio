using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Radyo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static void radiocal()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\radio.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }
         private static void radiokpt()
        {
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "\\radio.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            ses.Stop();
        }
        private void cbRadyo_SelectedIndexChanged(object sender, EventArgs e)
        {
            radiocal();
            timer1.Start();
            switch (cbRadyo.Text)
            {
                case "NTV Radyo":
                    axWindowsMediaPlayer1.URL = ("mms://ntvrdwmp.radyotvonline.com:80");
                    break;
                case "90'lar":
                    axWindowsMediaPlayer1.URL = ("mms://37.247.98.8/stream/166/");
                    break;
                case "Bucak FM":
                    axWindowsMediaPlayer1.URL = ("mms://95.173.184.20:9588/");
                    break;
                case "Slow Türk":
                    axWindowsMediaPlayer1.URL = ("mms://radyo.duhnet.tv/ak_dtvh_slowturk/");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbRadyo.Text = "NTV Radyo";
            timer1.Start();
            int zmn = 0;
            radiocal();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zmn++;
            if (zmn==5)
            {
                radiokpt();
                timer1.Stop();
                zmn = 0;
            }
        }


        public int zmn { get; set; }
    }
}
