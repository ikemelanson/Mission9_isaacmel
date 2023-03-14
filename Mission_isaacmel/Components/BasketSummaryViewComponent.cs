using Microsoft.AspNetCore.Mvc;
using Mission_isaacmel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//create a summary of what is in the users basket
namespace Mission_isaacmel.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public BasketSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
