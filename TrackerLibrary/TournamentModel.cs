using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// represents one tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// represents the tournament name
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// represents the entry fee
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// represents the teams entered into the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// represents the winning prizes if there are any
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// represents matchups in the tournament
        /// </summary>
        public List<List<MatchupModel>> MatchupModels { get; set; } = new List<List<MatchupModel>>();
    }
}
