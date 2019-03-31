using Microsoft.AspNetCore.Mvc;
using ResistanceCalculator.Api;
using ResistanceCalculator.Api.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ResistanceCalculator.Test.ApiTests
{
    public class ResistanceCalculatorControllerTest
    {
        private IResistanceCalculator _resistanceCalculator;

        [Fact]
        public void CalculateResistance_NullRequest_ReturnsErrorResponse()
        {
            //Arrange
            _resistanceCalculator = new ResistanceCalculator.Api.ResistanceCalculator();
            var controller = new ResistanceCalculatorController(_resistanceCalculator);

            //Act

            var response = controller.CalculateResistance(null);

            //Assert
            Assert.NotNull(response);
            var objectResult = response.Result as ObjectResult;
            Assert.NotNull(objectResult);
            Assert.Equal(500, objectResult.StatusCode);
        }

        [Fact]
        public void CalculateResistance_InvalidRequest_ReturnsErrorResponse()
        {
            //Arrange
            _resistanceCalculator = new ResistanceCalculator.Api.ResistanceCalculator();
            var controller = new ResistanceCalculatorController(_resistanceCalculator);
            var request = new CalculateResistanceRequest { BandAColor = "black", BandBColor = "black", BandCColor = "black", BandDColor = null };

            //Act
            var response = controller.CalculateResistance(request);

            //Assert
            Assert.NotNull(response);
            var objectResult = response.Result as ObjectResult;
            Assert.NotNull(objectResult);
            Assert.Equal(500, objectResult.StatusCode);
        }

        [Theory]
        [InlineData("black", "brown", "red", "green", "99.5", "100.5")]
        [InlineData("yellow", "orange", "red", "green", "4278.5", "4321.5")]
        [InlineData("blue","black","red","red","5880","6120")]
        public void CalculateResistance_ValidRequest_ReturnsCalculatedValues(string bandAColor, string bandBColor, string bandCColor, string bandDColor, string minResistanceValue, string maxResistanceValue)
        {
            //Arrange
            _resistanceCalculator = new ResistanceCalculator.Api.ResistanceCalculator();
            var controller = new ResistanceCalculatorController(_resistanceCalculator);
            var request = new CalculateResistanceRequest { BandAColor = bandAColor, BandBColor = bandBColor, BandCColor = bandCColor, BandDColor = bandDColor };

            //Act
            var response = controller.CalculateResistance(request);

            //Assert
            Assert.NotNull(response);
            var objectResult = response.Result as ObjectResult;
            Assert.IsType<OkObjectResult>(objectResult);
            Assert.Equal(200, objectResult.StatusCode);
            Assert.NotNull(objectResult.Value);
            var calculatorResponse = objectResult.Value as CalculateResistanceResponse;
            Assert.NotNull(calculatorResponse);
            Assert.Equal(minResistanceValue, calculatorResponse.MinimumResistance);
            Assert.Equal(maxResistanceValue, calculatorResponse.MaximumResistance);
        }
    }   
}
