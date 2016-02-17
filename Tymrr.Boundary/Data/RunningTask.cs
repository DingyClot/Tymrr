namespace Tymrr.Boundary.Data
{
    public struct RunningTask
    {
        readonly public Time TimeStamp;

        public RunningTask(Time timeStamp)
        {
            TimeStamp = timeStamp;
        }
    }
}
