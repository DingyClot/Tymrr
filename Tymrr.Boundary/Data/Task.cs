namespace Tymrr.Boundary.Data
{
    public struct Task
    {
        readonly public bool Active;

        public Task(bool activate)
        {
            Active = activate;
        }
    }
}
