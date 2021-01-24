using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Hamburger
    {
        public static List<Hamburger> MenuListesi = new List<Hamburger> 
        {
            new Hamburger {MenuAd="Whooper",Fiyat=20},
            new Hamburger {MenuAd="BigKing",Fiyat=18},
            new Hamburger {MenuAd="Chicken",Fiyat=15}
            
        };
        public string MenuAd { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return MenuAd;
        }

    }
}
