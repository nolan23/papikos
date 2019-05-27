using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PapiKos.Models
{
    public class Kos
    {
        [Display(Name = "No")]
        public int Id { get; set; }

        [Display(Name = "Nama Kos")]
        public string NamaKos { get; set; }


        [Display(Name = "Jumlah Kamar")]
        public int JumlahKamar { get; set; }

        [Display(Name = "Deskripsi Tambahan")]
        public string DeskripsiTambahan { get; set; }

        [Display(Name = "Alamat")]
        public string Alamat { get; set; }

        public List<Kamar> Kamars { get; set; }
        public Owner Owner { get; set; }
    }
}