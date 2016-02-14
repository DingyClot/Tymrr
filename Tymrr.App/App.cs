using Tymrr.Boundary;

namespace Tymrr
{
    public class App : Boundary.System
    {
        public App(FrontEnd ui)
        {
            UserTasks = new Tymrr.UserTasks.UserTasks(ui);
        }

        public Boundary.UserTasks UserTasks { get ; }
    }
}
