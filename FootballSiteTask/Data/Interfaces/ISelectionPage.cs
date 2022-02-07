using FootballSiteTask.Data.Models;
using FootballSiteTask.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.Data.Interfaces
{
    public interface ISelectionPage
    {
        public void AddFootballPlayer(FootballPlayer footballPlayer);
        public IEnumerable<string> GetTeamNames();
        public FootballPlayer FootballPlayerModel { get; set; }
    }
}
