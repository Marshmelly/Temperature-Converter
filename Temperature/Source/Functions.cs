using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class Functions
    {
        public static float ConvertToKelvin(float nmbr, string typ)
        {
            switch (typ)
            {
                case "Celsius": return (float)(nmbr + 273.15);
                case "Fahrenheit": return (float)((nmbr - 32) * (5/9) + 273.15);
                case "Rankine": return (float)((nmbr-491.67) * 5/9);
                default: return nmbr;
            }
        }

        public static float ConvertToFahrenheit(float nmbr, string typ)
        {
            switch (typ)
            {
                case "Celsius": return (float)(nmbr * 9/5 + 32);
                case "Kelvin": return (float)(nmbr * 9/5 - 459.67);
                case "Rankine": return (float)(nmbr - 459.67);
                default: return nmbr;
            }
        }

        public static float ConvertToCelcius(float nmbr, string typ)
        {
            switch (typ)
            {
                case "Fahrenheit": return (float)((nmbr - 32) * 5/9);
                case "Kelvin": return (float)(nmbr - 273.15);
                case "Rankine": return (float)((nmbr - 273.15) / (9/5));
                default: return nmbr;
            }
        }

        public static float ConvertToRankine(float nmbr, string typ)
        {
            switch (typ)
            {
                case "Celsius": return (float)(nmbr + 273.15) * 9/5;
                case "Fahrenheit": return (float)(nmbr+459.67);
                case "Kelvin": return (float)(nmbr) * 9 / 5;
                default: return nmbr;
            }
        }
    }
}
