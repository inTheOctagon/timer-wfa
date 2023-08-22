namespace timer_hw
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            saatLabel = new Label();
            startBtn = new Button();
            stopBtn = new Button();
            resetBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            resumeBtn = new Button();
            timerRaButton = new RadioButton();
            stopwatchRaButton = new RadioButton();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // saatLabel
            // 
            saatLabel.AutoSize = true;
            saatLabel.BackColor = Color.Black;
            saatLabel.Font = new Font("Unispace", 36F, FontStyle.Bold, GraphicsUnit.Point);
            saatLabel.ForeColor = Color.PaleTurquoise;
            saatLabel.Location = new Point(196, 34);
            saatLabel.Margin = new Padding(4, 0, 4, 0);
            saatLabel.Name = "saatLabel";
            saatLabel.Size = new Size(257, 58);
            saatLabel.TabIndex = 0;
            saatLabel.Text = "00:00:00";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(336, 131);
            startBtn.Margin = new Padding(4);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(96, 34);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // stopBtn
            // 
            stopBtn.Location = new Point(336, 173);
            stopBtn.Margin = new Padding(4);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(96, 32);
            stopBtn.TabIndex = 2;
            stopBtn.Text = "Stop";
            stopBtn.UseVisualStyleBackColor = true;
            stopBtn.Click += stopBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(440, 173);
            resetBtn.Margin = new Padding(4);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(96, 34);
            resetBtn.TabIndex = 2;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // resumeBtn
            // 
            resumeBtn.Location = new Point(440, 131);
            resumeBtn.Margin = new Padding(4);
            resumeBtn.Name = "resumeBtn";
            resumeBtn.Size = new Size(96, 34);
            resumeBtn.TabIndex = 4;
            resumeBtn.Text = "Resume";
            resumeBtn.UseVisualStyleBackColor = true;
            resumeBtn.Click += resumeBtn_Click;
            // 
            // timerRaButton
            // 
            timerRaButton.AutoSize = true;
            timerRaButton.Location = new Point(220, 96);
            timerRaButton.Margin = new Padding(4);
            timerRaButton.Name = "timerRaButton";
            timerRaButton.Size = new Size(68, 25);
            timerRaButton.TabIndex = 5;
            timerRaButton.TabStop = true;
            timerRaButton.Text = "Timer";
            timerRaButton.UseVisualStyleBackColor = true;
            // 
            // stopwatchRaButton
            // 
            stopwatchRaButton.AutoSize = true;
            stopwatchRaButton.Location = new Point(336, 96);
            stopwatchRaButton.Margin = new Padding(4);
            stopwatchRaButton.Name = "stopwatchRaButton";
            stopwatchRaButton.Size = new Size(100, 25);
            stopwatchRaButton.TabIndex = 5;
            stopwatchRaButton.TabStop = true;
            stopwatchRaButton.Text = "Stopwatch";
            stopwatchRaButton.UseVisualStyleBackColor = true;
            stopwatchRaButton.CheckedChanged += stopwatchRaButton_CheckedChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comboBox2.Location = new Point(163, 135);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(45, 29);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            comboBox3.Location = new Point(237, 135);
            comboBox3.Margin = new Padding(4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(45, 29);
            comboBox3.TabIndex = 6;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" });
            comboBox1.Location = new Point(88, 135);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(45, 29);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(13, 21);
            label1.TabIndex = 7;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(13, 21);
            label2.TabIndex = 7;
            label2.Text = ":";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(654, 239);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(stopwatchRaButton);
            Controls.Add(timerRaButton);
            Controls.Add(resumeBtn);
            Controls.Add(resetBtn);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(saatLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label saatLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Button startBtn;
        private Label label10;
        private Button stopBtn;
        private Label label11;
        private Button resetBtn;
        private TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private Button resumeBtn;
        private RadioButton timerRaButton;
        private RadioButton stopwatchRaButton;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private Label label1;
    }
}