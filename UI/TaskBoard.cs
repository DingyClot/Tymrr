using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.Windows.Forms;

namespace Tymrr.WinForms
{
    public partial class TaskBoard : UserControl
    {
        private List<Task> tasks = new List<Task>();

        public TaskBoard()
        {
            InitializeComponent();
        }

        internal void UpdateTasks(ImmutableList<Boundary.Data.Task> tasks)
        {
            grid.Controls.Clear();

            var offset = 0;
            var index = 0;

            for (var r = 0; r < grid.RowCount; ++r)
            {
                for (var c = 0; c < (grid.ColumnCount / 2) - 1; ++c)
                {
                    var task = new Task();
                    task.Dock = DockStyle.Fill;

                    this.tasks.Add(task);
                    grid.Controls.Add(task, (c * 2) + offset, r);
                    grid.SetColumnSpan(task, 2);

                    task.BackColor = ((c + r) % 2 == 0) ?
                        Color.FromArgb(20, 20, 20) :
                        Color.FromArgb(25, 25, 25);

                    task.Index = index++;
                }
                offset += 1;
            }
        }
    }
}
