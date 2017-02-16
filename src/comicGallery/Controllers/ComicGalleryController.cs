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

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his greatest act of revenge! Even if Spider-Man survives . . . <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();
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