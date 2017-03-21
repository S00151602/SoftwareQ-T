using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareQ_T;

namespace TestProject
{
    [TestClass]
       

    public class InsuranceTest
    {
        //Female-Pass
        [TestMethod]
        public void ShouldReturnPrenuimForFemaleWhoIsNineTeen_Pass()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(19, "female");
            //Assert
            Assert.AreEqual(5.00, result);

        }
        
[TestMethod]
        public void ShouldReturnPrenuimForFemaleWhoIsThirtyTwo_Pass()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(32, "female");
            //Assert
            Assert.AreEqual(2.50, result);

        }

        [TestMethod]
        public void ShouldReturnPrenuimForFemaleWhoIsOverOrFifty_Pass()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(50, "female");
            //Assert
            Assert.AreEqual(0.375, result);

        }


        //Male-PASS
        [TestMethod]
        public void ShouldReturnPrenuimForMaleWhoIsNineTeen_Pass()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(19, "male");
            //Assert
            Assert.AreEqual(6.00, result);

        }

        [TestMethod]
        public void ShouldReturnPrenuimForMaleWhoIsThirtySix_Pass()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(36, "male");
            //Assert
            Assert.AreEqual(5.00, result);

        }

        [TestMethod]
        public void ShouldReturnPrenuimForMaleWhoIsOverOrFifty_Pass()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(50, "male");
            //Assert
            Assert.AreEqual(0.75, result);

        }

        //No Gender Given
        [TestMethod]
        public void ShouldReturnPrenuimOfZero_Pass()
        {
            //Arrange
            SoftQ_T sut = new SoftQ_T();
            //Act
            double result = sut.CalcPremium(50, "T");
            //Assert
            Assert.AreEqual(0.00, result);

        }


    }
}
