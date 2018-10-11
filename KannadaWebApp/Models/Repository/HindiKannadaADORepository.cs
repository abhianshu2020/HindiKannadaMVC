using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KannadaWebApp.Models.Repository
{
    public class HindiKannadaADORepository : IHindiKannadaADORepository
    {
        public IEnumerable<LanguageCard> GetCardsFrom(string category)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["GearHost"].ConnectionString;
            string sqlGet = "spGetWordsFromCategory";

            SqlCommand command = new SqlCommand(sqlGet, conn);
            //command.CommandText = sqlGet;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@category", category);
            List<LanguageCard> languageCards = new List<LanguageCard>();
            using (conn)
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LanguageCard card = new LanguageCard();
                    //card.CardId = Convert.ToInt16(reader[0].ToString());
                    card.HindiText = reader[0].ToString();
                    card.KannadaText = reader[1].ToString();
                    languageCards.Add(card);
                }
            }
            return languageCards;
        }

        public IEnumerable<LanguageCard> GetAllWords()
        {
            List<LanguageCard> languageCards = new List<LanguageCard>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["GearHost"].ConnectionString;
            string sqlGet = "SELECT * FROM hindiKannadaWords";

            SqlCommand command = new SqlCommand(sqlGet, conn);
            try
            {

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LanguageCard card = new LanguageCard();
                    card.CardId = Convert.ToInt16(reader[0].ToString());
                    card.HindiText = reader[1].ToString();
                    card.KannadaText = reader[2].ToString();
                    languageCards.Add(card);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return languageCards;
        }

        public IEnumerable<string> GetAllCategories()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["GearHost"].ConnectionString;
            string sqlGet = "SELECT category FROM categories";

            SqlCommand command = new SqlCommand(sqlGet, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string> categories = new List<string>();
            while (reader.Read())
            {
                string category = reader[0].ToString();
                
                categories.Add(category);
            }
            reader.Close();
            return categories;
        }

        public int SaveLanguagePair(LanguageCardDTO languagePair)
        {
            int count = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["GearHost"].ConnectionString;
            string sqlGet = "spAddWords";

            SqlCommand command = new SqlCommand(sqlGet, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@category", languagePair.WordCategory);
            command.Parameters.AddWithValue("@hindiWord", languagePair.HindiText);
            command.Parameters.AddWithValue("@kannadaWord", languagePair.KannadaText);
            
            conn.Open();
            count = command.ExecuteNonQuery();
            return count;
        }

        public IEnumerable<LanguageCard> GetAllGeneralWords()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LanguageCard> GetAllNumbers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LanguageCard> GetAllPronouns()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LanguageCard> GetAllQuestionWords()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LanguageCard> GetAllRelationships()
        {
            throw new NotImplementedException();
        }

       
    }
}