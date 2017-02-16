using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comicGallery.Controllers
{
    public class ComicGalleryController : Controller
    {
        public ActionResult Detail() // "action" method
        {
            return View();
        }
    }
}

/* 
 
 Notes:
 1) Other classes can accept "public" modifiers    
 2) Common to add "controllers" to Controllers folder
 3) "action" method performs actions to prepare response   
     
*/