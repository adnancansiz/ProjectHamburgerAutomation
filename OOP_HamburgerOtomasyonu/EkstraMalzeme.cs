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
    public partial class EkstraMalzeme : Form
    {
        public EkstraMalzeme()
        {
            InitializeComponent();
        }
        
        private void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            if (txtEkstra.Text == "" || nudEkstraFiyat.Value == 0)
            {
                MessageBox.Show("Lütfen Boş alan bırakmayın");
            }
            else
            {
                Ekstralar ekstra = new Ekstralar();
                ekstra.EkstraAd = txtEkstra.Text;
                ekstra.EkstraFiyat = nudEkstraFiyat.Value;
                Ekstralar.ekstraListe.Add(ekstra);
            }
        }
    }
}
