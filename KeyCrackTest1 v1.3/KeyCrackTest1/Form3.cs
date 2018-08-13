using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCrackTest1
{
    public partial class ThirdForm : Form
    {
        int timerCounter = 35;
        public ThirdForm(StartForm dialog) 
        {
            InitializeComponent();
            timer1.Start();

            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer(Properties.Resources.test);
            Audio.Load();
            Audio.Play();
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            timer.Text = (--timerCounter).ToString();
            if (timerCounter == 0)
            {
                timer1.Stop();
                Close();
                MessageBox.Show("Бум");
            }
        }
    }
}

