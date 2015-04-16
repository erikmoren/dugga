using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dugga
{
    [TestClass]
    public class UnitTest1
    {
        private Shortcut sc = new Shortcut();

        [TestMethod]
        public void Convert10kto10000()
        {
            //Arrange
            string value = "10k";
            long expected = 10000;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Convert10mto10000000()
        {
            //Arrange
            string value = "10m";
            long expected = 10000000;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void Convert10Bto10000000000()
        {
            //Arrange
            string value = "10B";
            long expected = 10000000000;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert10Tto10000000000000()
        {
            //Arrange
            string value = "10T";
            long expected = 10000000000000;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        

        [TestMethod]
        public void ConvertNoCharsEnteredReturnDigits()
        {
            //Arrange
            string value = "100";
            long expected = 100;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertOnlyChar()
        {
            //Arrange
            string value = "k";
            long expected = 1000;
            
            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertBadCharReturnMinusOne()
        {
            //Arrange
            string value = "f";
            long expected = -1;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertTwoCharsEnteredReturnMinusOne()
        {
            //Arrange
            string value = "100mm";
            long expected = -1;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertCharBetweenNumbersReturnMinusOne()
        {
            //Arrange
            string value = "10k10";
            long expected = -1;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Convert55kto55000()
        {
            //Arrange
            string value = "55k";
            long expected = 55000;

            //Act
            long actual = sc.Convert(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
