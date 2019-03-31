using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistanceCalculator.Web.Models
{
    /// <summary>
    /// View model that represents the colors for calculating the OHM value.
    /// </summary>
    public class ColorModel
    {  
        /// <summary>
        /// Gets or sets the value that represents the bands.
        /// </summary>
        public Dictionary<string, string> Bands { get; private set; }
        
        /// <summary>
        /// Gets or sets the value that represents the multipliers.
        /// </summary>
        public Dictionary<string, string> Multipliers { get; private set; }
        
        /// <summary>
        /// Gets or sets the value that represents the tolerance.
        /// </summary>
        public Dictionary<string, string> Tolerance { get; private set; }

        public ColorModel()
        {
            
            Bands = new Dictionary<string, string> {
                    {"black", "black"},
                    {"brown", "brown"},
                    {"red", "red"},
                    {"orange", "orange"},
                    {"yellow", "yellow"},
                    {"green", "green"},
                    {"blue", "blue"},
                    {"violet", "violet"},
                    {"gray", "gray"},
                    {"white", "white"}
                };

            
            Multipliers = new Dictionary<string, string> {
                    {"pink", "pink"},
                    {"silver", "silver"},
                    {"gold", "gold"},
                    {"black", "black"},
                    {"brown", "brown"},
                    {"red", "red"},
                    {"orange", "orange"},
                    {"yellow", "yellow"},
                    {"green", "green"},
                    {"blue", "blue"},
                    {"violet",  "violet"},
                    {"gray",  "gray"},
                    {"white", "white"}
            };

            
            Tolerance = new Dictionary<string, string> {
                    {"silver",  "silver"},
                    {"gold",  "gold"},
                    {"yellow", "yellow"},
                    {"red", "red"},
                    {"brown", "brown"},
                    {"green", "green"},
                    {"blue",  "blue"},
                    {"violet", "violet"},
                    {"gray", "gray"}
            };
        }
    }
}
