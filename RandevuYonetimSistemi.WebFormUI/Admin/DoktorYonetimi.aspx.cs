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
    public partial class DoktorYonetimi : System.Web.UI.Page
    {
        DoktorManager manager = new DoktorManager();
        LogManager logManager = new LogManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvDoktorlar.DataSource = manager.GetAll();
            dgvDoktorlar.DataBind(); // Web uygulamasında bu kodu da yazmamız gerekiyor dataların gridview a yüklenmesi için! Yoksa veri gelmez!
        }

        protected void btnEkle_Click(object sender, EventArgs e)
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
                    if (sonuc > 0) // Eğer kayıt başarılıysa
                    {
                        Response.Redirect("DoktorYonetimi.aspx"); // Sayfayı DoktorYonetimi.aspx e yönlendir
                    }
                }
                else Response.Write("<script>alert('Adı, Soyadı, TC Numarası Boş Geçilemez!')</script>");
            }
            catch (Exception hata)
            {
                Response.Write("<script>alert('Hata Oluştu!')</script>");
                logManager.Add(new Log
                {
                    CreateDate = DateTime.Now,
                    Error = hata.Message,
                    HataBilgi = "Doktor yönetimi, Ekle metodu"
                });
            }
        }

        protected void dgvDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;

            try
            {
                int id = Convert.ToInt32(dgvDoktorlar.SelectedRow.Cells[1].Text);
                var kayit = manager.Find(id);

                txtAdi.Text = kayit.Adi;
                txtAdres.Text = kayit.Adres;
                txtEmail.Text = kayit.Email;
                txtSoyadi.Text = kayit.Soyadi;
                txtTcNo.Text = kayit.TcNo;
                txtTelefon.Text = kayit.Telefon;
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvDoktorlar.SelectedRow.Cells[1].Text);

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
                        KayitTarihi = Convert.ToDateTime(dgvDoktorlar.SelectedRow.Cells[8].Text),
                        Soyadi = txtSoyadi.Text,
                        TcNo = txtTcNo.Text,
                        Telefon = txtTelefon.Text
                    });
                    if (sonuc > 0)
                    {
                        Response.Redirect("DoktorYonetimi.aspx");
                    }
                }
                catch (Exception hata)
                {
                    Response.Write("<script>alert('Hata Oluştu!')</script>");
                    logManager.Add(new Log
                    {
                        CreateDate = DateTime.Now,
                        Error = hata.Message,
                        HataBilgi = "Doktor yönetimi, Güncelle metodu"
                    });
                }
            }
            else Response.Write("<script>alert('Adı, Soyadı, TC Numarası Boş Geçilemez!')</script>");
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvDoktorlar.SelectedRow.Cells[1].Text);
                var kayit = manager.Find(id);
                var sonuc = manager.Delete(kayit);
                if (sonuc > 0)
                {
                    Response.Redirect("DoktorYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Hata Oluştu!')</script>");
            }
        }

        protected void btnAra_Click(object sender, EventArgs e)
        {
            dgvDoktorlar.DataSource = manager.GetAll(d => d.Adi.Contains(txtAra.Text.Trim()) | d.Soyadi.Contains(txtAra.Text.Trim()));
            dgvDoktorlar.DataBind();
        }
    }
}