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
    public partial class UrunEkle : Form
    {
        
        public UrunEkle()
        {
            InitializeComponent();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtMenu.Text == "" || nudFiyat.Value == 0)
            {
                MessageBox.Show("Lütfen Boş alan bırakmayın");
            }
            else
            {
                Hamburger menu = new Hamburger();
                menu.MenuAd = txtMenu.Text;
                menu.Fiyat = nudFiyat.Value;
                Hamburger.MenuListesi.Add(menu);
            }
        }
    }
}
