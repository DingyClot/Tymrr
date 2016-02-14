using System.Collections.Immutable;
using Tymrr.Boundary.Protocols;
using Tymrr.Boundary.Data;

namespace Tymrr.Activities.ManageApplication
{
    public class Start : StartAction
    {
        FrontEnd ui;

        public Start(FrontEnd ui)
        {
            this.ui = ui;
        }

        public void Do()
        {
            var tasks = ImmutableList.CreateBuilder<Task>();

            for (int i = 0; i < 12; ++i)
            {
                tasks.Add(new Task(false));
            }

            ui.UpdateTasks(tasks.ToImmutable());
        }
    }
}
