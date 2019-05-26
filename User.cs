using System;
using System.ComponentModel.DataAnnotations;

namespace papikos.Models
{
    public class User
    {   
        // [Display(Name="No")]
        public int Id{get;set;}
        
        // [Display(Name="Nama")]
        public string Username{get;set;}

   
        
        // [Display(Name="Password")]
        public string Password{get;set;}
    }
}