using NUnit.Framework;
using Should;
using Tymrr.Boundary.Data;
using Tymrr.Boundary.Protocols;
using Tymrr.Specs.Doubles;

namespace Tymrr.Specs.ManageCurrentTasks
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

            ui.CurrentTasks[taskID].Active.ShouldBeTrue();
        }

        [Test]
        public void Starts_the_timer_for_the_task()
        {
            var taskID = 0;
            user.Create.Begin(taskID);

            ui.RunningTask.TimeStamp.ShouldEqual(Time.Zero);
        }
        [Test]

        public void Requests_a_task_name_from_the_ui()
        {
            var taskID = 0;
            user.Create.Begin(taskID);

            ui.Received_RequestTaskName.ShouldBeTrue();
        }
    }
}
