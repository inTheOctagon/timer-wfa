using System;

namespace timer_hw
{
    public partial class Form1 : Form
    {
        public DateTime startTime;
        TimeSpan resumeTime;
        public Form1()
        {
            InitializeComponent();
            stopwatchRaButton.Checked = true;
            stopBtn.Enabled = false;
            resumeBtn.Enabled = false;
            resetBtn.Enabled = false;

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (stopwatchRaButton.Checked)
            {
                startTime = DateTime.Now;
                timer1.Start();
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
                resetBtn.Enabled = true;
            }

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            resumeBtn.Enabled = true;
            stopBtn.Enabled = false;

        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {

            timer1.Start();
            resumeBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saatLabel.Text = "00:00:00";
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            resumeBtn.Enabled = false;
            resetBtn.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timespan = DateTime.Now - startTime;
            saatLabel.Text = $"{(timespan):hh\\:mm\\:ss}";
        }



        private void stopwatchRaButton_CheckedChanged(object sender, EventArgs e)
        {
            if(stopwatchRaButton.Checked) 
            {
                comboBox1.Text = comboBox1.Items[0].ToString();
                comboBox2.Text = comboBox2.Items[0].ToString();
                comboBox3.Text = comboBox3.Items[0].ToString();
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }
            else if(!stopwatchRaButton.Checked)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
            }
            
        }
    }
}