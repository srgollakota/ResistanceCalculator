using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistanceCalculator.Api
{
    public class CalculateResistanceResponse
    {
        /// <summary>
        /// Gets or sets the value that represents the minimum resistance value.
        /// </summary>
        public string MinimumResistance { get; set; }

        /// <summary>
        /// Gets or sets the value that represents the maximum resistance value.
        /// </summary>
        public string MaximumResistance { get; set; }
    }
}
