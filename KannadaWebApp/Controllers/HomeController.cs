using KannadaWebApp.Models;
using KannadaWebApp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KannadaWebApp.Controllers
{
    public class HomeController : Controller
    {
        IHindiKannadaRepository repo = new HindiKannadaRepository();
        public ActionResult Index()
        {
            List<LanguageCard> cards = repo.GetAllCards();
            return View(cards);
        }

        [HttpGet]
        public PartialViewResult Verbs()
        {
            List<LanguageCard> cards = repo.GetAllCards();
            return PartialView("Fruits", cards);
        }

        [HttpGet]
        public PartialViewResult Fruits()
        {
            List<LanguageCard> cards = repo.GetAllCards();
            cards.RemoveAt(1);
            return PartialView("Fruits", cards);
        }

        [HttpGet]
        public PartialViewResult BodyParts()
        {
            List<LanguageCard> cards = repo.GetAllCards();
            cards.RemoveAt(2);
            return PartialView("Fruits", cards);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}