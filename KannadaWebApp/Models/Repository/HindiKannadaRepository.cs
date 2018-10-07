using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KannadaWebApp.Models.Repository
{
    public class HindiKannadaRepository : IHindiKannadaRepository
    {
        public List<LanguageCard> GetAllCards()
        {
            List<LanguageCard> languageCards = new List<LanguageCard>();

            LanguageCard card1 = new LanguageCard();
            card1.HindiText = "namaste";
            card1.KannadaText = "namaskara";

            LanguageCard card2 = new LanguageCard();
            card2.HindiText = "doodh";
            card2.KannadaText = "halu";

            LanguageCard card3 = new LanguageCard();
            card3.HindiText = "dijiye";
            card3.KannadaText = "kodi";

            LanguageCard card4 = new LanguageCard();
            card4.HindiText = "kidhar";
            card4.KannadaText = "yelli";

            LanguageCard card5 = new LanguageCard();
            card5.HindiText = "gobhi";
            card5.KannadaText = "hukosu";

            LanguageCard card6 = new LanguageCard();
            card6.HindiText = "gobhi";
            card6.KannadaText = "hukosu";

            LanguageCard card7 = new LanguageCard();
            card7.HindiText = "gobhi";
            card7.KannadaText = "hukosu";

            LanguageCard card8 = new LanguageCard();
            card8.HindiText = "gobhi";
            card8.KannadaText = "hukosu";

            LanguageCard card9 = new LanguageCard();
            card9.HindiText = "gobhi";
            card9.KannadaText = "hukosu";

            LanguageCard card10 = new LanguageCard();
            card10.HindiText = "gobhi";
            card10.KannadaText = "hukosu";

            LanguageCard card11 = new LanguageCard();
            card11.HindiText = "gobhi";
            card11.KannadaText = "hukosu";


            languageCards.Add(card1);
            languageCards.Add(card2);
            languageCards.Add(card3);
            languageCards.Add(card4);
            languageCards.Add(card5);
            languageCards.Add(card6);
            languageCards.Add(card7);
            languageCards.Add(card8);
            languageCards.Add(card9);
            languageCards.Add(card10);
            languageCards.Add(card11);
            //languageCards.Add(card12);

            return languageCards;

        }

        public IEnumerable<LanguageCard> GetAllPronouns()
        {
            List<LanguageCard> pronouns = new List<LanguageCard>();

            LanguageCard pronoun1 = new LanguageCard();
            pronoun1.HindiText = "main";
            pronoun1.KannadaText = "nanu";

            LanguageCard pronoun2 = new LanguageCard();
            pronoun2.HindiText = "hum";
            pronoun2.KannadaText = "navu";

            LanguageCard pronoun3 = new LanguageCard();
            pronoun3.HindiText = "mera";
            pronoun3.KannadaText = "nanna";

            LanguageCard pronoun4 = new LanguageCard();
            pronoun4.HindiText = "humara";
            pronoun4.KannadaText = "namma";

            LanguageCard pronoun5 = new LanguageCard();
            pronoun5.HindiText = "mujhko";
            pronoun5.KannadaText = "nanage";

            LanguageCard pronoun6 = new LanguageCard();
            pronoun6.HindiText = "humko";
            pronoun6.KannadaText = "namage";

            pronouns.Add(pronoun1);
            pronouns.Add(pronoun2);
            pronouns.Add(pronoun3);
            pronouns.Add(pronoun4);
            pronouns.Add(pronoun5);
            pronouns.Add(pronoun6);

            return pronouns;
        }

        public IEnumerable<LanguageCard> GetAllQuestionWords()
        {
            List<LanguageCard> questionWords = new List<LanguageCard>()
            {
                new LanguageCard
                {
                    HindiText = "kya",
                    KannadaText = "enu"
                },
                new LanguageCard
                {
                    HindiText = "kyun",
                    KannadaText = "yake"
                }
            };

            return questionWords;

        }
    }
}