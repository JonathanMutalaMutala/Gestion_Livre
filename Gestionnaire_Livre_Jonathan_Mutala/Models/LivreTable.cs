//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestionnaire_Livre_Jonathan_Mutala.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LivreTable
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string DatePublication { get; set; }
        public Nullable<bool> SouhaiterAcheter { get; set; }
    }
}