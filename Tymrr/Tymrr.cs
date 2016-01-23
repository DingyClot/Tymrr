using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tymrr
{
    public partial class Tymrr : Form
    {
        public Tymrr()
        {
            InitializeComponent();
        }

        private void Task1_Resize(object sender, EventArgs e)
        {
            var taskButton = (sender as Button);

            var size = Math.Min(taskButton.Width, taskButton.Height);

            taskButton.Font = new Font(
                taskButton.Font.FontFamily,
                size / 4);

            //Well I guess we don't want incompatible text rendering...
            taskButton.UseCompatibleTextRendering = true;
        }
    }
}
