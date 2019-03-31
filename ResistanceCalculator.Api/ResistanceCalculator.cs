using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistanceCalculator.Api
{
    public class ResistanceCalculator : IResistanceCalculator
    {
        private readonly IDictionary<string, int> _bands;
        private readonly IDictionary<string, long> _multiplier;
        private readonly IDictionary<string, double> _tolerance;

        public ResistanceCalculator()
        {
            _bands = new Dictionary<string, int>
            {
                     {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange", 3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue", 6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
            };

            _multiplier = new Dictionary<string, long>
         {
                    {"pink", -3},
                    {"silver",  -2},
                    {"gold",  -1},
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange",3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue",  6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
         };

            _tolerance = new Dictionary<string, double>
            {
                 {"silver", 0.10},
                    {"gold", 0.05},
                    {"brown",  0.01},
                    {"red", 0.02},
                    {"yellow", 0.05},
                    {"green", 0.005},
                    {"blue", 0.0025},
                    {"violet", 0.001},
                    {"gray", 0.0005}
            };

        }

        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        public CalculateResistanceResponse CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            try
            {
                var ohmValue = Convert.ToInt32($"{_bands[bandAColor]}{_bands[bandBColor]}");
                var multiplier = _multiplier[bandCColor];
                var tolerance = _tolerance[bandDColor];

                double resultMax = (ohmValue * Math.Pow(10, multiplier) * (1 + tolerance));
                double resultMin = (ohmValue * Math.Pow(10, multiplier) * (1 - tolerance));

                var response = new CalculateResistanceResponse
                {
                    MinimumResistance = this.FormatResistanceValue(resultMin),
                    MaximumResistance = this.FormatResistanceValue(resultMax)
                };

                return response;
            }

            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Formats the resistance value.
        /// </summary>
        /// <param name="num"> resistance value </param>
        /// <returns>formatted string of a resistance value</returns>
        private string FormatResistanceValue(double num)
        {

            if (num >= 100000000)
            {
                return (num / 1000000).ToString("#,0M");
            }

            else if (num >= 10000000)
                return (num / 1000000).ToString("0.#") + "M";

            else if (num >= 100000)
                return (num / 1000).ToString("#,0K");

            else if (num >= 10000)
                return (num / 1000).ToString("0.#") + "K";

            else
                return num.ToString();

        }
    }
}
