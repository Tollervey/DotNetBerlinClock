using System;

namespace BerlinClock.Classes.Factories
{
    public class HoursLightsFactory : MultiLineLightsFactoryBase
    {
        private readonly byte _hours;

        public HoursLightsFactory(byte hours)
        {
            _hours = hours;
        }

        public string GetValue()
        {
            return $"{GetFirstRow( 5, 4, Constants.RED_LIGHT_VALUE, Constants.OFF_LIGHT_VALUE)}{GetSecondRow(5, 4, Constants.RED_LIGHT_VALUE, Constants.OFF_LIGHT_VALUE)}";
        }

        private string GetFirstRow(byte multiple, byte totalLightCountForRow, string onValue, string offValue)
        {
            return ConvertToBerlinLightString(totalLightCountForRow, NumberOfMultiplesForRow(_hours, multiple), onValue, offValue) + Environment.NewLine;

        }

        private string GetSecondRow( byte multiple, byte totalLightCountForRow, string onValue, string offValue)
        {
            return ConvertToBerlinLightString(totalLightCountForRow, RemainderForRow(_hours, multiple), onValue, offValue);

        }
    }
}
