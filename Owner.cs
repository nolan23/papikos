using System;
using System.ComponentModel.DataAnnotations;

namespace papikos.Models
{
    public class Owner
    {   
        // [Display(Name="No")]
        public int Id{get;set;}
        
        // [Display(Name="Nama")]
        public string NamaOwner{get;set;}

        // [Display(Name="Email")]
        public string NoTelepon{get;set;}
        
        // [Display(Name="Password")]
        public string Alamat{get;set;}
       
        // [Display(Name="Nomor Telepon")]
        public string Email{get;set;}
    }
}