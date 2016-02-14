using Tymrr.Activities;
using Tymrr.Boundary.Protocols;

namespace Tymrr.Specs
{
    public class AppUnderTest : TymrrSystem
    {
        public AppUnderTest(FrontEnd ui)
        {
            UserTasks = new UserTaskCollection(ui);
        }

        public UserTasks UserTasks { get; }
    }
}
