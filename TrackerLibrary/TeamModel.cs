using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents one team
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// represents the team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// represents the team name
        /// </summary>
        public string TeamName { get; set; }

    }
}
