using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tymrr
{
    public partial class Task : UserControl
    {
        public Task()
        {
            InitializeComponent();

            //Well I guess we don't want incompatible text rendering...
            closeButton.UseCompatibleTextRendering = true;
        }

        private void Task_Resize(object sender, EventArgs e)
        {
            //float size = Math.Min(this.Width, this.Height);

            //size = size > 0 ? size : 1;

            //taskName.Font = new Font(
            //    taskName.Font.FontFamily,
            //    size / 10,
            //    taskName.Font.Style);
        }
    }
}
