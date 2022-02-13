using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuYonetimSistemi.WindowsFormsUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        public static int kullId = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = manager.Get(kullaniciAdi: txtKullaniciAdi.Text.Trim(), sifre: txtSifre.Text.Trim());
            if (kullanici != null)
            {
                kullId = kullanici.Id;
                AnaEkran anaEkran = new AnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            else MessageBox.Show("Giriş Başarısız! Lütfen Tekrar Deneyin..");
        }
    }
}
