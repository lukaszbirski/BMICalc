using System;
using System.Collections.Generic;
using System.Text;
using BMICalc.utils;

namespace BMICalc.models
{
    public class Bmi
    {
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public Bmi(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
            if (height > 0) this.result = Math.Round(weight / (cmsToMetersConverter(height) * cmsToMetersConverter(height)),2);
            else this.result = 0;
        }

        private double cmsToMetersConverter(double cm)
        {
            return cm / 100;
        }

        public String getDescription()
        {
            if (result < 16) return BMIDescription.STARVATION_STRING;
            else if (result >= 16 && result < 17) return BMIDescription.EMACIATION_STRING;
            else if (result >= 17 && result < 18.5) return BMIDescription.UNDERWEIGHT_STRING;
            else if (result >= 18.5 && result < 25) return BMIDescription.NORMAL_WEIGHT_STRING;
            else if (result >= 25 && result < 30) return BMIDescription.OVERWEIGHT_STRING;
            else if (result >= 30 && result < 35) return BMIDescription.OBESITY_STRING;
            else if (result >= 35 && result < 40) return BMIDescription.MEGA_OBESITY_STRING;
            else return BMIDescription.EXTREME_OBESITY_STRING;
        }

    }
}
