using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Ekstralar
    {
        public static List<Ekstralar> ekstraListe = new List<Ekstralar> 
        {
            new Ekstralar {EkstraAd="Ketçap",EkstraFiyat=1},
            new Ekstralar {EkstraAd="Mayonez",EkstraFiyat=1},
            new Ekstralar {EkstraAd="Ranch",EkstraFiyat=1},
            new Ekstralar {EkstraAd="Hardal",EkstraFiyat=1},
            new Ekstralar {EkstraAd="Barbekü",EkstraFiyat=1},
        };
        public string EkstraAd { get; set; }
        public decimal EkstraFiyat { get; set; }
        public int Adet { get; set; }



        public override string ToString()
        {
            return EkstraAd;
        }

    }
}
