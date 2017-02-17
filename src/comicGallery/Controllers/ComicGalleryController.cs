using comicGallery.Data;
using comicGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comicGallery.Controllers
{
    public class ComicGalleryController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicGalleryController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id) // "action" method
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            // This approach, below, is object initializer syntax
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }
    }
}

/* 
 
 Notes:
 1) Other classes can accept "public" modifiers    
 2) Common to add "controllers" to Controllers folder
 3) "action" method performs actions to prepare response   
 4) Convention . . . views in Views folder
    Filename should match action method
*/