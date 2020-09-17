//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab5_GalynaMatsygin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SoldPet
    {
        public int Id { get; set; }
        public Nullable<int> CategoryId { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Gender { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Category Category { get; set; }
    }
}