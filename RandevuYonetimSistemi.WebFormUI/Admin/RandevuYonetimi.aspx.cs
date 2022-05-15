using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BL;

namespace RandevuYonetimSistemi.WebFormUI
{
    public partial class RandevuYonetimi : System.Web.UI.Page
    {
        RandevuManager manager = new RandevuManager();
        LogManager logManager = new LogManager();
        HastaManager hastaManager = new HastaManager();
        DoktorManager doktorManager = new DoktorManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack) Doldur(); // Eğer sayfa post back edilmemişse yani sayfadaki ekle, güncelle, sil vb butona tıklanmamışsa doldur metodunu çalıştır.
        }
        void Doldur()
        {
            dgvRandevular.DataSource = manager.GetAll();
            dgvRandevular.DataBind();
            cbDoktorlar.DataSource = doktorManager.GetAll();
            cbDoktorlar.DataBind();
            cbHastalar.DataSource = hastaManager.GetAll();
            cbHastalar.DataBind();
        }
        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Randevu
                {
                    DoktorId = Convert.ToInt32(cbDoktorlar.SelectedValue),
                    HastaId = Convert.ToInt32(cbHastalar.SelectedValue),
                    KronikHastalik = cbKronikHastalik.Checked,
                    RandevuTarihi = dtpRandevuTarihi.SelectedDate,
                    Sgk = cbSgk.Checked,
                    Sikayet = txtSikayet.Text,
                    KullaniciId = 1
                });
                if (sonuc > 0)
                {
                    Response.Redirect("RandevuYonetimi.aspx");
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
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }

        protected void dgvRandevular_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;

            int id = Convert.ToInt32(dgvRandevular.SelectedRow.Cells[1].Text);
            var kayit = manager.Find(id);

            txtSikayet.Text = kayit.Sikayet;
            cbHastalar.SelectedValue = kayit.HastaId.ToString();
            cbDoktorlar.SelectedValue = kayit.DoktorId.ToString();
            dtpRandevuTarihi.SelectedDate = kayit.RandevuTarihi;
            cbKronikHastalik.Checked = kayit.KronikHastalik;
            cbSgk.Checked = kayit.Sgk;
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvRandevular.SelectedRow.Cells[1].Text);
                var sonuc = manager.Update(new Randevu
                {
                    Id = id,
                    DoktorId = Convert.ToInt32(cbDoktorlar.SelectedValue),
                    HastaId = Convert.ToInt32(cbHastalar.SelectedValue),
                    KronikHastalik = cbKronikHastalik.Checked,
                    RandevuTarihi = dtpRandevuTarihi.SelectedDate,
                    Sgk = cbSgk.Checked,
                    Sikayet = txtSikayet.Text,
                    KullaniciId = 1
                });
                if (sonuc > 0)
                {
                    Response.Redirect("RandevuYonetimi.aspx");
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
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }

        protected void cbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var doktor = doktorManager.Find(Convert.ToInt32(cbDoktorlar.SelectedValue));
            ltDoktorDetay.Text = $"<b>{doktor.Adi} {doktor.Soyadi}</b>";
        }

        protected void cbHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hasta = hastaManager.Find(Convert.ToInt32(cbHastalar.SelectedValue));
            ltHastaDetay.Text = $"<b>{hasta.Adi} {hasta.Soyadi}</b>";
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvRandevular.SelectedRow.Cells[1].Text);
                var kayit = manager.Find(id);
                var sonuc = manager.Delete(kayit);
                if (sonuc > 0)
                {
                    Response.Redirect("RandevuYonetimi.aspx");
                }
            }
            catch (Exception hata)
            {
                logManager.Add(new Log
                {
                    CreateDate = DateTime.Now,
                    Error = hata.ToString(),
                    HataBilgi = "Randevu yönetimi, Sil metodu"
                });
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }
    }
}