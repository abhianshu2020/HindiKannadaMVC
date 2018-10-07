using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KannadaWebApp.Models.Repository
{
    public class HindiKannadaADORepository : IHindiKannadaADORepository
    {
        public IEnumerable<LanguageCard> GetAllWords()
        {
            throw new NotImplementedException();
        }
    }
}