using System;

namespace BerlinClock.Classes.Factories
{
    public class MinutesLightsFactory : MultiLineLightsFactoryBase
    {
        private readonly byte _minutes;
        public MinutesLightsFactory(byte minutes)
        {
            _minutes = minutes;
        }
        public string GetValue()
        {
            return $"{GetFirstRow( 5, 11, Constants.YELLOW_LIGHT_VALUE, Constants.OFF_LIGHT_VALUE, Constants.CONTRAST_LIGHT_VALUE, 3)}{GetSecondRow(5, 4, Constants.YELLOW_LIGHT_VALUE, Constants.OFF_LIGHT_VALUE)}";
        }

        private string GetFirstRow(byte multiple, byte totalLightCountForRow, string onValue, string offValue, string contrastLightString, byte contrastNthPosition)
        {
            return ConvertToBerlinLightString(totalLightCountForRow, NumberOfMultiplesForRow(_minutes, multiple), onValue, offValue, contrastLightString, contrastNthPosition) + Environment.NewLine;

        }

        private string GetSecondRow(byte multiple, byte totalLightCountForRow, string onValue, string offValue)
        {
            return ConvertToBerlinLightString(totalLightCountForRow, RemainderForRow(_minutes, multiple), onValue, offValue);

        }
    }
}
