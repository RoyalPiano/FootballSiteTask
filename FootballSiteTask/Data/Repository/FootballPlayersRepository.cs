using FootballSiteTask.Data.Interfaces;
using FootballSiteTask.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.Data.Repository
{
    public class FootballPlayersRepository : IAllFootballPlayers
    {
        private readonly DBContent dbContent;
        public FootballPlayersRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<FootballPlayer> FootballPlayers
        {
            get 
            {
                return dbContent.FootballPlayers;//.Include(t => t);
            }
        }    

        public FootballPlayer GetFootballPlayer(int id)
        {
            var a = dbContent.FootballPlayers.FirstOrDefault(w => w.Id == id);
            return dbContent.FootballPlayers.FirstOrDefault(w => w.Id == id);
        }
        public IEnumerable<string> GetTeamNames()
        {
            return dbContent.FootballPlayers.Select(w => w.TeamName).Distinct();
        }

        public void DeleteFootballPlayer(int id)
        {
            dbContent.FootballPlayers.Remove(GetFootballPlayer(id));
            dbContent.SaveChanges();
        }

        public void EditFootballPlayer(FootballPlayer changedPlayer)
        {
            dbContent.FootballPlayers.Remove(GetFootballPlayer(changedPlayer.Id));
            dbContent.FootballPlayers.Add(changedPlayer);
            dbContent.FootballPlayers.OrderBy(w => w.Id);
            dbContent.SaveChanges();
        }
    }
}
