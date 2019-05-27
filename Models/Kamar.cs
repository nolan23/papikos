using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PapiKos.Models
{
    public class Kamar
    {
        [Display(Name = "No")]
        public int KamarId { get; set; }

        [Display(Name = "Gambar")]
        public string Gambar { get; set; }

        [Display(Name = "Ukuran Kamar")]
        public string UkuranKamar { get; set; }

        [Display(Name = "Harga Kamar")]
        public string HargaKamar { get; set; }

        [Display(Name = "Status Kamar")]
        public string StatusKamar { get; set; }

        [Display(Name = "Deskripsi Kamar")]
        public string DeskripsiKamar { get; set; }
        // [Display(Name="Informasi Tambahan Kamar")]
        // public List<string> InformasiTambahan { get; set; }
        public int KosId { get; set; }
        public Kos Kos { get; set; }
    }
}