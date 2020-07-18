using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using BMICalc.models;

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
            //Arrange
            Bmi bmi = new Bmi(weight,height);

            //Act
            var result = bmi.Result;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(80, 180, "wagę prawidłową")]
        [TestCase(60, 185, "niedowagę")]
        [TestCase(60, 185, "niedowagę")]
        [TestCase(100, 185, "nadwagę")]
        public void Bmi_When_Using_Description_Should_Return_String(double weight, double height, string expected) 
        {
            //Arrange
            Bmi bmi = new Bmi(weight, height);

            //Act
            string result = bmi.getDescription();

            //Assert
            StringAssert.Contains(expected, result);

        }
    }
}
//weight, double height