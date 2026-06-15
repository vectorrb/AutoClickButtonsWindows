using System.Runtime.InteropServices;

namespace AutoClickButtons
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new();
        bool clickFirst = true;

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        const int MOUSEEVENTF_LEFTDOWN = 0x02;
        const int MOUSEEVENTF_LEFTUP = 0x04;

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        const int SW_RESTORE = 9;

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 5000;
            timer.Tick += Timer_Tick;

            ApplyClickEffect(button1);
            ApplyClickEffect(button2);
            ApplyClickEffect(startButton);
            ApplyClickEffect(stopButton);

            // Hook up start/stop buttons
            startButton.Click += StartButton_Click;
            stopButton.Click += StopButton_Click;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RestoreAndActivate();

            if (clickFirst)
                ClickButton(button1);
            else
                ClickButton(button2);

            clickFirst = !clickFirst;
        }

        void ClickButton(Button btn)
        {
            var screenPoint = btn.PointToScreen(new System.Drawing.Point(btn.Width / 2, btn.Height / 2));

            SetCursorPos(screenPoint.X, screenPoint.Y);
            this.BringToFront();
            this.Focus();

            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)screenPoint.X, (uint)screenPoint.Y, 0, UIntPtr.Zero);
            mouse_event(MOUSEEVENTF_LEFTUP, (uint)screenPoint.X, (uint)screenPoint.Y, 0, UIntPtr.Zero);
        }
        void ApplyClickEffect(Button btn)
        {
            btn.UseVisualStyleBackColor = false;
            Color normalColor = btn.BackColor;
            Color clickColor = Color.LavenderBlush; // pressed color

            btn.MouseDown += (s, e) =>
            {
                btn.BackColor = clickColor;
            };

            btn.MouseUp += (s, e) =>
            {
                btn.BackColor = normalColor;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normalColor;
            };
        }
        void RestoreAndActivate()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowWindow(this.Handle, SW_RESTORE);
            }

            SetForegroundWindow(this.Handle);
            this.Activate();
        }
    }
}