using System;
using System.Collections.Generic;
using System.Text;
using static UnitConverter.Logic.Enums;

namespace UnitConverter.Logic
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">SubUnittype enums like TemperatureUnit, VolumeUnit, etc</typeparam>
    public class UnitConverter<T> where T : Enum
    {
        public float Convert(float value, Unit<T> source, Unit<T> destination)
        {
            if (source.UnitType == destination.UnitType)
            {
                return source.ToUnit(value, destination);
            }
            return 0;
        }
    }
}
