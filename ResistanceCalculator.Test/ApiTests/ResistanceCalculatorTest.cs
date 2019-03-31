using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ResistanceCalculator.Test.ApiTests
{
    public class ResistanceCalculatorTest
    {
        [Theory]
        [InlineData("black", "brown", "red", "green", "99.5", "100.5")]
        [InlineData("yellow", "orange", "red", "green", "4278.5", "4321.5")]
        [InlineData("blue", "black", "red", "red", "5880", "6120")]
        public void CalculateOhmValue_InputValues_ReturnsMinAndMaxResistanceValues(string bandAColor, string bandBColor, string bandCColor, string bandDColor, string minResistanceValue, string maxResistanceValue)
        {
            //Arrange

            var resistanceCalculator  = new ResistanceCalculator.Api.ResistanceCalculator();

            //Act

            var response = resistanceCalculator.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);

            //Assert
            Assert.NotNull(response);
            Assert.NotNull(response.MinimumResistance);
            Assert.NotNull(response.MaximumResistance);
            Assert.Equal(minResistanceValue, response.MinimumResistance);
            Assert.Equal(maxResistanceValue, response.MaximumResistance);
        }
    }


}
