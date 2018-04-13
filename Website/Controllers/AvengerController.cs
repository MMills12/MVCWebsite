using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class AvengerController : Controller
    {
        // GET: Avenger
        public ActionResult Index()
        {
            var heroList = new List<Avenger>
            {
                new Avenger() { Name = "Iron Man", Identity = "Tony Stark", Weapon = "Repulsor Cannon"},
                new Avenger() { Name = "Captain America", Identity = "Steve Rogers", Weapon = "Shield"},
                new Avenger() { Name = "Black Panther", Identity = "T'Challa", Weapon = "Vibranium Suit"},
                new Avenger() { Name = "Thor", Identity = "Thor Odinson", Weapon = "Mjolnir"},
                new Avenger() { Name = "Hulk", Identity = "Bruce Banner", Weapon = "Anger"},
                new Avenger() { Name = "Spider-Man", Identity = "Peter Parker", Weapon = "Webs"},
            };
            return View(heroList);
        }
    }
}