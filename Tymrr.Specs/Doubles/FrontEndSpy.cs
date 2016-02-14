using System.Collections.Immutable;
using Tymrr.Boundary.Data;
using Tymrr.Boundary.Protocols;

namespace Tymrr.Specs.Doubles
{
    internal class FrontEndSpy : FrontEnd
    {
        public FrontEndSpy()
        {
            CurrentTasks = ImmutableList.Create<Task>();
        }
        public ImmutableList<Task> CurrentTasks { get; internal set; }

        public void UpdateTasks(ImmutableList<Task> tasks)
        {
            CurrentTasks = tasks;
        }
    }
}
