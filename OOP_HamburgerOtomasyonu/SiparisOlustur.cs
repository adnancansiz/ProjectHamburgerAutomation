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
    
    public partial class SiparisOlustur : Form
    {

        public static List<Siparis> siparisListesi = new List<Siparis>();
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        decimal toplam;
        decimal anaToplam;
        string boyut;
        string ekstralar;
        decimal sonToplam;
        

        
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            btnTamamla.Enabled = false;
            rbKucuk.Checked = true;
            foreach (Hamburger menu in Hamburger.MenuListesi)
            {
                cmbMenu.Items.Add(menu.MenuAd);
                
            }
            
            
            foreach (Ekstralar ekstra in Ekstralar.ekstraListe)
            {
                CheckBox check = new CheckBox();
                check.Text = ekstra.EkstraAd;
                flwEkstra.Controls.Add(check);

            }



        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            btnTamamla.Enabled = true;
            if (cmbMenu.SelectedItem == null || nudAdet.Value <= 0)
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun!!!");
            }
            else
            {
                foreach (Hamburger menu in Hamburger.MenuListesi)
                {
                    if (menu.MenuAd == cmbMenu.Text)
                    {

                        toplam += menu.Fiyat;
                    }
                }



                if (rbKucuk.Checked)
                {
                    toplam += 0;
                    boyut = "Küçük";
                }
                if (rbOrta.Checked)
                {
                    toplam += 3;
                    boyut = "Orta";
                }
                if (rbBuyuk.Checked)
                {
                    toplam += 5;
                    boyut = "Büyük";
                }

                Siparis siparis = new Siparis();
                EkstraEkle(siparis);
                siparis.MenuAdi = cmbMenu.Text;
                siparis.Boyut = boyut;
                siparis.Adet = nudAdet.Value;
                anaToplam += toplam * nudAdet.Value;
                siparis.AraToplam = anaToplam;
                siparis.Ekstralar = ekstralar;
                siparisListesi.Add(siparis);

                sonToplam += anaToplam;
                lblToplamTutar.Text = sonToplam.ToString();

                listBox1.Items.Add($"Menü={siparis.MenuAdi}, Boyut={siparis.Boyut}, Extralar={ekstralar}, Adet={siparis.Adet} Toplam Tutar={toplam * nudAdet.Value}");

                ekstralar = "";
                toplam = 0;
                anaToplam = 0;
            }
        }

        private void EkstraEkle(Siparis s)
        {
            foreach (CheckBox check in flwEkstra.Controls)
            {
                if (check.Checked == true)
                {
                    foreach (Ekstralar eks in Ekstralar.ekstraListe)
                    {
                        if (check.Text == eks.EkstraAd)
                        {
                            s.EkstraGelir += eks.EkstraFiyat;
                            toplam += eks.EkstraFiyat;
                            ekstralar += check.Text + " ";
                            s.EkstraAdet++;

                        }
                    }

                }
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Tutar :" + sonToplam.ToString() + " " + "\nToplam Sipariş Adeti : " + listBox1.Items.Count+"\nTamamlamak İstiyor musunuz ?", "Sipariş Özeti",MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr==DialogResult.Yes)
            {
                cmbMenu.Text = "";
                rbBuyuk.Checked = false;
                rbKucuk.Checked = false;
                rbOrta.Checked = false;
                nudAdet.Value = 0;
                foreach (CheckBox c in flwEkstra.Controls)
                {
                    c.Checked = false;
                }
                lblToplamTutar.Text = "0";
                listBox1.Items.Clear();
            }
            else
            {

            }
        }
    }
}
