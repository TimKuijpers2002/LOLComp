using AutoMapper;
using LOGIC.Collections;
using LOGIC.Models.APIModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLLOLCompLOGIC
{
    [TestClass]
    public class LOLCompMatchTests
    {
        //!!Naming convention : MethodName _ StateUnderTest _ ExpectedBehavior!!

        private MatchCollection matchCollection = new MatchCollection(null);

        [TestMethod]
        public void CalculateKDA_WhenDataIsNotNull_ReturnsKDA()
        {
            // Arrange
            ParticipantStats stats = new ParticipantStats();
            stats.GetType().GetProperty("assists").SetValue(stats, 10);
            stats.GetType().GetProperty("kills").SetValue(stats, 15);
            stats.GetType().GetProperty("deaths").SetValue(stats, 5);
            double expectedKDA = (stats.kills + stats.assists) / stats.deaths;
            // Act
            var realKDA = matchCollection.CalculateKDA(stats);
            // Assert
            Assert.AreEqual(expectedKDA, realKDA);
        }

        [TestMethod]
        public void CalculateDelta_WhenDataTypeIsNotZero_ReturnsDelta()
        {
            // Arrange
            string oldValue = "200";
            string newValue = "800";
            var expectedFactor = (double.Parse(newValue) - double.Parse(oldValue));
            // Act
            var realFactor = matchCollection.CalculateDelta(oldValue, newValue);
            // Assert
            Assert.AreEqual(expectedFactor, realFactor);
        }

        [TestMethod]
        public void CalculateDelta_WhenOneDataTypeIsZero_ReturnsDelta()
        {
            // Arrange
            string oldValue = "0";
            string newValue = "800";
            var expectedFactor = 800;
            // Act
            var realFactor = matchCollection.CalculateDelta(oldValue, newValue);
            // Assert
            Assert.AreEqual(expectedFactor, realFactor);
        }

        [TestMethod]
        public void CalculateDelta_WhenAnotherDataTypeIsNotZero_ReturnsDelta()
        {
            // Arrange
            string oldValue = "200";
            string newValue = "0";
            var expectedFactor = -200;
            // Act
            var realFactor = matchCollection.CalculateDelta(oldValue, newValue);
            // Assert
            Assert.AreEqual(expectedFactor, realFactor);
        }

        [TestMethod]
        public void CalculateDelta_WhenTwoDataTypeIsNotZero_ReturnsDelta()
        {
            // Arrange
            string oldValue = "0";
            string newValue = "0";
            var expectedFactor = 0;
            // Act
            var realFactor = matchCollection.CalculateDelta(oldValue, newValue);
            // Assert
            Assert.AreEqual(expectedFactor, realFactor);
        }

    }
}
