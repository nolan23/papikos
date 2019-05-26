using System;
using System.ComponentModel.DataAnnotations;

namespace papikos.Models
{
    public class Registrasi
    {   
        // [Display(Name="No")]
        public int Id{get;set;}
        
        // [Display(Name="Nama")]
        public string Username{get;set;}

        // [Display(Name="Email")]
        public string Email{get;set;}
        
        // [Display(Name="Password")]
        public string Password{get;set;}
       
        // [Display(Name="Nomor Telepon")]
        public string NoTelepon{get;set;}

        // [Display(Name="Alamat")]
        public string Alamat{get;set;}
    }
}