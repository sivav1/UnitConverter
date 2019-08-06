using System;
using UnitConverter.Logic;
using static UnitConverter.Logic.Enums;

namespace UnitConverter.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UnitConverter.Logic.UnitConverter<TemperatureUnit> t = new UnitConverter.Logic.UnitConverter<TemperatureUnit>();
            Temperature t1 = new Temperature(TemperatureUnit.Celcius);
            Temperature t2 = new Temperature(TemperatureUnit.Farenheight);
            Console.WriteLine(t1.ToUnit(21, t2));
            Console.ReadLine();
        }
    }
}
