using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RandevuYonetimSistemi.WebFormUI
{
    public partial class HastaYonetimi : System.Web.UI.Page
    {
        HastaManager manager = new HastaManager();
        LogManager logManager = new LogManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        void Doldur()
        {
            dgvHastalar.DataSource = manager.GetAll();
            dgvHastalar.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
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
                        Response.Redirect("HastaYonetimi.aspx");
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
                    Response.Write("<script>alert('Hata Oluştu!')</script>");
                }
            }
            else Response.Write("<script>alert('Adı, Soyadı, TC Numarası, Telefon, Yaş Boş Geçilemez!')</script>");
        }

        protected void dgvHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                int id = Convert.ToInt32(dgvHastalar.SelectedRow.Cells[1].Text);
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
            catch (Exception)
            {
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAdi.Text) & !string.IsNullOrWhiteSpace(txtSoyadi.Text) & !string.IsNullOrWhiteSpace(txtTcNo.Text) & !string.IsNullOrWhiteSpace(txtTelefon.Text) & !string.IsNullOrWhiteSpace(txtYas.Text))
            {
                try
                {
                    int id = Convert.ToInt32(dgvHastalar.SelectedRow.Cells[1].Text);
                    var sonuc = manager.Update(new Hasta
                    {
                        Id = id,
                        Adi = txtAdi.Text,
                        Adres = txtAdres.Text,
                        Email = txtEmail.Text,
                        KayitTarihi = Convert.ToDateTime(dgvHastalar.SelectedRow.Cells[12].Text),
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
                        Response.Redirect("HastaYonetimi.aspx");
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
                    Response.Write("<script>alert('Hata Oluştu!')</script>");
                }
            }
            else Response.Write("<script>alert('Adı, Soyadı, TC Numarası, Telefon, Yaş Boş Geçilemez!')</script>");
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvHastalar.SelectedRow.Cells[1].Text);
                var kayit = manager.Find(id);

                var sonuc = manager.Delete(kayit);

                if (sonuc > 0)
                {
                    Response.Redirect("HastaYonetimi.aspx");
                }
            }
            catch (Exception hata)
            {
                logManager.Add(new Log
                {
                    CreateDate = DateTime.Now,
                    Error = hata.Message,
                    HataBilgi = "Hasta yönetimi, Sil metodu"
                });
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }
    }
}