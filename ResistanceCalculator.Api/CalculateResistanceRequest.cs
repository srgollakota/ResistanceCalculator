using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistanceCalculator.Api
{
    /// <summary>
    /// DTO that represents the request for calculating the OHM value.
    /// </summary>
    public class CalculateResistanceRequest
    {
        /// <summary>
        /// Gets or sets the value that represents the band a color.
        /// </summary>
        public string BandAColor { get; set; }

        /// <summary>
        /// Gets or sets the value that represents the band b color.
        /// </summary>
        public string BandBColor { get; set; }

        /// <summary>
        /// Gets or sets the value that represents the band c color.
        /// </summary>
        public string BandCColor { get; set; }

        /// <summary>
        /// Gets or sets the value that represents the band d color.
        /// </summary>
        public string BandDColor { get; set; }

    }
}
