using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;

namespace RandevuYonetimSistemi.WindowsFormsUI
{
    public partial class DoktorYonetimi : Form
    {
        public DoktorYonetimi()
        {
            InitializeComponent();
        }
        DoktorManager manager = new DoktorManager();
        LogManager logManager = new LogManager();
        private void DoktorYonetimi_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            dgvDoktorlar.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            txtTelefon.Text = string.Empty;
            txtTcNo.Text = string.Empty;
            txtSoyadi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdres.Text = string.Empty;
            txtAdi.Text = string.Empty;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtAdi.Text) & !string.IsNullOrWhiteSpace(txtSoyadi.Text) & !string.IsNullOrWhiteSpace(txtTcNo.Text))
                {
                    var sonuc = manager.Add(new Doktor
                    {
                        Adi = txtAdi.Text,
                        Adres = txtAdres.Text,
                        Email = txtEmail.Text,
                        KayitTarihi = DateTime.Now,
                        Soyadi = txtSoyadi.Text,
                        TcNo = txtTcNo.Text,
                        Telefon = txtTelefon.Text
                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Doldur();
                        MessageBox.Show("Kayıt Başarılı");
                    }
                }
                else MessageBox.Show("Adı, Soyadı, TC Numarası Boş Geçilemez!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!");
                logManager.Add(new Log
                {
                    CreateDate = DateTime.Now,
                    Error = hata.Message,
                    HataBilgi = "Doktor yönetimi, Ekle metodu"
                });
            }
        }

        private void dgvDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;

            int id = (int)dgvDoktorlar.CurrentRow.Cells[0].Value;
            var kayit = manager.Find(id);

            txtAdi.Text = kayit.Adi;
            txtAdres.Text = kayit.Adres;
            txtEmail.Text = kayit.Email;
            txtSoyadi.Text = kayit.Soyadi;
            txtTcNo.Text = kayit.TcNo;
            txtTelefon.Text = kayit.Telefon;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)dgvDoktorlar.CurrentRow.Cells[0].Value;

            if (!string.IsNullOrWhiteSpace(txtAdi.Text) & !string.IsNullOrWhiteSpace(txtSoyadi.Text) & !string.IsNullOrWhiteSpace(txtTcNo.Text))
            {
                try
                {
                    var sonuc = manager.Update(new Doktor
                    {
                        Id = id,
                        Adi = txtAdi.Text,
                        Adres = txtAdres.Text,
                        Email = txtEmail.Text,
                        //KayitTarihi = DateTime.Now,
                        Soyadi = txtSoyadi.Text,
                        TcNo = txtTcNo.Text,
                        Telefon = txtTelefon.Text
                    });
                    if (sonuc > 0)
                    {
                        Temizle();
                        Doldur();
                        MessageBox.Show("Kayıt Başarılı");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu!");
                    logManager.Add(new Log
                    {
                        CreateDate = DateTime.Now,
                        Error = hata.Message,
                        HataBilgi = "Doktor yönetimi, Güncelle metodu"
                    });
                }
            }
            else MessageBox.Show("Adı, Soyadı, TC Numarası Boş Geçilemez!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                int id = (int)dgvDoktorlar.CurrentRow.Cells[0].Value;
                var kayit = manager.Find(id);

                var sonuc = manager.Delete(kayit);

                if (sonuc > 0)
                {
                    Temizle();
                    Doldur();
                    MessageBox.Show("Kayıt Silindi!");
                }
            }
        }
    }
}
