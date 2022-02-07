using FootballSiteTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.Data.Interfaces
{
    public interface IAllFootballPlayers
    {
        IEnumerable<FootballPlayer> FootballPlayers { get; }
        FootballPlayer GetFootballPlayer(int id);
        void EditFootballPlayer(FootballPlayer changedPlayer);
        IEnumerable<string> GetTeamNames();
        void DeleteFootballPlayer(int id);
    }
}
