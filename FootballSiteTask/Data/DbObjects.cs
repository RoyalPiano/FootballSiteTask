using FootballSiteTask.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.Data.Repository
{
    public class DbObjects
    {
        public static void Init(DBContent content)
        {
            if (!content.FootballPlayers.Any())
            {
                content.SaveChanges();
            }
        }
    }
}
