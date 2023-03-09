using Microsoft.AspNetCore.Mvc;
using Mission9_ena0920.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_ena0920.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private Mission9Repository repo { get; set; }

        public TypesViewComponent (Mission9Repository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["bookCategory"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }

    }
}
