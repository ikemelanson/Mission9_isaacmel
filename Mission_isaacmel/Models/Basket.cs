using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_isaacmel.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        //add an item to the basket
        public virtual void AddItem (Book book, int qty, double price)
        {
            BasketLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = book,
                    Quantity = qty,
                    Price = price
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //remove one book from the basket
        public virtual void RemoveItem(Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        //empty the basket
        public virtual void ClearBasket()
        {
            Items.Clear();
        }

        //calculate the total for the basket
        public double CalcTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Price);
            return sum;
        }

    }

    public class BasketLineItem
    {
        //all the things we need to calculate basket totals
        [Key]
        public int LineId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
