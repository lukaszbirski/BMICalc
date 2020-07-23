using System;
using System.Collections.Generic;
using System.Text;

namespace BMICalc.logic
{
    public class Converters
    {
        public static double poundsToKilogramsConverter(double pound)
        {
            return pound / 2.2046;
        }

        public static double feetsAndInchesToCentimitersConverte(double feet, double inch)
        {
            return 30.48 * feet + 2.54 * inch;
        }
    }
}
