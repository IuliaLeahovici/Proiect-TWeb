using eUseControl.BussinesLogic.Interfaces;
using eUseControl.BussinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Data.Entities.Product;

namespace eUseControl.Web.Controllers
{
    public class HomeController : BaseController
    {
          private readonly ISession _session;
          public HomeController()
          {
               var bl = new BussinessLogic();
               _session = bl.GetSessionBL();
          }


        public ActionResult Index()
        {
            var bestsellerBooks = _session.GetBooksList().OrderByDescending(f => f.Bought).Take(4);
            var cheapBooks = _session.GetBooksList().OrderBy(f => f.Price).Take(6);
            ViewBag.bestsellerBooks = bestsellerBooks;
            ViewBag.cheapBooks = cheapBooks;
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Product_details(string name)
        {
               var book = _session.GetBooksList().FirstOrDefault(f => f.Name == name);
               var booksList = _session.GetBooksList().Where(f => f.Type == book.Type).ToList().Take(5);

               ViewBag.book = book;
               ViewBag.booksList = booksList;
               return View();
        }
        public ActionResult Shop(string type)
        {
               List<BookTable> booksList;
               if (type == "All")
               {
                    booksList = _session.GetBooksList();
               }
               else
               {
                    booksList = _session.GetBooksList().Where(f => f.Type == type).ToList();
               }
               ViewBag.booksList = booksList;
               return View();
        }

    }
}