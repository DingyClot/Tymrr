using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using Tymrr.Boundary;

namespace Tymrr.UserTasks
{
    public class UserTasks : Boundary.UserTasks
    {
        FrontEnd ui;

        public UserTasks(FrontEnd ui)
        {
            this.ui = ui;
        }
        public void Start()
        {
            var tasks = ImmutableList.CreateBuilder<Task>();

            for (int i = 0; i < 12; ++i)
            {
                tasks.Add(new Task());
            }

            ui.UpdateTasks(tasks.ToImmutable());
        }
    }
}
