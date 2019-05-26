using System;
using System.ComponentModel.DataAnnotations;

namespace papikos.Models
{
    public class Kamar
    {   
        // [Display(Name="No")]
        public int IdKamar{get;set;}
        
        // [Display(Name="Nama")]
        public string Gambar{get;set;}

        // [Display(Name="Email")]
        public string UkuranKamar{get;set;}
        
        // [Display(Name="Password")]
        public string HargaKamar{get;set;}
       
        // [Display(Name="Nomor Telepon")]
        public string StatusKamar{get;set;}

        // [Display(Name="Alamat")]
        public string Alamat{get;set;}
    }
}