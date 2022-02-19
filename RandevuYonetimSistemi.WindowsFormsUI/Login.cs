using BL;
using System;
using System.Windows.Forms;

namespace RandevuYonetimSistemi.WindowsFormsUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //KullaniciManager manager = new KullaniciManager();
        LoginManager loginManager = new LoginManager();

        public static int kullId = 0;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //var kullanici = manager.Get(kullaniciAdi: txtKullaniciAdi.Text.Trim(), sifre: txtSifre.Text.Trim());

            var kullanici = loginManager.Get(kul => kul.KullaniciAdi == txtKullaniciAdi.Text.Trim() & kul.Sifre == txtSifre.Text.Trim());
            //trim metodu textboxdan gelen datanın önündeki ve sonundaki boşlukları kaldırır
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
