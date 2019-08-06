using System;
using System.Collections.Generic;
using static UnitConverter.Logic.Enums;

namespace UnitConverter.Logic
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEnum">SubUnittype enums like TemperatureUnit, VolumeUnit, etc</typeparam>
    public abstract class Unit<TEnum>
    {
        public UnitType UnitType { get; }
        public TEnum SubUnitType { get; set; }

        protected Unit(UnitType unitType, TEnum subUnitType)
        {
            UnitType = unitType;
            SubUnitType = subUnitType;
        }

        public abstract float ToUnit(float value, Unit<TEnum> destUnit);
    }
}
