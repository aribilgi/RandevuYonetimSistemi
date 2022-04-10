using System;
using BL;

namespace RandevuYonetimSistemi.WebFormUI
{
    public partial class LogKayitlari : System.Web.UI.Page
    {
        LogManager manager = new LogManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvLoglar.DataSource = manager.GetAll();
            dgvLoglar.DataBind();
        }
    }
}