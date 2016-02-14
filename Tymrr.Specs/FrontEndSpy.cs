using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Immutable;
using Tymrr.Boundary;

namespace Tymrr.Specs
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
