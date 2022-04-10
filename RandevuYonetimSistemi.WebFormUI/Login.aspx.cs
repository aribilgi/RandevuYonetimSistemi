using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace RandevuYonetimSistemi.WebFormUI
{
    public partial class Login : System.Web.UI.Page
    {
        LoginManager manager = new LoginManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var kul = manager.Get(k => k.KullaniciAdi == txtKullaniciAdi.Text.Trim() & k.Sifre == txtSifre.Text.Trim() & k.Durum);
            if (kul != null)
            {
                Session["admin"] = kul;
                Response.Redirect("Default.aspx");
            }
            else Response.Write("<script>alert('Giriş Başarısız!')</script>");
        }
    }
}