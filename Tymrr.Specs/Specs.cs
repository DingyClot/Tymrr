using NUnit.Framework;
using Should;
using Tymrr.Boundary;

namespace Tymrr.Specs
{
    [TestFixture]
    class Start
    {
        public Boundary.System app;
        public Boundary.UserTasks user;

        public FrontEndSpy ui = new FrontEndSpy();

        [SetUp]
        public void Initialise()
        {
            app = new CheckingApp(ui);
            user = app.UserTasks;
        }

        [Test]
        public void With_no_previous_tasks_returns_12_inactive_tasks()
        {
            user.Start();

            ui.CurrentTasks.Count.ShouldEqual(12);
            ui.CurrentTasks.ForEach(task => task.Active.ShouldBeFalse());
        }
    }


}
