using System;
using BL;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RandevuYonetimSistemi.WebFormUI
{
    public partial class KullaniciYonetimi : System.Web.UI.Page
    {
        KullaniciManager manager = new KullaniciManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKullanicilar.DataSource = manager.GetAll();
            dgvKullanicilar.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            try
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
                    Response.Redirect("KullaniciYonetimi.aspx");
                }
            }
            catch
            {
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }

        protected void dgvKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvKullanicilar.SelectedRow.Cells[1].Text);
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

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.SelectedRow.Cells[1].Text);
                var sonuc = manager.Update(new Kullanici
                {
                    Id = id,
                    Adi = txtAdi.Text,
                    Durum = cbDurum.Checked,
                    Email = txtEmail.Text,
                    KayitTarihi = Convert.ToDateTime(dgvKullanicilar.SelectedRow.Cells[8].Text),
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text,
                    Soyadi = txtSoyadi.Text
                });
                if (sonuc > 0)
                {
                    Response.Redirect("KullaniciYonetimi.aspx");
                }
            }
            catch
            {
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKullanicilar.SelectedRow.Cells[1].Text);
                var silinecekKayit = manager.Find(id);
                var sonuc = manager.Delete(silinecekKayit);
                if (sonuc > 0)
                {
                    Response.Redirect("KullaniciYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }
    }
}