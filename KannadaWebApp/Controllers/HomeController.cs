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
        IHindiKannadaADORepository ADORepo = new HindiKannadaADORepository();
        public ActionResult Index()
        {
            IEnumerable<LanguageCard> cards = ShuffleCards();
            return View(cards);
        }

        [HttpGet]
        public PartialViewResult GetRandomCards()
        {
            IEnumerable<LanguageCard> cards = ShuffleCards();
            return PartialView("~/Views/Partial Views/_Card.cshtml", cards);
        }

        [HttpGet]
        public PartialViewResult GetCards(string category)
        {
            IEnumerable<LanguageCard> cards = ADORepo.GetCardsFrom(category);
            return PartialView("~/Views/Partial Views/_Card.cshtml", cards);
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

        private IEnumerable<LanguageCard> ShuffleCards()
        {
            Random random = new Random();
            IEnumerable<LanguageCard> cards = ADORepo.GetAllWords();
            cards = cards.OrderBy(x => random.Next()).ToList();
            return cards;
        }
    }
}