using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BL;

namespace RandevuYonetimSistemi.WindowsFormsUI
{
    public partial class RandevuYonetimi : Form
    {
        public RandevuYonetimi()
        {
            InitializeComponent();
        }
        RandevuManager manager = new RandevuManager();
        LogManager logManager = new LogManager();
        HastaManager hastaManager = new HastaManager();
        DoktorManager doktorManager = new DoktorManager();
        private void RandevuYonetimi_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            dgvRandevular.DataSource = manager.GetAll();
            cbDoktorlar.DataSource = doktorManager.GetAll();
            cbHastalar.DataSource = hastaManager.GetAll();
        }
        void Temizle()
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            foreach (var item in nesneler)
            {
                item.Clear();
            }
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Randevu
                {
                    DoktorId = (int)cbDoktorlar.SelectedValue,
                    HastaId = (int)cbHastalar.SelectedValue,
                    KronikHastalik = cbKronikHastalik.Checked,
                    RandevuTarihi = dtpRandevuTarihi.Value,
                    Sgk = cbSgk.Checked,
                    Sikayet = txtSikayet.Text,
                    KullaniciId = Login.kullId
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
                    HataBilgi = "Randevu yönetimi, Ekle metodu"
                });
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvRandevular.CurrentRow.Cells[0].Value;

                var sonuc = manager.Update(new Randevu
                {
                    Id = id,
                    DoktorId = (int)cbDoktorlar.SelectedValue,
                    HastaId = (int)cbHastalar.SelectedValue,
                    KronikHastalik = cbKronikHastalik.Checked,
                    RandevuTarihi = dtpRandevuTarihi.Value,
                    Sgk = cbSgk.Checked,
                    Sikayet = txtSikayet.Text,
                    KullaniciId = Login.kullId
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
                    HataBilgi = "Randevu yönetimi, Güncelle metodu"
                });
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void dgvRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;

            int id = (int)dgvRandevular.CurrentRow.Cells[0].Value;
            var kayit = manager.Find(id);

            txtSikayet.Text = kayit.Sikayet;
            cbHastalar.SelectedValue = kayit.HastaId;
            cbDoktorlar.SelectedValue = kayit.DoktorId;
            dtpRandevuTarihi.Value = kayit.RandevuTarihi;
            cbKronikHastalik.Checked = kayit.KronikHastalik;
            cbSgk.Checked = kayit.Sgk;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                int id = (int)dgvRandevular.CurrentRow.Cells[0].Value;
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
