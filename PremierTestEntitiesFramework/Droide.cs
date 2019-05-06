using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PremierTestEntitiesFramework
{
    [Table("Droide")]
    public class Droide
    {
        public int Id { get; set; }
        public Armes arme { get; set; }
        public string Matricule { get; set; }
    }
}
