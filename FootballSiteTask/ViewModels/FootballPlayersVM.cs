using FootballSiteTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.ViewModels
{
    public class FootballPlayersVM
    {
        public IEnumerable<FootballPlayer> FootballPlayers { get; set; }
        public string CurrentCategory { get; set; }
    }
}
