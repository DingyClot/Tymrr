using System.Collections.Immutable;
using Tymrr.Boundary.Data;

namespace Tymrr.Boundary.Protocols
{
    public interface FrontEnd
    {
        void UpdateTasks(ImmutableList<Task> tasks);

        void UpdateRunningTask(int taskID, Time zero);

        void RequestTaskName();
    }
}
