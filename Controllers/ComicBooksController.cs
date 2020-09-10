using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        // GET: ComicBooks
        public ActionResult Index()
        {
            return View();
        }
    }
}