using System;
using System.ComponentModel.DataAnnotations;

namespace papikos.Models
{
    public class Pesanan
    {   
        // [Display(Name="No")]
        public int IdPesanan{get;set;}
        
         // [Display(Name="No")]
        public int IdRenter{get;set;}

         // [Display(Name="No")]
        public int IdKamar{get;set;}

         // [Display(Name="No")]
        public int IdKos{get;set;}

         // [Display(Name="No")]
        public int NamaKos{get;set;}
    }
}