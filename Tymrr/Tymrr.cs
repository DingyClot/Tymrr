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
            var font = taskButton.Font;

            var minimum = Math.Min(taskButton.Width, taskButton.Height);

            taskButton.Font = new Font(font.FontFamily, minimum / 3);
        }
    }
}
