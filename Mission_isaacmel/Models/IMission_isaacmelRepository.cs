using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_isaacmel.Models
{
    public interface IMission_isaacmelRepository
    {
        IQueryable<Book> Books { get; }
    }
}
