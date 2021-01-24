using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            decimal ciro =0;
            int toplamSiparis =0;
            decimal ekstraGeliri = 0;
            decimal satılanÜrün = 0;


            foreach (var siparis in SiparisOlustur.siparisListesi)
            {
                ciro += siparis.AraToplam;
                toplamSiparis = SiparisOlustur.siparisListesi.Count();
                ekstraGeliri += siparis.EkstraGelir;
                satılanÜrün += siparis.Adet;


            }

            lblCiro.Text = ciro.ToString();
            lblEkstraMazlemeG.Text = ekstraGeliri.ToString();
            lblSatilanUrunA.Text = satılanÜrün.ToString();
            lblSiparisSayisi.Text = toplamSiparis.ToString();
            

            foreach (Siparis s in SiparisOlustur.siparisListesi)
            {
                listBox1.Items.Add($"Menü={s.MenuAdi}, Boyut={s.Boyut}, Extralar={s.Ekstralar}, Adet={s.Adet} Toplam Tutar={s.AraToplam}");
            }

        }
    }
}
