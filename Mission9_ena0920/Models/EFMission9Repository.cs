using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_ena0920.Models
{
    public class EFMission9Repository : Mission9Repository
    {
        private BookstoreContext context { get; set; }

        public EFMission9Repository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
