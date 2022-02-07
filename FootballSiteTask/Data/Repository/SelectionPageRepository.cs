using FootballSiteTask.Data.Interfaces;
using FootballSiteTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.Data.Repository
{
    public class SelectionPageRepository : ISelectionPage
    {
        private readonly DBContent _dbContent;
        public SelectionPageRepository(DBContent dBContent)
        {
            _dbContent = dBContent;
        }

        public IEnumerable<string> GetTeamNames()
        {
            return _dbContent.FootballPlayers.Select(w => w.TeamName).Distinct();
        }

        public FootballPlayer FootballPlayerModel { get; set; }

        public void AddFootballPlayer(FootballPlayer footballPlayer)
        {
            _dbContent.FootballPlayers.Add(footballPlayer);
            _dbContent.FootballPlayers.OrderBy(w => w.Id);
            _dbContent.SaveChanges();
        }
    }
}
