using NUnit.Framework;
using Should;
using System.Collections.Immutable;

namespace Tymrr.Specs
{
    [TestFixture]
    class Start
    {
        public FrontEnd ui = new FrontEnd();
        public UserTasks user;

        [SetUp]
        public void Initialise()
        {
            user = new UserTasks(ui);
        }

        [Test]
        public void With_no_previous_tasks_returns_12_inactive_tasks()
        {
            user.Start();

            ui.CurrentTasks.Count.ShouldEqual(12);
            ui.CurrentTasks.ForEach(task => task.ShouldEqual(false));
        }
    }

    internal class FrontEnd
    {
        public FrontEnd()
        {
            CurrentTasks = ImmutableList.Create<bool>();
        }
        public ImmutableList<bool> CurrentTasks { get; internal set; }

        internal void UpdateTasks(ImmutableList<bool> tasks)
        {
            CurrentTasks = tasks;
        }
    }

    internal class UserTasks
    {
        FrontEnd ui;

        internal UserTasks(FrontEnd ui)
        {
            this.ui = ui;
        }

        internal void Start()
        {
            var tasks = ImmutableList.CreateBuilder<bool>();

            for (int i = 0; i < 12; ++i)
            {
                tasks.Add(false);
            }

            ui.UpdateTasks(tasks.ToImmutable());
        }
    }
}
