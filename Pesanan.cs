using System;
using System.ComponentModel.DataAnnotations;

namespace papikos.Models
{
     public class Pesanan
    {   
        public int IdPesanan{get;set;}
        
        public int IdRenter{get;set;}

        public int IdKamar{get;set;}

        public int IdKos{get;set;}

        public int NamaKos{get;set;}

        public List<Renter> Renters {get; set;}
        public List<Kamar> Kamars {get; set;}
        public List<Kos> Koss {get; set;}
    }


     public class Renter
    {   
        public int IdRenter{get;set;}
        
        public string NamaRenter{get;set;}

        public string NoTelepon{get;set;}

        public string Alamat{get;set;}

        public string Email{get;set;}

        public int IdPesanan { get; set; }
   		public Pesanan Pesanan { get; set; }
    }

     public class Kamar
    {   

        public int IdKamar{get;set;}

        public string Gambar{get;set;}

        public string UkuranKamar{get;set;}

        public string HargaKamar{get;set;}

        public string StatusKamar{get;set;}

        public string Alamat{get;set;}

        public int IdPesanan { get; set; }
   		public Pesanan Pesanan { get; set; }
    }

     public class Kos
    {   

        public int Id{get;set;}

        public string NamaKos{get;set;}

        public int JumlahKamar{get;set;}

        public string  DeskripsiTambahan{get;set;}

        public int IdPesanan { get; set; }
   		public Pesanan Pesanan { get; set; }
    }


}