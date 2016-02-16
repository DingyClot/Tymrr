using NUnit.Framework;
using Should;
using Tymrr.Boundary.Protocols;
using Tymrr.Specs.Doubles;

namespace Tymrr.Specs.ManageApplication
{
    [TestFixture]
    class Create
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
        public void Activates_a_currently_inactive_task()
        {
            var taskID = 0;
            user.Create.Begin(taskID);

            ui.CurrentTasks.Count.ShouldEqual(12);
            ui.CurrentTasks[taskID].Active.ShouldBeTrue();
        }
    }
}
