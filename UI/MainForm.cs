using System;
using System.Collections.Immutable;
using System.Drawing;
using System.Windows.Forms;
using Tymrr.Boundary.Data;
using Tymrr.Boundary.Protocols;

namespace Tymrr.WinForms
{
    public partial class MainForm : Form, FrontEnd
    {
        private App app;

        public MainForm()
        {
            InitializeComponent();

            PerformLayout();

            this.DoubleBuffered = true;
            this.SetStyle(
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);

            ClientSize = new Size(500, 300);

            app = new App(this);

            app.UserTasks.Start.Do();
        }

        public void RequestTaskName()
        {
//            throw new NotImplementedException();
        }

        public void UpdateRunningTask(int taskID, Time zero)
        {
//            throw new NotImplementedException();
        }

        public void UpdateTasks(ImmutableList<Boundary.Data.Task> tasks)
        {
            taskBoard.UpdateTasks(tasks);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            var aspect = 5.0/3.0;

            if (this.ClientSize.Width < this.ClientSize.Height * aspect)
            {
                taskBoard.Size = new Size(
                    this.ClientSize.Width,
                    (int)(this.ClientSize.Width / aspect));

                taskBoard.Location = new Point(
                    0,
                    this.ClientSize.Height / 2 - taskBoard.Height / 2);
            }
            else
            {
                taskBoard.Size = new Size(
                    (int)(this.ClientSize.Height * aspect),
                    this.ClientSize.Height);

                taskBoard.Location = new Point(
                    this.ClientSize.Width / 2 - taskBoard.Width / 2,
                    0);
            }
        }

        private void taskBoard_Click(object sender, EventArgs e)
        {
            app.UserTasks.Create.Begin((e as TaskEventArgs).Index);
        }
    }
}
