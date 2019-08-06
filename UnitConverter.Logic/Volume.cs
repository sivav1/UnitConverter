using System;
using System.Collections.Generic;
using System.Text;
using static UnitConverter.Logic.Enums;

namespace UnitConverter.Logic
{
    public class Volume : Unit<VolumeUnit>
    {
        public Volume(VolumeUnit volUnit) : base(UnitType.Volume, volUnit)
        {
            
        }

        public override float ToUnit(float value, Unit<VolumeUnit> destUnit)
        {
            float result = value;
            if (SubUnitType == destUnit.SubUnitType)
                return result;

            switch (destUnit.SubUnitType)
            {
                case VolumeUnit.Gallon:
                    switch (SubUnitType)
                    {
                        case VolumeUnit.Litre:
                            result = value * 0.26f;
                            break;
                        case VolumeUnit.Millilitre:
                            result = value * 0.000264f;
                            break;
                    }
                    break;
                case VolumeUnit.Litre:
                    switch (SubUnitType)
                    {
                        case VolumeUnit.Gallon:
                            result = value * 3.79f;
                            break;
                        case VolumeUnit.Millilitre:
                            result = value * 0.001f;
                            break;
                    }
                    break;
                case VolumeUnit.Millilitre:
                    switch (SubUnitType)
                    {
                        case VolumeUnit.Gallon:
                            result = value * 3785.41f;
                            break;
                        case VolumeUnit.Litre:
                            result = value * 1000.0f;
                            break;
                    }
                    break;
            }
            return result;
        }
    }
}
