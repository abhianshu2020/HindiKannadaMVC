using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KannadaWebApp.Models.Repository
{
    public interface IHindiKannadaADORepository
    {
        IEnumerable<LanguageCard> GetCardsFrom(string category);
        IEnumerable<LanguageCard> GetAllPronouns();
        IEnumerable<string> GetAllCategories();
        IEnumerable<LanguageCard> GetAllGeneralWords();
        IEnumerable<LanguageCard> GetAllQuestionWords();
        IEnumerable<LanguageCard> GetAllNumbers();
        IEnumerable<LanguageCard> GetAllRelationships();
        IEnumerable<LanguageCard> GetAllWords();
        int SaveLanguagePair(LanguageCardDTO languagePair);
    }
}