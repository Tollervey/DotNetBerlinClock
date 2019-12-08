using System.Text;

namespace BerlinClock.Classes.Factories
{
    public abstract class MultiLineLightsFactoryBase
    {
        protected string ConvertToBerlinLightString(byte totalLights, int onLights, string onString, string offString, string contrastLightString = null, byte? contrastNthPosition = null)
        {
            StringBuilder sb = new StringBuilder();

            for (byte i = 0; i < totalLights; i++)
            {
                if (i < onLights)
                {
                    if ((contrastLightString != null && contrastNthPosition != null) && ((i + 1) % contrastNthPosition == 0))
                    {
                        sb.Append(contrastLightString);
                    }
                    else
                    {
                        sb.Append(onString);
                    }
                }
                else
                {
                    sb.Append(offString);
                }
            }

            return sb.ToString();
        }

        protected int NumberOfMultiplesForRow(byte timeUnit, byte multiple)
        {
            return timeUnit / multiple;
        }

        protected int RemainderForRow(byte timeUnit, byte multiple)
        {
            return timeUnit % multiple;
        }
    }
}
