using Tymrr.Activities.ManageApplication;
using Tymrr.Boundary;
using Tymrr.Boundary.Protocols;

namespace Tymrr.Activities
{
    public class UserTaskCollection : UserTasks
    {
        FrontEnd ui;

        public UserTaskCollection(FrontEnd ui)
        {
            this.ui = ui;
        }
        public StartAction Start
        {
            get
            {
                return new Start(ui);
            }
        }
        public CreateAction Create
        {
            get
            {
                return new Create(ui);
            }
        }
    }
}
