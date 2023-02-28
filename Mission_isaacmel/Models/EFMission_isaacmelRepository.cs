using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_isaacmel.Models
{
    public class EFMission_isaacmelRepository : IMission_isaacmelRepository
    {
        private BookstoreContext context { get; set; }
        public EFMission_isaacmelRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
