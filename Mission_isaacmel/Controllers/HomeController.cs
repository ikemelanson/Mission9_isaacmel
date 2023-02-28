using Microsoft.AspNetCore.Mvc;
using Mission_isaacmel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_isaacmel.Controllers
{
    public class HomeController : Controller
    {
        private IMission_isaacmelRepository repo;

        public HomeController (IMission_isaacmelRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index()
        {
            var blah = repo.Books.ToList();

            return View(blah);
        }
    }
}
