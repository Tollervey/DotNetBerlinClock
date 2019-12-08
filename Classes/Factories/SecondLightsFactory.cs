namespace BerlinClock.Classes.Factories
{
    public class SecondLightsFactory
    {
        private readonly byte _seconds;
        public SecondLightsFactory(byte seconds)
        {
            _seconds = seconds;
        }

        public string GetValue()
        {
            return IsOdd(_seconds) ? Constants.OFF_LIGHT_VALUE : Constants.YELLOW_LIGHT_VALUE;
        }

        private static bool IsOdd(byte value)
        {
            return value % 2 != 0;
        }
    }
}
