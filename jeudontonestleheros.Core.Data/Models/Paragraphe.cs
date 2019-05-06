using System;
using System.Collections.Generic;
using System.Text;

namespace jeudontonestleheros.Core.Data
{
    public class Paragraphe
    {
        #region Propriétés
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        #endregion

        public Question maQuestion { get; set; }
    }
}
