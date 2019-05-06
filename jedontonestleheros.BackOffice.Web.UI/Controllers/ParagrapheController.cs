using jeudontonestleheros.Core.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jedontonestleheros.BackOffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region A supprimer apres entitys
        private List<Paragraphe> _maList = new List<Paragraphe>(){

            new Paragraphe() { Id = 1, Numero = 1, Titre ="Titre 1" },
            new Paragraphe() { Id = 2, Numero = 10, Titre ="Titre 2" },
            new Paragraphe() { Id = 3, Numero = 33, Titre ="Titre 3" },
            new Paragraphe() { Id = 4, Numero = 44, Titre ="Titre 4" }
        };
        #endregion

        #region Methodes Publiques
        public ActionResult Create()
        {
            return this.View();
        }
                  
        [HttpPost]
        public ActionResult Create(Paragraphe paragraphe)
        {
            return this.View();
        }
        
        public ActionResult Update(int Id)
        {
            Paragraphe paragraphe = null;

            paragraphe = _maList.First(item => item.Id == Id);

            return this.View(paragraphe);
        }
        #endregion

    }
}
