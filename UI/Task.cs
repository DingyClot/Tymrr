using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tymrr.WinForms
{
    public partial class Task : UserControl
    {
        static readonly private float inactiveTextSize = 10;

        private int index;
        private float textSize = inactiveTextSize;

        private List<Color> activeColors = new List<Color>();
        private List<Color> inactiveColors = new List<Color>();
        private List<string> taskTimes = new List<string>();

        public Task()
        {
            InitializeComponent();

            taskTimes.Add("00:12:56");
            taskTimes.Add("01:45:25");
            taskTimes.Add("00:39:23");
            taskTimes.Add("00:29:04");
            taskTimes.Add("00:45:02");
            taskTimes.Add("02:22:26");
            taskTimes.Add("00:44:54");
            taskTimes.Add("00:01:25");
            taskTimes.Add("01:05:11");
            taskTimes.Add("00:03:43");
            taskTimes.Add("00:08:49");
            taskTimes.Add("00:27:39");

            activeColors.Add(Color.FromArgb(136, 206, 232));
            activeColors.Add(Color.FromArgb(136, 206, 232));
            activeColors.Add(Color.FromArgb(136, 206, 232));
            activeColors.Add(Color.FromArgb(136, 206, 232));

            activeColors.Add(Color.FromArgb(255, 120, 150));
            activeColors.Add(Color.FromArgb(255, 120, 150));
            activeColors.Add(Color.FromArgb(255, 120, 150));
            activeColors.Add(Color.FromArgb(255, 120, 150));

            activeColors.Add(Color.FromArgb(255, 247, 118));
            activeColors.Add(Color.FromArgb(255, 247, 118));
            activeColors.Add(Color.FromArgb(255, 247, 118));
            activeColors.Add(Color.FromArgb(255, 247, 118));


            inactiveColors.Add(Color.FromArgb(36, 54, 61));
            inactiveColors.Add(Color.FromArgb(36, 54, 61));
            inactiveColors.Add(Color.FromArgb(36, 54, 61));
            inactiveColors.Add(Color.FromArgb(36, 54, 61));

            inactiveColors.Add(Color.FromArgb(84, 40, 50));
            inactiveColors.Add(Color.FromArgb(84, 40, 50));
            inactiveColors.Add(Color.FromArgb(84, 40, 50));
            inactiveColors.Add(Color.FromArgb(84, 40, 50));

            inactiveColors.Add(Color.FromArgb(84, 82, 39));
            inactiveColors.Add(Color.FromArgb(84, 82, 39));
            inactiveColors.Add(Color.FromArgb(84, 82, 39));
            inactiveColors.Add(Color.FromArgb(84, 82, 39));

            this.DoubleBuffered = true;
            this.SetStyle(
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);

            Dock = DockStyle.Fill;

            //Well I guess we don't want incompatible text rendering...
            closeButton.UseCompatibleTextRendering = true;
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
                taskName.Text = "F" + (index + 1);
            }
        }

        public void Start()
        {
            taskName.Text = "New Task";
            BackColor = activeColors[index];
            taskTime.Visible = true;
            taskTime.Text = taskTimes[index];
            textSize = 4;

            var size = (float)Math.Min(this.Width, this.Height);

            taskName.Font = new Font(
                taskName.Font.FontFamily,
                textSize * (size / 30),
                taskName.Font.Style);

            taskTime.Font = new Font(
                taskTime.Font.FontFamily,
                textSize * (size / 60),
                taskTime.Font.Style);

            closeButton.Font = new Font(
                closeButton.Font.FontFamily,
                textSize * (size / 35),
                closeButton.Font.Style);
        }

        public void Stop()
        {
        }

        private void Task_Resize(object sender, EventArgs e)
        {
            var size = (float)Math.Min(this.Width, this.Height);

            taskName.Font = new Font(
                taskName.Font.FontFamily,
                textSize * (size / 30),
                taskName.Font.Style);

            taskTime.Font = new Font(
                taskTime.Font.FontFamily,
                textSize * (size / 60),
                taskTime.Font.Style);

            closeButton.Font = new Font(
                closeButton.Font.FontFamily,
                textSize * (size / 35),
                closeButton.Font.Style);
        }

        private void taskName_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
