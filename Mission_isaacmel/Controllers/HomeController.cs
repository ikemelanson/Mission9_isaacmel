using Microsoft.AspNetCore.Mvc;
using Mission_isaacmel.Models;
using Mission_isaacmel.Models.ViewModels;
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
        public IActionResult Index(int pageNum = 1)
        {
            //initialize the number of book to be show on one page
            int pageSize = 10;

            //make new book view model
            var x = new BooksVIewModel
            {
                Books = repo.Books
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
