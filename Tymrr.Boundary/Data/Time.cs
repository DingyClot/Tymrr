namespace Tymrr.Boundary.Data
{
    public struct Time
    {
        readonly public static Time Zero = new Time(0);

        public Time(double seconds)
        {
            this.secondsMinusOne = seconds - 1;
        }

        private double secondsMinusOne;
    }
}
