namespace BerlinClock.Classes
{
    public static class StringExtensions
    {
        public static bool TryParseTimeString(this string aTime, out byte hours, out byte minutes, out byte seconds)
        {
            hours = 0;
            minutes = 0;
            seconds = 0;

            if (string.IsNullOrEmpty(aTime))
            {
                return false;
            }

            var splitString = aTime.Split(':');

            if (splitString.Length != 3)
            {
                return false;
            }

            if (byte.TryParse(splitString[0], out hours) && byte.TryParse(splitString[1], out minutes) && byte.TryParse(splitString[2], out seconds))
            {
                if (hours > 24 || minutes > 59 || seconds > 59)
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}
