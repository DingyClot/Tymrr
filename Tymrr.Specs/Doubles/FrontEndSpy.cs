using System;
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

        public void UpdateTasks(ImmutableList<Task> tasks)
        {
            CurrentTasks = tasks;
        }

        public void UpdateRunningTask(int taskID, Time timeStamp)
        {
            RunningTask = new RunningTask(timeStamp);
        }

        public void RequestTaskName()
        {
            Received_RequestTaskName = true;
        }

        public ImmutableList<Task> CurrentTasks { get; internal set; }

        public RunningTask RunningTask { get; internal set; }

        public bool Received_RequestTaskName { get; internal set; }
    }
}
