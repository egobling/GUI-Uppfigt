using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Discord_copy_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer ljudSpelare = new SoundPlayer(@"C:\ljud\funnymp3\Discord Notification.wav");
            ljudSpelare.Play();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer ljudSpelare = new SoundPlayer(@"C:\ljud\funnymp3\discord_ringtone.wav");
            ljudSpelare.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer ljudSpelare = new SoundPlayer(@"C:\ljud\funnymp3\nokia-ringtone-arabic.wav");
            ljudSpelare.Play();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
