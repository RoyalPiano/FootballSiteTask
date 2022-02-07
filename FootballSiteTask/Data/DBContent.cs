using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballSiteTask.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballSiteTask.Data
{
    public class DBContent : DbContext
    {
		public DBContent(DbContextOptions<DBContent> options)
			: base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<FootballPlayer> FootballPlayers { get; set; }
	}
}
