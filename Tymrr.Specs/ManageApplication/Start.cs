using NUnit.Framework;
using Should;
using Tymrr.Boundary.Protocols;
using Tymrr.Specs.Doubles;

namespace Tymrr.Specs.ManageApplication
{
    [TestFixture]
    class Start
    {
        public TymrrSystem app;
        public UserTasks user;

        public FrontEndSpy ui = new FrontEndSpy();

        [SetUp]
        public void Initialise()
        {
            app = new AppUnderTest(ui);
            user = app.UserTasks;
        }

        [Test]
        public void With_no_previous_tasks_returns_12_inactive_tasks()
        {
            user.Start.Do();

            ui.CurrentTasks.Count.ShouldEqual(12);
            ui.CurrentTasks.ForEach(task => task.Active.ShouldBeFalse());
        }
    }
}
