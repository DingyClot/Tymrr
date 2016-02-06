using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tymrr
{
    public partial class Task : UserControl
    {
        public Task()
        {
            InitializeComponent();

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

        private void Task_Resize(object sender, EventArgs e)
        {
            var size = Math.Min(this.Width, this.Height);

            taskName.Font = new Font(
                taskName.Font.FontFamily,
                size / 3,
                taskName.Font.Style);
        }
    }
}
