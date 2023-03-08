using Microsoft.AspNetCore.Mvc;
using Mission09_jhuish88.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jhuish88.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IBookRepository repo { get; set; }
        public CategoryViewComponent(IBookRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["bookCategory"];

            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return View(categories);
        }
    }
}
