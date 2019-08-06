using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Logic;
using static UnitConverter.Logic.Enums;

namespace UniConverter.LogicTest
{
    [TestClass]
    public class TemperatureFarenhieghtTest
    {
        [TestMethod]
        public void Test_Convert_F_to_F()
        {
            UnitConverter<TemperatureUnit> converter = new UnitConverter<TemperatureUnit>();
            Temperature t1 = new Temperature(TemperatureUnit.Farenheight);
            Temperature t2 = new Temperature(TemperatureUnit.Farenheight);
            float res = t1.ToUnit(21, t2);
            Assert.AreEqual("21", res.ToString());
        }

        [TestMethod]
        public void Test_Convert_F_to_K()
        {
            UnitConverter<TemperatureUnit> converter = new UnitConverter<TemperatureUnit>();
            Temperature t1 = new Temperature(TemperatureUnit.Farenheight);
            Temperature t2 = new Temperature(TemperatureUnit.Kelvin);
            float res = t1.ToUnit(21, t2);
            Assert.AreEqual("267.0389", res.ToString());
        }

        [TestMethod]
        public void Test_Convert_F_to_C()
        {
            UnitConverter<TemperatureUnit> converter = new UnitConverter<TemperatureUnit>();
            Temperature t1 = new Temperature(TemperatureUnit.Farenheight);
            Temperature t2 = new Temperature(TemperatureUnit.Celcius);
            float res = t1.ToUnit(21, t2);
            Assert.AreEqual("-6.111112", res.ToString());
        }
    }
}
