using System;

namespace RandevuYonetimSistemi.WebFormUI
{
    public partial class AnaEkran : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null) // eğer seyşın boşsa
            {
                Response.Redirect("Login.aspx"); // kullanıcıyı logine yönlendir
            }
        }

        protected void lbCikis_Click(object sender, EventArgs e)
        {
            Session.Remove("admin");
            Response.Redirect("Login.aspx");
        }
    }
}