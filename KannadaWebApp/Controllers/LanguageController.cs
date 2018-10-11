using KannadaWebApp.Models;
using KannadaWebApp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KannadaWebApp.Controllers
{
    public class LanguageController : Controller
    {
        IHindiKannadaADORepository ADORepo = new HindiKannadaADORepository();
        // GET: Language
        public ActionResult AddWords()
        {
            LanguageCardDTO languageCardDTO = new LanguageCardDTO();
            IEnumerable<string> categories = ADORepo.GetAllCategories();
            languageCardDTO.categoriesForDropdown = GetAllCategoriesSelectList(categories);
            return View(languageCardDTO);
        }

        public ActionResult SaveLanguagePair(LanguageCardDTO languageCardDTO)
        {
            int isInserted = ADORepo.SaveLanguagePair(languageCardDTO);
            return PartialView();
        }


        //public ActionResult someNotificationThingyToTellEntryAdded

        #region Private Methods
        private IEnumerable<SelectListItem> GetAllCategoriesSelectList(IEnumerable<string> categories)
        {
            var selectList = new List<SelectListItem>();

            foreach (var category in categories)
            {
                selectList.Add(new SelectListItem()
                {
                    Value = category,
                    Text = category
                });
            }
            return selectList;
        }
        #endregion
    }
}