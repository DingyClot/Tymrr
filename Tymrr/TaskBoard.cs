using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tymrr
{
    public partial class TaskBoard : UserControl
    {
        private List<Task> tasks = new List<Task>();

        public TaskBoard()
        {
            InitializeComponent();

            //This was just for something to see in the Designer
            grid.Controls.Remove(task1);

            var offset = 0;
            var index = 0;

            for (var r = 0; r < grid.RowCount; ++r)
            {
                for (var c = 0; c < (grid.ColumnCount / 2) - 1; ++c)
                {
                    var task = new Task();
                    task.Dock = DockStyle.Fill;

                    tasks.Add(task);
                    grid.Controls.Add(task, (c * 2) + offset, r);
                    grid.SetColumnSpan(task, 2);

                    task.BackColor = ((c + r) % 2 == 0) ?
                        Color.FromArgb(20, 20, 20) :
                        Color.FromArgb(25, 25, 25);

                    task.Index = index++;
                }
                offset += 1;
            }

            tasks[0].Start();
            tasks[4].Start();
            tasks[8].Start();

            tasks[1].Stop();
            tasks[2].Stop();
            tasks[5].Stop();
            tasks[7].Stop();
            tasks[10].Stop();
            tasks[11].Stop();
        }
    }
}
