using System;
using BL;
using Entities;


namespace RandevuYonetimSistemi.WebFormUI
{
    public partial class ContactUs : System.Web.UI.Page
    {
        LogManager logManager = new LogManager();
        ContactManager contactManager = new ContactManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            var sonuc = contactManager.Add(new Contact
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Message = txtMessage.Text,
                CreateDate = DateTime.Now
            });
            try
            {
                if (sonuc > 0)
                {
                    pnlForm.Visible = false;
                    pnlMesaj.Visible = true;
                    pnlMesaj.CssClass = "alert alert-success";
                    ltMesaj.Text = "Teşkkürler.. Mesajınız Bize Ulaşmıştır.";
                }
            }
            catch (Exception hata)
            {
                pnlMesaj.Visible = true;
                pnlMesaj.CssClass = "alert alert-success";
                ltMesaj.Text = "Hata Oluştu.. Mesajınız Gönderilemedi!!";
                logManager.Add(new Log
                {
                    CreateDate = DateTime.Now,
                    Error = hata.ToString(),
                    HataBilgi ="Contactus sayfasında mesaj gönderiminde hata oluştu!!"
                });
            }
            
            
        }
    }
}