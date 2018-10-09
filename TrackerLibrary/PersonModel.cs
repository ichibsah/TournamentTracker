using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{/// <summary>
/// represents one person
/// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The persons first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// the persons second name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// the persones email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// the persons cellphone number
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
