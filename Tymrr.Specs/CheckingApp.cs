using System;
using Tymrr.Boundary;

namespace Tymrr.Specs
{
    public class CheckingApp : Boundary.System
    {
        private FrontEnd ui;

        public CheckingApp(FrontEnd ui)
        {
            this.ui = ui;
            UserTasks = new Tymrr.UserTasks.UserTasks(ui);
        }

        public Boundary.UserTasks UserTasks { get; }
    }
}
