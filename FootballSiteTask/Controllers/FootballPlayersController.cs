using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballSiteTask.Data.Interfaces;
using FootballSiteTask.ViewModels;
using FootballSiteTask.Data.Models;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballSiteTask.Controllers
{
    public class FootballPlayersController : Controller
    {
        private readonly IAllFootballPlayers _allFootballPlayers;

        public FootballPlayersController(IAllFootballPlayers allFootballPlayers)
        {
            _allFootballPlayers = allFootballPlayers;
        }

        [HttpPost]
        public ViewResult Edit(int id)
        {
            var model = new SelectionPageVM();
            model.FootballPlayer = _allFootballPlayers.GetFootballPlayer(id);
            model.TeamNames = _allFootballPlayers.GetTeamNames();
            return View(model);
        }

        [HttpPost]
        public JsonResult Save(SelectionPageVM model)
        {
            _allFootballPlayers.EditFootballPlayer(model.FootballPlayer);
            model.TeamNames = _allFootballPlayers.GetTeamNames();
            return Json(JsonConvert.SerializeObject(model.FootballPlayer)); 
        }

        [HttpPost]
        public void Delete(int id)
        {
            _allFootballPlayers.DeleteFootballPlayer(id);
        }

        public ViewResult FootballPlayersView() 
        {
            ViewBag.Title = "Страница с футболистами";
            return View(_allFootballPlayers);
        }
    }
}
