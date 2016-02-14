using Tymrr.Activities;
using Tymrr.Boundary.Protocols;

namespace Tymrr
{
    public class App : TymrrSystem
    {
        public App(FrontEnd ui)
        {
            UserTasks = new UserTaskCollection(ui);
        }

        public UserTasks UserTasks { get ; }
    }
}
