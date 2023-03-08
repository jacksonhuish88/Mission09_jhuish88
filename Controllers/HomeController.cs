using Microsoft.AspNetCore.Mvc;
using Mission09_jhuish88.Models;
using Mission09_jhuish88.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jhuish88.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository repo;

        // CREATE BOOK REPO
        public HomeController (IBookRepository temp)
        {
            repo = temp;
        }

        // INDEX PAGE CALL
        public IActionResult Index(string bookCategory, int pageNum = 1)
        {
            int pageSize = 10;
            var x = new BooksViewModel
            {
                // CALL AND ORDER BOOK REPO
                Books = repo.Books
                .Where(b => b.Category == bookCategory || bookCategory == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                // ESTABLISH BOOK PAGE INFO 
                PageInfo = new PageInfo
                {
                    TotalNumBooks =
                        (bookCategory == null
                            ? repo.Books.Count()
                            : repo.Books.Where(x => x.Category == bookCategory).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }


    }
}
