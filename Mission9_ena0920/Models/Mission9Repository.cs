using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_ena0920.Models
{
    public interface Mission9Repository
    {
        IQueryable<Book> Books { get; }
    }
}
