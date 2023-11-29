namespace _16_Notifications
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            this.ShowInTaskbar = false;
            notifyIcon1.Click += NotifyIcon1_Click;
        }

        private void NotifyIcon1_Click(object? sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            label1.Text = (++count).ToString(); 
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Таймер почав відлік!";
            notifyIcon1.BalloonTipTitle = "Увага!";

            notifyIcon1.ShowBalloonTip(5);

            //notifyIcon1.ShowBalloonTip()

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipText = "Таймер зупинився!";
            notifyIcon1.BalloonTipTitle = "Увага!";

            notifyIcon1.ShowBalloonTip(5);

        }
    }
}