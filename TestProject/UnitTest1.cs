using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareQ_T;

namespace TestProject
{
    [TestClass]
       

    public class InsuranceTest
    {
        [TestMethod]
        public void ShouldReturnPrenuimForFemale()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(19, "female");
            //Assert
            Assert.AreEqual(2.50, result);

        }
    }
}
