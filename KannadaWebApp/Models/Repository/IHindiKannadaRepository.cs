using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KannadaWebApp.Models.Repository
{
    public interface IHindiKannadaRepository
    {
        List<LanguageCard> GetAllCards();
    }
}