using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comic_Book_Gallery.Data;
using Comic_Book_Gallery.Models;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        // GET: ComicBooks
        public ActionResult Index()
        {
            return View();
        }

        // ovo upitnik znaci da id parametar moze biti nullable
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }
    }
}