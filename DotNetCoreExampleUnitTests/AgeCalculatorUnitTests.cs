using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetCoreExampleLibrary;
using System;

namespace DotNetCoreExampleUnitTests
{
    [TestClass]
    public class AgeCalculatorUnitTests
    {
        private readonly DateTime defaultBirthDate = new DateTime(1987, 12, 7);

        [TestMethod]
        public void ShouldCalculateAge()
        {
            Assert.AreEqual(31, new AgeCalculator().CalculateAge(defaultBirthDate, new DateTime(2019, 2, 11)));
        }

        [TestMethod]
        public void ShouldCalculateAgeForBirthDay()
        {
            Assert.AreEqual(32, new AgeCalculator().CalculateAge(defaultBirthDate, new DateTime(2019, defaultBirthDate.Month, defaultBirthDate.Day)));
        }
    }
}
