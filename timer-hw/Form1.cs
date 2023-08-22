using System;

namespace timer_hw
{
    public partial class Form1 : Form
    {
        private int h = 0, m = 0, s = 0;
        private bool timer;
        private bool timeIsUp = false;

        public Form1()
        {
            InitializeComponent();

            startBtn.Enabled = true;
            stopwatchRaButton.Checked = true;
            stopBtn.Enabled = false;
            resumeBtn.Enabled = false;
            resetBtn.Enabled = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (timerRaButton.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
            }

            stopwatchRaButton.Enabled = false;
            timerRaButton.Enabled = false;
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            resetBtn.Enabled = true;
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

            h = 0;
            m = 0;
            s = 0;

            saatLabel.Text = String.Format("{0:D2}", h) + ":" + String.Format("{0:D2}", m) + ":" + String.Format("{0:D2}", s);

            if (timerRaButton.Checked)
            {
                comboBox2.Text = comboBox2.Items[0].ToString();
                comboBox3.Text = comboBox3.Items[0].ToString();
                comboBox1.Text = comboBox1.Items[0].ToString();

                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;


            }

            stopwatchRaButton.Enabled = true;
            timerRaButton.Enabled = true;

            if (stopwatchRaButton.Checked) startBtn.Enabled = true;
            stopBtn.Enabled = false;
            resumeBtn.Enabled = false;
            resetBtn.Enabled = false;

            if (timerRaButton.Enabled)
            {
                timer = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stopwatchRaButton.Checked)
            {
                s++;
                if (s == 60)
                {
                    s = 0;
                    m++;
                }
                if (m == 60)
                {
                    m = 0;
                    h++;
                }

                saatLabel.Text = String.Format("{0:D2}", h) + ":" + String.Format("{0:D2}", m) + ":" + String.Format("{0:D2}", s);
            }
            else if (!timeIsUp)
            {
                if (timer)
                {
                    h = int.Parse(comboBox1.Text);
                    m = int.Parse(comboBox2.Text);
                    s = int.Parse(comboBox3.Text);

                    timer = false;
                }

                saatLabel.Text = String.Format("{0:D2}", h) + ":" + String.Format("{0:D2}", m) + ":" + String.Format("{0:D2}", s);

                s--;

                if (m == 0 && s == 0 && h == 0)
                {
                    timeIsUp = true;
                }

                if (s <= 0)
                {
                    s = 59;
                    m--;
                }
                if (m < 0)
                {
                    m = 59;
                    if (h != 0) h--;
                }
            }
            else
            {
                h = 0;
                m = 0;
                s = 0;

                saatLabel.Text = String.Format("{0:D2}", h) + ":" + String.Format("{0:D2}", m) + ":" + String.Format("{0:D2}", s);

                comboBox2.Text = comboBox2.Items[0].ToString();
                comboBox3.Text = comboBox3.Items[0].ToString();
                comboBox1.Text = comboBox1.Items[0].ToString();

                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;

                stopwatchRaButton.Enabled = true;
                timerRaButton.Enabled = true;

                startBtn.Enabled = false;
                stopBtn.Enabled = false;
                resumeBtn.Enabled = false;
                resetBtn.Enabled = false;

                timer = true;

                timeIsUp = false;

                timer1.Stop();

                MessageBox.Show("Time's up!");
            }

        }
        private void stopwatchRaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (stopwatchRaButton.Checked)
            {
                startBtn.Enabled = true;

                comboBox2.Text = comboBox2.Items[0].ToString();
                comboBox3.Text = comboBox3.Items[0].ToString();
                comboBox1.Text = comboBox1.Items[0].ToString();

                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox1.Enabled = false;
            }
            else if (!stopwatchRaButton.Checked)
            {
                timer = true;
                startBtn.Enabled = false;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "00" || comboBox2.Text != "00" || comboBox3.Text != "00")
            {
                startBtn.Enabled = true;
                resetBtn.Enabled = true;
            }
            else if (!stopwatchRaButton.Checked) startBtn.Enabled = false;
        }
    }
}