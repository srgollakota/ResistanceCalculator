
using ResistanceCalculator.Web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ResistanceCalculator.Test.WebTests
{
    
    public class ColorModelTest
    {
        [Fact]
        public void Constructor_Set_VerifiesWhetherFieldsAreSet()
        {
            var _colorModel = new ColorModel();

            Assert.NotNull(_colorModel);
            Assert.NotNull(_colorModel.Bands);
            Assert.NotNull(_colorModel.Multipliers);
            Assert.NotNull(_colorModel.Tolerance);
            Assert.True(_colorModel.Bands.Count > 0);
            Assert.True(_colorModel.Multipliers.Count > 0);
            Assert.True(_colorModel.Tolerance.Count > 0);           

        }
    }
}
