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
        public ActionResult Detail() // "action" method
        {
            // This approach, below, is object initializer syntax
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his greatest act of revenge! Even if Spider-Man survives . . . <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Models.Artist() {Name = "Dan Slott", Role = "Script" },
                    new Models.Artist() {Name = "Humberto Ramos", Role = "Pencils" },
                    new Models.Artist() {Name = "Victor Olazaba", Role = "Inks" },
                    new Models.Artist() {Name = "Edgar Delgado", Role = "Colors" },
                    new Models.Artist() {Name = "Chris Eliopoulos", Role = "Letters" },
                }
            };

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