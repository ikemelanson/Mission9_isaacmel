using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission_isaacmel.Infastructure;
using Mission_isaacmel.Models;

namespace Mission_isaacmel.Pages
{
    public class BuyModel : PageModel
    {
        //bring in the repo
        private IMission_isaacmelRepository repo { get; set; }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }

        public BuyModel (IMission_isaacmelRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        //when you make a get request for this page
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        //when you post to the page
        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket.AddItem(b, 1, b.Price);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new { ReturnUrl = returnUrl});
        }
    }
}
