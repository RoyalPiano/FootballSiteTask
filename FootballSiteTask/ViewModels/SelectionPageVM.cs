using FootballSiteTask.Data.Models;
using FootballSiteTask.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballSiteTask.ViewModels
{
    public class SelectionPageVM
    {
        public FootballPlayer FootballPlayer { get; set; }
        public IEnumerable<string> TeamNames { get; set; }
    }
}
