using FootballSiteTask.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using FootballSiteTask.Data.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FootballSiteTask.ViewModels;
using FootballSiteTask.Data.Repository;

namespace FootballSiteTask.Controllers
{
    public class HomeController : Controller
    {
        public ISelectionPage _homeRepository;

        public HomeController(ISelectionPage homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public ViewResult Index()
        {
            var model = new SelectionPageVM();
            model.TeamNames = _homeRepository.GetTeamNames();
            model.FootballPlayer = new FootballPlayer();
            ViewBag.Title = "Home";
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult ApproachIndex(SelectionPageVM selectionPageVM)
        {
            _homeRepository.AddFootballPlayer(selectionPageVM.FootballPlayer);
            return RedirectToAction("Index");
        }
    }
}
