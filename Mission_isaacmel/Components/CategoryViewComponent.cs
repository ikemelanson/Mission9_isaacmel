using Microsoft.AspNetCore.Mvc;
using Mission_isaacmel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_isaacmel.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IMission_isaacmelRepository repo { get; set; }

        public CategoryViewComponent(IMission_isaacmelRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookCategory"];

            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories);
        }
    }
}
