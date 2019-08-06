using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter.Logic;
using static UnitConverter.Logic.Enums;

namespace UniConverter.LogicTest
{
    [TestClass]
    public class TemperatureCelciusTest
    {
        [TestMethod]
        public void Test_Convert_C_to_F()
        {
            UnitConverter<TemperatureUnit> converter = new UnitConverter<TemperatureUnit>();
            Temperature t1 = new Temperature(TemperatureUnit.Celcius);
            Temperature t2 = new Temperature(TemperatureUnit.Farenheight);
            float res = t1.ToUnit(21, t2);
            Assert.AreEqual(res.ToString(), "69.8");
        }

        [TestMethod]
        public void Test_Convert_C_to_K()
        {
            UnitConverter<TemperatureUnit> converter = new UnitConverter<TemperatureUnit>();
            Temperature t1 = new Temperature(TemperatureUnit.Celcius);
            Temperature t2 = new Temperature(TemperatureUnit.Kelvin);
            float res = t1.ToUnit(21, t2);
            Assert.AreEqual(res.ToString(), "294.15");
        }

        [TestMethod]
        public void Test_Convert_C_to_C()
        {
            UnitConverter<TemperatureUnit> converter = new UnitConverter<TemperatureUnit>();
            Temperature t1 = new Temperature(TemperatureUnit.Celcius);
            Temperature t2 = new Temperature(TemperatureUnit.Celcius);
            float res = t1.ToUnit(21, t2);
            Assert.AreEqual(res.ToString(), "21");
        }
    }
}
