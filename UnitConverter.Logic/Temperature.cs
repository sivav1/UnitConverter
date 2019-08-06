using System;
using System.Collections.Generic;
using System.Text;
using static UnitConverter.Logic.Enums;

namespace UnitConverter.Logic
{
    public class Temperature : Unit<TemperatureUnit>
    {
        public Temperature(TemperatureUnit tempUnit) : base(UnitType.Temperature, tempUnit)
        {
            
        }

        public override float ToUnit(float value, Unit<TemperatureUnit> destUnit)
        {
            float result = value;
            if (SubUnitType == destUnit.SubUnitType)
                return result;

            switch (destUnit.SubUnitType)
            {
                case TemperatureUnit.Celcius:
                    switch (SubUnitType)
                    {
                        case TemperatureUnit.Farenheight:
                            result = (value - 32.0f) * (5.0f/9.0f);
                            break;
                        case TemperatureUnit.Kelvin:
                            result = value - 273.15f;
                            break;
                    }
                    break;
                case TemperatureUnit.Farenheight:
                    switch (SubUnitType)
                    {
                        case TemperatureUnit.Celcius:
                            result = (value * 1.8f) + 32.0f;
                            break;
                        case TemperatureUnit.Kelvin:
                            result = (value * 9 / 5) - 459.67f;
                            break;
                    }
                    break;
                case TemperatureUnit.Kelvin:
                    switch (SubUnitType)
                    {
                        case TemperatureUnit.Celcius:
                            result = value + 273.15f;
                            break;
                        case TemperatureUnit.Farenheight:
                            result = (float)(value + 459.67f) * (5.0f / 9.0f);
                            break;
                    }
                    break;
            }
            return result;
        }
    }

}
