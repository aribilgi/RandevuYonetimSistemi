using BL;
using Entities;
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
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        KullaniciManager manager = new KullaniciManager();
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtAdi.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbDurum.Checked = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var sonuc = manager.Add(new Kullanici
            {
                Adi = txtAdi.Text,
                Durum = cbDurum.Checked,
                Email = txtEmail.Text,
                KayitTarihi = DateTime.Now,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                Soyadi = txtSoyadi.Text
            });
            if (sonuc > 0)
            {
                Temizle();
                Yukle();
                MessageBox.Show("Kayıt eklendi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKullanicilar.CurrentRow.Cells[0].Value;

            var sonuc = manager.Update(new Kullanici
            {
                Id = id,
                Adi = txtAdi.Text,
                Durum = cbDurum.Checked,
                Email = txtEmail.Text,
                KayitTarihi = DateTime.Now,
                KullaniciAdi = txtKullaniciAdi.Text,
                Sifre = txtSifre.Text,
                Soyadi = txtSoyadi.Text
            });
            if (sonuc > 0)
            {
                Temizle();
                Yukle();
                MessageBox.Show("Kayıt Güncellendi");
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvKullanicilar.CurrentRow.Cells[0].Value;
            var kayit = manager.Find(id);

            txtAdi.Text = kayit.Adi;
            txtEmail.Text = kayit.Email;
            txtKullaniciAdi.Text = kayit.KullaniciAdi;
            txtSifre.Text = kayit.Sifre;
            txtSoyadi.Text = kayit.Soyadi;
            cbDurum.Checked = kayit.Durum;

            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int id = (int)dgvKullanicilar.CurrentRow.Cells[0].Value;
                var silinecekKayit = manager.Find(id);

                var sonuc = manager.Delete(silinecekKayit);
                if (sonuc > 0)
                {
                    Temizle();
                    Yukle();
                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;
                    MessageBox.Show("Kayıt Silindi");                    
                }
            }            
        }
    }
}
