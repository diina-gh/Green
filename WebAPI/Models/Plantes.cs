//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Plantes
    {
        public int id { get; set; }
        public string designation { get; set; }
        public System.DateTime datePlante { get; set; }
        public int Taille { get; set; }
        public double Poids { get; set; }
        public string Humidite { get; set; }
    
        public virtual Fruitier Fruitier { get; set; }
        public virtual Marecher Marecher { get; set; }
    }
}
