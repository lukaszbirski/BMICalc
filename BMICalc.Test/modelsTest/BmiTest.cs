using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using BMICalc.models;
using BMICalc.utils;

namespace BMICalc.Test.models
{
    [TestFixture]
    class BmiTest
    { 
        [TestCase(0,0,0)]
        [TestCase(1,1,10000)]
        [TestCase(1,0,0)]
        [TestCase(0,1,0)]
        [TestCase(1,-1,0)]
        [TestCase(80,180,24.69d)]
        public void Bmi_When_Adding_Weight_And_Height_Should_Return_BMI(double weight, double height, double expected)
        {
            Bmi bmi = new Bmi(weight,height);

            var result = bmi.Result;

            Assert.AreEqual(expected, result);
        }

        [TestCase(80, 180, BMIDescription.NORMAL_WEIGHT_STRING)]
        [TestCase(60, 185, BMIDescription.UNDERWEIGHT_STRING)]
        [TestCase(100, 185, BMIDescription.OVERWEIGHT_STRING)]
        public void Bmi_When_Using_Description_Should_Return_String(double weight, double height, string expected) 
        {
            Bmi bmi = new Bmi(weight, height);

            string result = bmi.getDescription();

            StringAssert.Contains(expected, result);
        }
    }
}