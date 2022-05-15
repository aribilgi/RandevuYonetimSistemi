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
    public partial class SignUp : System.Web.UI.Page
    {
        HastaManager manager = new HastaManager();
        LogManager logManager = new LogManager();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = manager.Add(new Hasta
                {
                    Adi = txtAdi.Value,
                    Adres = txtAdres.Value,
                    Email = txtEmail.Value,
                    KayitTarihi = DateTime.Now,
                    HastaYakinBilgisi = txtHastaYakinBilgisi.Value,
                    KanGrubu = txtKanGrubu.Value,
                    Meslek = txtMeslek.Value,
                    Soyadi = txtSoyadi.Value,
                    TcNo = txtTcNo.Value,
                    Telefon = txtTelefon.Value,
                    Yasi = Convert.ToInt32(txtYas.Value)
                });
                if (sonuc > 0)
                {
                    kayitFormu.Visible = false; // kayıt formunu gizle
                    ltMesaj.Text = "<h3>Teşekkürler..</h3><div class='alert alert-success'>Kaydınız Başarıyla Tamamlanmıştır.</div>";
                }
            }
            catch (Exception hata)
            {
                ltMesaj.Text = "<h3>Hata Oluştu..</h3><div class='alert alert-danger'>Kaydınız Tamamlanamadı!</div>";
                logManager.Add(new Log
                {
                    CreateDate = DateTime.Now,
                    Error = hata.Message,
                    HataBilgi = "Hasta kayıt formu, Önyüz Ekle metodu"
                });
            }
        }
    }
}