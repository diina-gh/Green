﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Green02Entities : DbContext
    {
        public Green02Entities()
            : base("name=Green02Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fruitier> Fruitier { get; set; }
        public virtual DbSet<Marecher> Marecher { get; set; }
        public virtual DbSet<Plantes> Plantes { get; set; }
        public virtual DbSet<profil> profil { get; set; }
        public virtual DbSet<Utilisateurs> Utilisateurs { get; set; }
    }
}
