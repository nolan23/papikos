using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PapiKos.Models
{
    public class Owner
    {
        [Display(Name = "No")]
        public int Id { get; set; }

        [Display(Name = "Nama")]
        public string Nama { get; set; }

        [Display(Name = "Nomor Telephone")]
        public String NomorTelephone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        public List<Kos> Kos { get; set; }
    }
}