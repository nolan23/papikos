using System;
using System.ComponentModel.DataAnnotations;

namespace papikos.Models
{
    public class Kos
    {   
        // [Display(Name="No")]
        public int Id{get;set;}
        
        // [Display(Name="Nama Kos")]
        public string NamaKos{get;set;}

        
        // [Display(Name="No")]
        public int JumlahKamar{get;set;}

        // [Display(Name="No")]
        public string  DeskripsiTambahan{get;set;}
    }
}