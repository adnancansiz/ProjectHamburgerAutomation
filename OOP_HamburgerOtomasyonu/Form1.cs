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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width+30;
            this.Height = _childForm.Height+70;
            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SiparisOlustur siparisOlustur = new SiparisOlustur();
            //siparisOlustur.MdiParent = this;
            //siparisOlustur.Show();

            ChildForm(new SiparisOlustur());
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UrunEkle urunEkle = new UrunEkle();
            //urunEkle.MdiParent = this;
            //urunEkle.Show();
            ChildForm(new UrunEkle());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            //ekstraMalzeme.MdiParent = this;
            //ekstraMalzeme.Show();
            ChildForm(new EkstraMalzeme());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
            //siparisBilgileri.MdiParent = this;
            //siparisBilgileri.Show();
            ChildForm(new SiparisBilgileri());
        }
    }
}
