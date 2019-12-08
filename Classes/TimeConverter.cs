using System;
using BerlinClock.Classes.Factories;
using BerlinClock.Interfaces;

namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        public string ConvertTime(string aTime)
        {
            if (aTime.TryParseTimeString(out var hours, out var minutes, out var seconds))
            {
                // Create seconds lights - First Row
                var secondLight = CreateSecondLights(seconds);

                // Create hours lights - Second/Third rows
                var hourLights = CreateHourLights(hours);

                // Create minutes lights - Fourth/Fifth rows
                var minuteLights = CreateMinuteLights(minutes);

                return $"{secondLight}{Environment.NewLine}{hourLights}{Environment.NewLine}{minuteLights}";

            }

            return $"Invalid time string {aTime}. Please check.";
        }

        private string CreateSecondLights(byte seconds)
        {
            var secondsFactory = new SecondLightsFactory(seconds);
            return secondsFactory.GetValue();
        }

        private string CreateHourLights(byte hours)
        {
            var hoursFactory = new HoursLightsFactory(hours);
            return hoursFactory.GetValue();
        }

        private string CreateMinuteLights(byte minutes)
        {
            var minutesFactory = new MinutesLightsFactory(minutes);
            return minutesFactory.GetValue();
        }
    }
}
