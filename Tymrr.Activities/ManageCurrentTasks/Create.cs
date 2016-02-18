using System.Collections.Immutable;
using Tymrr.Boundary.Protocols;
using Tymrr.Boundary.Data;

namespace Tymrr.Activities.ManageApplication
{
    public class Create : CreateAction
    {
        FrontEnd ui;

        public Create(FrontEnd ui)
        {
            this.ui = ui;
        }

        public void Begin(int taskID)
        {
            var tasks = ImmutableList.CreateBuilder<Task>();

            for (int i = 0; i < 12; ++i)
            {
                if (i == taskID)
                    tasks.Add(new Task(true));
                else
                    tasks.Add(new Task(false));
            }

            ui.UpdateTasks(tasks.ToImmutable());

            ui.UpdateRunningTask(taskID, Time.Zero);

            ui.RequestTaskName();
        }
    }
}
