using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents the prize to be added
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// represents the place number
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// represents the name of the place the person is placed in
        /// </summary>
        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }
    }
}
