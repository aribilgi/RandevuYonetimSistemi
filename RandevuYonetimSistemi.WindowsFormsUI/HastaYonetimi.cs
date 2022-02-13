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
    public partial class HastaYonetimi : Form
    {
        public HastaYonetimi()
        {
            InitializeComponent();
        }
        HastaManager manager = new HastaManager();
        LogManager logManager = new LogManager();
        private void HastaYonetimi_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            dgvHastalar.DataSource = manager.GetAll();
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            txtYas.Text = string.Empty;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAdi.Text) & !string.IsNullOrWhiteSpace(txtSoyadi.Text) & !string.IsNullOrWhiteSpace(txtTcNo.Text) & !string.IsNullOrWhiteSpace(txtTelefon.Text) & !string.IsNullOrWhiteSpace(txtYas.Text))
            {
                try
                {
                    var sonuc = manager.Add(new Hasta
                    {
                        Adi = txtAdi.Text,
                        Adres = txtAdres.Text,
                        Email = txtEmail.Text,
                        KayitTarihi = DateTime.Now,
                        HastaYakinBilgisi = txtHastaYakinBilgisi.Text,
                        KanGrubu = txtKanGrubu.Text,
                        Meslek = txtMeslek.Text,
                        Soyadi = txtSoyadi.Text,
                        TcNo = txtTcNo.Text,
                        Telefon = txtTelefon.Text,
                        Yasi = Convert.ToInt32(txtYas.Text)
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
                    logManager.Add(new Log
                    {
                        CreateDate = DateTime.Now,
                        Error = hata.Message,
                        HataBilgi = "Hasta yönetimi, Ekle metodu"
                    });
                    MessageBox.Show("Hata Oluştu!");                    
                }
            }
            else MessageBox.Show("Adı, Soyadı, TC Numarası ve Telefon Boş Geçilemez!");
        }

        private void dgvHastalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;

            int id = (int)dgvHastalar.CurrentRow.Cells[0].Value;
            var kayit = manager.Find(id);

            txtAdi.Text = kayit.Adi;
            txtAdres.Text = kayit.Adres;
            txtEmail.Text = kayit.Email;
            txtSoyadi.Text = kayit.Soyadi;
            txtTcNo.Text = kayit.TcNo;
            txtTelefon.Text = kayit.Telefon;
            txtHastaYakinBilgisi.Text = kayit.HastaYakinBilgisi;
            txtKanGrubu.Text = kayit.KanGrubu;
            txtMeslek.Text = kayit.Meslek;
            txtYas.Text = kayit.Yasi.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAdi.Text) & !string.IsNullOrWhiteSpace(txtSoyadi.Text) & !string.IsNullOrWhiteSpace(txtTcNo.Text) & !string.IsNullOrWhiteSpace(txtTelefon.Text) & !string.IsNullOrWhiteSpace(txtYas.Text))
            {
                try
                {
                    int id = (int)dgvHastalar.CurrentRow.Cells[0].Value;
                    var sonuc = manager.Update(new Hasta
                    {
                        Id = id,
                        Adi = txtAdi.Text,
                        Adres = txtAdres.Text,
                        Email = txtEmail.Text,
                        //KayitTarihi = DateTime.Now,
                        HastaYakinBilgisi = txtHastaYakinBilgisi.Text,
                        KanGrubu = txtKanGrubu.Text,
                        Meslek = txtMeslek.Text,
                        Soyadi = txtSoyadi.Text,
                        TcNo = txtTcNo.Text,
                        Telefon = txtTelefon.Text,
                        Yasi = Convert.ToInt32(txtYas.Text)
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
                    logManager.Add(new Log
                    {
                        CreateDate = DateTime.Now,
                        Error = hata.Message,
                        HataBilgi = "Hasta yönetimi, Güncelle metodu"
                    });
                    MessageBox.Show("Hata Oluştu!");
                }
            }
            else MessageBox.Show("Adı, Soyadı, TC Numarası ve Telefon Boş Geçilemez!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                int id = (int)dgvHastalar.CurrentRow.Cells[0].Value;
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
