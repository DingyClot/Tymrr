using System.Collections.Generic;
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
            for (var r = 0; r < grid.RowCount; ++r)
            {
                for (var c = 0; c < (grid.ColumnCount / 2) - 1; ++c)
                {
                    var task = new Task();
                    task.Dock = DockStyle.Fill;

                    tasks.Add(task);
                    grid.Controls.Add(task, (c * 2) + offset, r);
                    grid.SetColumnSpan(task, 2);
                }
                offset += 1;
            }
        }
    }
}
