using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{/// <summary>
/// represents one matchup
/// </summary>
    public class MatchupModel
    {/// <summary>
    /// Represents entries to tournament
    /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// represents the winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// represents one round
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
