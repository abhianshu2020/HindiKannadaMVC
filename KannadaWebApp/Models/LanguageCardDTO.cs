using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KannadaWebApp.Models
{
    public class LanguageCardDTO
    {
        public IEnumerable<SelectListItem> categoriesForDropdown { get; set; }
        public string WordCategory { get; set; }
        public string SentenceCategory { get; set; }
        public int CardId { get; set; }
        public string HindiText { get; set; }
        public string KannadaText { get; set; }
    }
}