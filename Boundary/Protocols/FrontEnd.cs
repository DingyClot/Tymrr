using System;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymrr.Boundary
{
    public interface FrontEnd
    {
        void UpdateTasks(ImmutableList<Task> tasks);
    }
}
